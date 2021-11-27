using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using CharterSampleApp.Models;
using CharterSampleApp.Views;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class BillingViewModel : BaseViewModel
    {
        public BillingViewModel()
        {
            SortIcon = "\uf103"; // Changes for up or down sort arrows

            GetBillingCollection();
        }

        private void GetBillingCollection()
        {
            BillingStatements = new ObservableCollection<BillingStatement>();

            //Get fake user billing statements for demonstration purposes
            BillingStatements = _Repository.GetUserBillingStatements();

            //Separate collection used for data manipulation - filter,  search, sort
            DisplayedBillingStatements = new ObservableCollection<BillingStatement>(BillingStatements);

            // Bindable string for searching through billing statements
            SearchString = string.Empty;
        }

     
        private ObservableCollection<BillingStatement> billingStatements;
        public ObservableCollection<BillingStatement> BillingStatements
        {
            get { return billingStatements; }
            set
            {
                billingStatements = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<BillingStatement> displayedBillingStatements;
        public ObservableCollection<BillingStatement> DisplayedBillingStatements
        {
            get { return displayedBillingStatements; }
            set
            {
                displayedBillingStatements = value;
                OnPropertyChanged();
            }
        }

        private ICommand refreshStatementListCommand;
        public ICommand RefreshStatementListCommand =>
            refreshStatementListCommand ??
            (refreshStatementListCommand = new Command(ExecuteRefreshStatementListCommand));

        private void ExecuteRefreshStatementListCommand()
        {
            IsBusy = true;

          BillingStatements.Clear();

            GetBillingCollection();

            //if (BillingStatements == null)
            //{
            //    return false;
            //}
            //else
            //{
            //     return true;  
            //}

            IsBusy = false;
        }


        #region Select



        private BillingStatement selectedBillingStatement;
        public BillingStatement SelectedBillingStatement
        {
            get { return selectedBillingStatement; }
            set
            {
                selectedBillingStatement = value;
                OnPropertyChanged();
            }
        }

        private ICommand _billingStatementOnItemSelectedCommand;
        public ICommand BillingStatementOnItemSelectedCommand =>
            _billingStatementOnItemSelectedCommand ??
            (_billingStatementOnItemSelectedCommand = new Command<object>(async (x) => await ExecuteBillingStatementOnItemSelectedCommand(x)));

        private async Task ExecuteBillingStatementOnItemSelectedCommand(object selection)
        {
            if (selection == null)
            {
                return;
            }

            BillingStatement SelectedBillingStatement = selection as BillingStatement;

            selection = null;

            if (SelectedBillingStatement != null)
            {
                App.SelectedBillingStatement = SelectedBillingStatement;

                // This will push the ItemDetailPage onto the navigation stack
                await Shell.Current.GoToAsync("billingdetailpage");

            }

            SelectedItem = null;

            return;
        }

        #endregion

        #region Search

        private string searchString;
        public string SearchString
        {
            get { return searchString; }
            set
            {
                searchString = value;

                OnPropertyChanged();
            }
        }

        private ICommand searchCollectionViewCommand;
        public ICommand SearchCollectionViewCommand =>
            searchCollectionViewCommand ??
            (searchCollectionViewCommand = new Command(ExecuteSearchCollectionViewCommand));

        private void ExecuteSearchCollectionViewCommand()
        {
            if (SearchString.Length > 0)
            {
                IEnumerable<BillingStatement> suggestionsSearched;
                suggestionsSearched = BillingStatements.Where(c =>
                    c.BillingMonth.StartsWith(SearchString, true, CultureInfo.CurrentCulture));
                DisplayedBillingStatements = new ObservableCollection<BillingStatement>(suggestionsSearched);
            }
            else
            {
                DisplayedBillingStatements = BillingStatements;
            }
        }

        #endregion

        #region Filter

        private ICommand filterBillingStatementsCommand;
        public ICommand FilterBillingStatementsCommand =>
            filterBillingStatementsCommand ??
            (filterBillingStatementsCommand = new Command(async (x) => await ExecuteFilterBillingStatementsCommand()));

        async Task ExecuteFilterBillingStatementsCommand()
        {
            string filterFactor = await App.Current.MainPage.DisplayActionSheet("Filter Billing Statements", "Cancel",
                null, "Past Statements", "Present Statements", "All Statements");

            FilterStatements(filterFactor);

        }

        void FilterStatements(string filterFactor = "All Statements")
        {
            try
            {
                ObservableCollection<BillingStatement> tempFilteredCollection = new ObservableCollection<BillingStatement>();

                switch (filterFactor)
                {
                    case "Past Statements":

                        foreach (var statement in BillingStatements)
                        {
                            if (DateTime.Parse(statement.BillingMonth) < DateTime.Today.AddMonths(-1))
                            {
                                //Include in Future trips
                                tempFilteredCollection.Add(statement);
                            }
                        }

                        break;

                    case "Present Statements":

                        foreach (var statement in BillingStatements)
                        {
                            if (DateTime.Parse(statement.BillingMonth) >= DateTime.Today.AddMonths(-1))
                            {
                                //Include in Future trips
                                tempFilteredCollection.Add(statement);
                            }
                        }

                        break;

                    case "All Statements":

                        tempFilteredCollection = BillingStatements;

                        break;

                    default:
                        tempFilteredCollection = BillingStatements;
                        break;
                }

                if (tempFilteredCollection.Count > 0)
                {
                    DisplayedBillingStatements = tempFilteredCollection;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                // Crashes.TrackError(exception);
            }
        }

        #endregion

        #region Sort

        private string sortIcon;
        public string SortIcon
        {
            get { return sortIcon; }
            set
            {
                sortIcon = value;
                OnPropertyChanged();
            }
        }

        private ICommand sortBillingStatementsCommand;

        public ICommand SortBillingStatementsCommand =>
            sortBillingStatementsCommand ??
            (sortBillingStatementsCommand = new Command(ExecuteSortBillingStatementsCommand));

        private void ExecuteSortBillingStatementsCommand()
        {
            List<BillingStatement> tempBillingStatements = new List<BillingStatement>();

            switch (SortIcon)
            {
                case "\uf102":

                    SortIcon = "\uf103";

                    tempBillingStatements = DisplayedBillingStatements.OrderBy(s => DateTime.Parse(s.BillingMonth)).ToList();

                    break;

                case "\uf103":

                    SortIcon = "\uf102";

                    tempBillingStatements = DisplayedBillingStatements.OrderByDescending(s => DateTime.Parse(s.BillingMonth)).ToList();

                    break;

                default:
                    tempBillingStatements = DisplayedBillingStatements.OrderBy(s => DateTime.Parse(s.BillingMonth)).ToList();
                    break;

            }

            DisplayedBillingStatements.Clear();

            DisplayedBillingStatements = new ObservableCollection<BillingStatement>(tempBillingStatements);
        }

        #endregion

    }
}
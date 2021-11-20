using System;
using System.Collections.ObjectModel;
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
            BillingStatements = new ObservableCollection<BillingStatement>();
            BillingStatements = GetDummyBillingData();
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


        private object selectedItem;
        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<BillingStatement> GetDummyBillingData()
        {
            return new ObservableCollection<BillingStatement>
            {
                new BillingStatement(){ BillingStatementId = 1, BillingMonth = "November 1, 2020", DueDate = DateTime.Now, AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
               new BillingStatement()  { BillingStatementId = 2,  BillingMonth = "November 1, 2020", DueDate = DateTime.Now, AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
              new BillingStatement()   { BillingStatementId = 3,  BillingMonth = "November 1, 2020", DueDate = DateTime.Now, AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
               new BillingStatement()  { BillingStatementId = 4,  BillingMonth = "November 1, 2020", DueDate = DateTime.Now, AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
                new BillingStatement() { BillingStatementId = 5,  BillingMonth = "November 1, 2020", DueDate = DateTime.Now, AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m}
            };
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

          BillingStatement  SelectedBillingStatement = selection as BillingStatement;

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
    }
}
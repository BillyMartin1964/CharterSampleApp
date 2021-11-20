using System;
using System.Collections.Generic;
using System.Text;
using CharterSampleApp.Models;

namespace CharterSampleApp.ViewModels
{
    public class BillingDetailViewModel : BaseViewModel
    {
        public BillingDetailViewModel()
        {
            DisplayDetals();
        }

        private void DisplayDetals()
        {
            if (App.SelectedBillingStatement != null)
            {
                SelectedBillingStatement = App.SelectedBillingStatement;
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
    }
}

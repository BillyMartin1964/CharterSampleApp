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
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            if (App.SelectedBillingStatement != null)
            {
                // Get selected statement saved to a global
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

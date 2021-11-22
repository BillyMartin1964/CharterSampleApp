using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CharterSampleApp.Models
{
    public class DummyData
    {
        public static ObservableCollection<BillingStatement> GetDummyBillingData()
        {
            return new ObservableCollection<BillingStatement>
            {
                new BillingStatement(){ BillingStatementId = 1, ServiceFrom = "11/1 - 11/30", BillingMonth = "November 1, 2020", DueDate =  "December 1, 2020", AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
               new BillingStatement()  { BillingStatementId = 2, ServiceFrom = "12/1 - 12/31",  BillingMonth = "December 1, 2020", DueDate =  "January 1, 2021", AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
              new BillingStatement()   { BillingStatementId = 3, ServiceFrom = "1/1 - 1/31",  BillingMonth = "January 1, 2021", DueDate =  "February 1, 2021", AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
               new BillingStatement()  { BillingStatementId = 4, ServiceFrom = "2/1 - 2/28",  BillingMonth = "February 1, 2021", DueDate = "March 1, 2021", AmountDue = 79.99m, RemainingBalance = 21.99m, NewCharges = 69.99m},
                new BillingStatement() { BillingStatementId = 5, ServiceFrom = "3/1 - 3/31",  BillingMonth = "March 1, 2021", DueDate = "April 1, 2021", AmountDue = 89.99m, RemainingBalance = 31.99m, NewCharges = 69.99m},
              new BillingStatement()   { BillingStatementId = 6, ServiceFrom = "4/1 - 4/30",  BillingMonth = "April 1, 2021", DueDate = "May 1, 2021", AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
               new BillingStatement()  { BillingStatementId = 7, ServiceFrom = "5/1 - 5/31",  BillingMonth = "May 1, 2021", DueDate = "June 1, 2021", AmountDue = 79.99m, RemainingBalance = 21.99m, NewCharges = 69.99m},
                new BillingStatement() { BillingStatementId = 8, ServiceFrom = "6/1 - 6/30",  BillingMonth = "June 1, 2021", DueDate = "July 1, 2021", AmountDue = 89.99m, RemainingBalance = 31.99m, NewCharges = 69.99m},
              new BillingStatement()   { BillingStatementId = 9, ServiceFrom = "7/1 - 7/31",  BillingMonth = "July 1, 2021", DueDate = "August 1, 2021", AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
               new BillingStatement()  { BillingStatementId = 10, ServiceFrom = "8/1 - 8/31",  BillingMonth = "August 1, 2021", DueDate = "September 1, 2021", AmountDue = 79.99m, RemainingBalance = 21.99m, NewCharges = 69.99m},
                new BillingStatement() { BillingStatementId = 11, ServiceFrom = "9/1 - 9/30",  BillingMonth = "September 1, 2021", DueDate = "October 1, 2021", AmountDue = 89.99m, RemainingBalance = 31.99m, NewCharges = 69.99m},
              new BillingStatement()   { BillingStatementId = 12, ServiceFrom = "10/1 - 10/31",  BillingMonth = "October 1, 2021", DueDate = "November 1, 2021", AmountDue = 69.99m, RemainingBalance = 11.99m, NewCharges = 69.99m},
               new BillingStatement()  { BillingStatementId = 13, ServiceFrom = "11/1 - 11/30",  BillingMonth = "November 1, 2021", DueDate = "December 1, 2021", AmountDue = 79.99m, RemainingBalance = 21.99m, NewCharges = 69.99m},
                new BillingStatement() { BillingStatementId = 14, ServiceFrom = "12/1 - 12/31",  BillingMonth = "December 1, 2021", DueDate = "January 1, 2022", AmountDue = 89.99m, RemainingBalance = 31.99m, NewCharges = 69.99m}
            };
        }

        public static UserAccount GetUserAccount()
        {
            return new UserAccount
            {
                AccountNumber = "123456789",
                FirstName = "Billy",
                LastName = "Martin",
                PhoneNumber = "(810) 640-5877",
                EmailAddress = "william.martin1964@outlook.com",
                Password = "Password",
                ServiceAddress = new Address()
                {
                    StreetAddress = "284375 Main St.",
                    City = "AnyTown",
                    State = "Co",
                    ZipCode = "55555"
                },
                BillingAddress = new Address()
                {
                    StreetAddress = "56789 Cross St.",
                    City = "AnyTown",
                    State = "Co",
                    ZipCode = "55555"
                }
            };
        }
    }
}

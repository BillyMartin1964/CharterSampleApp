using System;
using System.Collections.Generic;
using System.Text;

namespace CharterSampleApp.Models
{
    public class BillingStatement
    {
        public int BillingStatementId { get; set; }
        public string BillingMonth { get; set; } = "November 1, 2020";
        public DateTime DueDate { get; set; }
        public decimal AmountDue { get; set; }
        public decimal RemainingBalance { get; set; }
        public decimal NewCharges { get; set; }
    }
}

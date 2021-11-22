namespace CharterSampleApp.CharterRestApi.Models
{
    public class BillingStatement
    {
        public int BillingStatementId { get; set; }
        public string BillingMonth { get; set; } 
        public string  ServiceFrom { get; set; }
        public string DueDate { get; set; }
        public decimal AmountDue { get; set; }
        public decimal RemainingBalance { get; set; }
        public decimal NewCharges { get; set; }
    }
}

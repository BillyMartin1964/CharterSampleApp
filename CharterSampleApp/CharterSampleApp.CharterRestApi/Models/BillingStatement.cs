using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharterSampleApp.CharterRestApi.Models
{
    public class BillingStatement
    {
        [Key]
        public int BillingStatementId { get; set; }

        [ForeignKey("UserAccount")]
        public int AccountNumber { get; set; }
        public string BillingMonth { get; set; }
        public string ServiceFrom { get; set; }
        public string DueDate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal AmountDue { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal RemainingBalance { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal NewCharges { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CharterSampleApp.CharterRestApi.Models
{
    public class Address
    {
        [Key]
        public int AddressId{ get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; } 
        public string State { get; set; }
        public string ZipCode { get; set; }
        
    }
}

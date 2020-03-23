using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSS.Data
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Note { get; set; }
        
        public double Latitude { get; set; }
        
        public double Longitude { get; set; }
        
        public string PostCode { get; set; }
        
        public Helper Helper { get; set; }
        
        public int HelperId { get; set; }
    }
}
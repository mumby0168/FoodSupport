using System.ComponentModel.DataAnnotations;

namespace FSS.Data
{
    public class Helper
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Note { get; set; }
        
        public double Latitude { get; set; }
        
        public double Longitude { get; set; }
        
        public string PostCode { get; set; }
        
        public int RequestId { get; set; }
    }
}
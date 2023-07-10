using System.ComponentModel.DataAnnotations;

namespace ExcelTest.Models
{
    public class NCD_Details
    {
        [Key]
        public int ID { get; set; }
        public Patients Patient { get; set; } 
        public NCD NCD { get; set; } 
    }
}

using System.ComponentModel.DataAnnotations;

namespace ExcelTest.Models
{
    public class Allergies_Details
    {
        [Key]
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int AllergiesID { get; set; }
        public Patients Patient { get; set; }
        public Allergies Allergies { get; set; }
    }
}

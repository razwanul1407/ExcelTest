using System.ComponentModel.DataAnnotations;

namespace ExcelTest.Models
{
    public class Patients
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        public string PatientName { get; set; }

        public DiseasesInformation Diseases { get; set; }
    }
}

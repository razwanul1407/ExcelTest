using ExcelTest.Enum;
using System.ComponentModel.DataAnnotations;

namespace ExcelTest.Models
{
    public class DiseasesInformation
    {
        [Key]
        public int Id { get; set; }
        public string DiseasesName { get; set; }

        /*public static List<DiseasesInformation> GetDiseaseList()
        {
            List<DiseasesInformation> diseases = new List<DiseasesInformation>
        {
            new DiseasesInformation { Id = 1, Name = "Cancer" },
            new DiseasesInformation { Id = 2, Name = "Cardiology" },
            new DiseasesInformation { Id = 3, Name = "Biabetic" },
            new DiseasesInformation { Id = 4, Name = "Asthma" },
            new DiseasesInformation { Id = 5, Name = "Eye" },
            new DiseasesInformation { Id = 6, Name = "Mental Illness" },
            new DiseasesInformation { Id = 7, Name = "Oral HelthProblem " },
        };

            return diseases;
        }*/

        public DEnums Enums { get; set; }
    }
}

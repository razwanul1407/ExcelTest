using System.ComponentModel.DataAnnotations;

namespace ExcelTest.Models
{
    public class NCD
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}

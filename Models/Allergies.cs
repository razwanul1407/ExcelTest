﻿using System.ComponentModel.DataAnnotations;

namespace ExcelTest.Models
{
    public class Allergies
    {
        [Key]
        public int Id { get; set; }

        public string AllergiesName { get; set; }
    }
}

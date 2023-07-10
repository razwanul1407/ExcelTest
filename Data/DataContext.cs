using ExcelTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ExcelTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<DiseasesInformation> DiseasesInformation { get; set; }
        public DbSet<Allergies> Allergies { get; set; }
        public DbSet<NCD> NCDs { get; set; }
        public DbSet<Allergies_Details> Allergies_Details { get; set; }
        public DbSet<NCD_Details> NCD_Details { get; set; }
    }
}

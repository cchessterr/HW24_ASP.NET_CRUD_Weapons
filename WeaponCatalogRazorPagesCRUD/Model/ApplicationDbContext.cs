using Microsoft.EntityFrameworkCore;

namespace WeaponCatalogRazorPagesCRUD.Model
{
    public class ApplicationDbContext : DbContext
    {
        public required DbSet<Firearm> Firearms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"
                Data Source=(localdb)\.;
                Initial Catalog=weaponCatalogdb;
                Integrated Security=True;
                Pooling=False;Encrypt=True;
                Trust Server Certificate=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

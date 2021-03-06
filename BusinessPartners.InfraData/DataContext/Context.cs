using BusinessPartners.InfraData.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessPartners.InfraData.DataContext
{
    public class BusinessPartnersContext : DbContext
    {
        public DbSet<PartnerDataModel> Partners { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=BP_Data;User ID=SA;Password=Trs@2020!");
        }
    }
}
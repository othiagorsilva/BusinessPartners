using BusinessPartners.Domain.Models;
using BusinessPartners.Domain.Repositories;
using BusinessPartners.InfraData.DataContext;

namespace BusinessPartners.InfraData.Repositories
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly Context _context;

        public PartnerRepository(Context context)
        {
            _context = context;
        }

        public void Add(Partner partnerDomainModel)
        {
            Models.Partner partnerDataModel = new Models.Partner(partnerDomainModel);

            _context.Partners.Add(partnerDataModel);
            _context.SaveChanges();
        }
    }
}
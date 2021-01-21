using BusinessPartners.Domain.Models;

namespace BusinessPartners.Domain.Repositories
{
    public interface IPartnerRepository : IRepository
    {
        void Add(Partner partnerModel);
    }
}
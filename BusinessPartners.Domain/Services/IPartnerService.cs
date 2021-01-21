using BusinessPartners.Domain.Models;

namespace BusinessPartners.Domain.Services
{
    public interface IPartnerService : IService
    {
         void Add(string name, string businessName, string number);
    }
}
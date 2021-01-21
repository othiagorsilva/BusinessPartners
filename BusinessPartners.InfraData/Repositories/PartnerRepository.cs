using System;
using System.Linq;
using BusinessPartners.Domain.Models;
using BusinessPartners.Domain.Repositories;
using BusinessPartners.InfraData.DataContext;
using BusinessPartners.InfraData.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessPartners.InfraData.Repositories
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly BusinessPartnersContext _bpContext;

        public PartnerRepository(BusinessPartnersContext bpContext)
        {
            _bpContext = bpContext;
        }

        public void Add(Partner partnerDomainModel)
        {
            PartnerDataModel partnerDataModel = new PartnerDataModel(partnerDomainModel);

            _bpContext.Partners.Add(partnerDataModel);
            _bpContext.SaveChanges();
        }

        public bool BusinessNumberExists(string businessNumber) => _bpContext.Partners.AsNoTracking()
            .Any(p => p.BusinessNumber.Equals(businessNumber));

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
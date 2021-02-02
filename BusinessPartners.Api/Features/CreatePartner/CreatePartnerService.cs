using System;
using BusinessPartners.Domain.Models;
using BusinessPartners.Domain.Repositories;
using BusinessPartners.Domain.Services;

namespace BusinessPartners.Api.Services
{
    public class CreatePartnerService : IPartnerService
    {
        private readonly IPartnerRepository _partnerRepository;

        public CreatePartnerService(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        public void Add(string name, string businessName, string businessNumber)
        {
            if (!string.IsNullOrWhiteSpace(businessNumber))
            {
                if (!_partnerRepository.BusinessNumberExists(businessNumber))
                {
                    Partner partnerDomainModel = new Partner(name, businessName, businessNumber);
                    _partnerRepository.Add(partnerDomainModel);
                    return;
                }

                throw new Exception("BusinessNumber already exists");
            }

            throw new Exception("BusinessNumber cannot be null or empty");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
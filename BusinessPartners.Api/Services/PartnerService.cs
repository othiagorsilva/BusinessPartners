using System;
using BusinessPartners.Domain.Models;
using BusinessPartners.Domain.Repositories;
using BusinessPartners.Domain.Services;

namespace BusinessPartners.Api.Services
{
    public class PartnerService : IPartnerService
    {
        private readonly IPartnerRepository _partnerRepository;

        public PartnerService(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        public void Add(string name, string businessName, string businessNumber)
        {
            if (!string.IsNullOrWhiteSpace(businessNumber))
            {
                if (!_partnerRepository.BusinessNumberExists(businessNumber))
                {
                    Partner partnerModel = new Partner(name, businessName, businessNumber);
                    _partnerRepository.Add(partnerModel);
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
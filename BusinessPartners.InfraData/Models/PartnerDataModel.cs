using System;
using BusinessPartners.Domain.Models;

namespace BusinessPartners.InfraData.Models
{
    public class PartnerDataModel
    {
        protected PartnerDataModel() {}

        public PartnerDataModel(Partner domainModel)
        {
            Id = domainModel.Id;
            Name = domainModel.Name;
            BusinessName = domainModel.BusinessName;
            BusinessNumber = domainModel.BusinessNumber;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string BusinessName { get; set; }
        public string BusinessNumber { get; set; }
    }
}
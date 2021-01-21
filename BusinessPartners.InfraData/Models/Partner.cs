using System;

namespace BusinessPartners.InfraData.Models
{
    public class Partner
    {
        protected Partner() {}

        public Partner(Domain.Models.Partner domainModel)
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
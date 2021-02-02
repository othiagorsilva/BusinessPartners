using System;

namespace BusinessPartners.Domain.Models
{
    public class Partner
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string BusinessName { get; private set; }
        public string BusinessNumber { get; private set; }

        public Partner() { }

        public static Partner CreateNewPartner(string name, string businessName, string businessNumber)
        {
            return new Partner()
            {
                Id = Guid.NewGuid(),
                Name = name,
                BusinessName = businessName,
                BusinessNumber = businessNumber
            };
        }
    }
}
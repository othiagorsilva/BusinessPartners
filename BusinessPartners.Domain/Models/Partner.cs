using System;

namespace BusinessPartners.Domain.Models
{
    public class Partner
    {
        public Partner(string name, string businessName, string businessNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            BusinessName = businessName;
            BusinessNumber = businessNumber;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string BusinessName { get; set; }
        public string BusinessNumber { get; set; }
    }
}
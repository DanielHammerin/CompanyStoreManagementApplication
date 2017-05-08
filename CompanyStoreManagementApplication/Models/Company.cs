using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyStoreManagementApplication.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int OrganizationNumber { get; set; }
        public String Notes { get; set; }

        public Company(Guid id, string name, int organizationNumber, string notes)
        {
            Id = id;
            Name = name;
            OrganizationNumber = organizationNumber;
            Notes = notes;
        }
    }
}
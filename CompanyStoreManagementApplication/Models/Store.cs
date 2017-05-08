using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyStoreManagementApplication.Models
{
    public class Store
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Zip { get; set; }
        public String Country { get; set; }
        public String Longitude { get; set; }
        public String Latitude { get; set; }

        public Store(Guid id, Guid companyId, string name, string address, string city, string zip, string country, string longitude, string latitude)
        {
            Id = id;
            CompanyId = companyId;
            Name = name;
            Address = address;
            City = city;
            Zip = zip;
            Country = country;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
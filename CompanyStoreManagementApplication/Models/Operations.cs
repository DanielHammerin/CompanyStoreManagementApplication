using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyStoreManagementApplication.Models
{
    public class Operations
    {
        private DAO dao = new DAO();

        public List<Company> GetCompanies()
        {
            List<Company> companies = new List<Company>();
            foreach (CompanyStoreManagementApplication.Company c in dao.GetCompaniesFromDB())
            {
                companies.Add(new Company(c.Id, c.Name, c.OrganizationNumber, c.Notes));
            }
            return companies;
        }

        public List<Store> GetStores()
        {
            List<Store> stores = new List<Store>();
            foreach (CompanyStoreManagementApplication.Store s in dao.GetStoresFromDB())
            {
                stores.Add(new Store(s.Id, s.CompanyId, s.Name, s.Address, s.City, s.Zip, s.Country, s.Longitude, s.Latitude));
            }
            return stores;
        }

        public void AddCompany(String newName, int newON, String newNotes)
        {
            Company newCompany = new Company(Guid.NewGuid(), newName, newON, newNotes);
            dao.CreateCompany(newCompany);
        }

        public void AddStore(String newName, String newAddress, String newCity, String newZip, String newCountry, String newLong, String newLat)
        {
            Store newStore = new Store(Guid.NewGuid(), Guid.NewGuid(), newName, newAddress, newCity, newZip, newCountry, newLong, newLat);
            dao.CreateStore(newStore);
        }

        public void ChangeCompany(Company company)
        {
            Boolean b = dao.EditCompany(company);
        }

        public void ChangeStore(Store store)
        {
            Boolean b = dao.EditStore(store);
        }

        public void DeleteCompany(Company c)
        {
            CompanyStoreManagementApplication.Company delComp = new CompanyStoreManagementApplication.Company {
                Id = c.Id,
                Name = c.Name,
                OrganizationNumber = c.OrganizationNumber,
                Notes = c.Notes
            };
            dao.DeleteCompany(delComp);
        }

        public void DeleteStore(Store s)
        {
            CompanyStoreManagementApplication.Store delStore = new CompanyStoreManagementApplication.Store {
                Id = s.Id,
                CompanyId = s.CompanyId,
                Name = s.Name,
                Address = s.Address,
                City = s.City,
                Zip = s.Zip,
                Country = s.Country,
                Longitude = s.Longitude,
                Latitude = s.Latitude
            };
            dao.DeleteStore(delStore);
        }
    }
}
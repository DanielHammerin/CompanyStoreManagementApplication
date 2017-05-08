using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyStoreManagementApplication.Models
{
    public class DAO
    {
        public List<CompanyStoreManagementApplication.Company> GetCompaniesFromDB()
        {
            var context = new CompanyStoreDatabase();
            var queryResult = new List<CompanyStoreManagementApplication.Company>();
            using (context)
            {
                queryResult = context.Companies.ToList();
            }
            return queryResult;
        }

        public List<CompanyStoreManagementApplication.Store> GetStoresFromDB()
        {
            var context = new CompanyStoreDatabase();
            var queryResult = new List<CompanyStoreManagementApplication.Store>();
            using (context)
            {
                queryResult = context.Stores.ToList();
            }
            return queryResult;
        }

        public void CreateCompany(Company newCompany)
        {
            var context = new CompanyStoreDatabase();
            using (context)
            {
                context.Companies.Add( new CompanyStoreManagementApplication.Company {
                    Id = newCompany.Id,
                    Name = newCompany.Name,
                    OrganizationNumber = newCompany.OrganizationNumber,
                    Notes = newCompany.Notes
                    });
                context.SaveChanges();
            }
        }

        public void CreateStore(Store newStore)
        {
            var context = new CompanyStoreDatabase();
            using (context)
            {
                context.Stores.Add( new CompanyStoreManagementApplication.Store {
                    Id = newStore.Id,
                    CompanyId = newStore.CompanyId,
                    Name = newStore.Name,
                    Address = newStore.Address,
                    City = newStore.City,
                    Zip = newStore.Zip,
                    Country = newStore.Country,
                    Longitude = newStore.Longitude,
                    Latitude = newStore.Latitude
                    });
                context.SaveChanges();
            }
        }

        public Boolean EditCompany(Company updatedCompany)
        {
            var context = new CompanyStoreDatabase();
            using (context)
            {
                var originalCompany = context.Companies.Find(updatedCompany.Id);
                if (originalCompany != null)
                {
                    context.Entry(originalCompany).CurrentValues.SetValues(updatedCompany);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Boolean EditStore(Store updatedStore)
        {
            var context = new CompanyStoreDatabase();
            using (context)
            {
                var originalStore = context.Stores.Find(updatedStore.Id);
                if (originalStore != null)
                {
                    context.Entry(originalStore).CurrentValues.SetValues(updatedStore);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void DeleteCompany(CompanyStoreManagementApplication.Company c)
        {
            var context = new CompanyStoreDatabase();
            using (context)
            {
                context.Companies.Remove(c);
                context.SaveChanges();
            }
        }

        public void DeleteStore(CompanyStoreManagementApplication.Store s)
        {
            var context = new CompanyStoreDatabase();
            using (context)
            {
                context.Stores.Remove(s);
                context.SaveChanges();
            }
        }

    }
}
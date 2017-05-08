﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CompanyStoreManagementApplication.Data
{
    public class DbInitializer : CreateDatabaseIfNotExists<CompanyStoreDatabase>
    {
        protected override void Seed(CompanyStoreDatabase context)
        {
            context.Database.CreateIfNotExists();

            // Look for any students.
            if (context.Companies.Any())
            {
                return;   // DB has been seeded
            }

            var companies = new Company[]
            {
            new Company{Id=Guid.NewGuid(),Name="Alexander",OrganizationNumber=111,Notes="note"},
            new Company{Id=Guid.NewGuid(),Name="Alonso",OrganizationNumber=222,Notes="note"},
            new Company{Id=Guid.NewGuid(),Name="Anand",OrganizationNumber=333,Notes="note"},
            new Company{Id=Guid.NewGuid(),Name="Barzdukas",OrganizationNumber=444,Notes="note"},
            new Company{Id=Guid.NewGuid(),Name="Li",OrganizationNumber=555,Notes="note"},
            new Company{Id=Guid.NewGuid(),Name="Justice",OrganizationNumber=666,Notes="note"},
            new Company{Id=Guid.NewGuid(),Name="Norman",OrganizationNumber=777,Notes="note"},
            new Company{Id=Guid.NewGuid(),Name="Olivetto",OrganizationNumber=888,Notes="note"}
            };
            foreach (Company c in companies)
            {
                context.Companies.Add(c);
            }
            context.SaveChanges();

            var stores = new Store[]
            {
            new Store{Id=Guid.NewGuid(),CompanyId=(companies[0]).Id,Name="Nike",Address="dankave88",City="Barcelona",Zip="123qwe",Country="Spain",Longitude="2.154007",Latitude="41.390205"},
            new Store{Id=Guid.NewGuid(),CompanyId=(companies[1]).Id,Name="Addidas",Address="Magicst12",City="NewYoark",Zip="456rty",Country="USA",Longitude="-73.776016",Latitude="40.776253"},
            new Store{Id=Guid.NewGuid(),CompanyId=(companies[4]).Id,Name="Lamborghini",Address="Gågatan8",City="Barcelona",Zip="79uio",Country="Sweden",Longitude="18.063240",Latitude="59.334591"},
            };
            foreach (Store s in stores)
            {
                context.Stores.Add(s);
            }
            context.SaveChanges();
            
        }
    }
}
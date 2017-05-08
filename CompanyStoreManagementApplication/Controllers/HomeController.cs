using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyStoreManagementApplication.Controllers
{
    public class HomeController : Controller
    {
        /**
        CompanyStoreDatabase context = new CompanyStoreDatabase();
        Data.DbInitializer.Initialize(context);
        */

        public CompanyStoreDatabase dbData = new CompanyStoreDatabase();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        public ActionResult Companies()
        {
            ViewBag.Message = "Companies.";

            return View();
        }

        public ActionResult Stores()
        {
            ViewBag.Message = "Stores";

            return View();
        }
        /**
         * Methods for the Companies menu items.
         */
        public ActionResult ViewCompanies()
        {
            ViewBag.Message = "View Companies";
            List<CompanyStoreManagementApplication.Company> compList = new List<Company>();
            foreach(CompanyStoreManagementApplication.Company c in dbData.Companies)
            {
                compList.Add(new Company {
                    Id =c.Id,
                    Name =c.Name,
                    OrganizationNumber=c.OrganizationNumber,
                    Notes =c.Notes});
            }
            return PartialView(compList);
        }

        public ActionResult CreateCompany()
        {
            ViewBag.Message = "Create Companies";

            return PartialView();
        }

        public ActionResult UpdateCompany()
        {
            ViewBag.Message = "Update Companies";

            return PartialView();
        }

        public ActionResult DeleteCompany()
        {
            ViewBag.Message = "Delete Company";

            return PartialView();
        }
        /**
         * Methods for the Stores menu items.
         */
        public ActionResult ViewStores()
        {
            ViewBag.Message = "View Stores";
            List<CompanyStoreManagementApplication.Store> storeList = new List<Store>();
            foreach (CompanyStoreManagementApplication.Store s in dbData.Stores)
            {
                storeList.Add(new Store
                {
                    Id = s.Id,
                    Name = s.Name,
                    Address = s.Address,
                    City = s.City,
                    Zip = s.Zip,
                    Country = s.Country,
                    Longitude = s.Longitude,
                    Latitude = s.Latitude
                });
            }
            return PartialView(storeList);
        }

        public ActionResult CreateStore()
        {
            ViewBag.Message = "Create Store";

            return PartialView();
        }

        public ActionResult UpdateStore()
        {
            ViewBag.Message = "Update Store";

            return PartialView();
        }

        public ActionResult DeleteStore()
        {
            ViewBag.Message = "Delete Store";

            return PartialView();
        }
    }
}
namespace CompanySolution.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CompanySolution.Domain.Services;
    using CompanySolution.Domain.Models;
    using CompanySolution.Data;

    public class CompanyController : Controller
    {
        private readonly ICompanyServices companyServices;
        private readonly IDetailsServices detailsServices;
        private readonly ApplicationDbContext db;

        public CompanyController(ICompanyServices c, IDetailsServices d, ApplicationDbContext db)
        {
            this.companyServices = c;
            this.detailsServices = d;
            this.db = db;
        }

        public IActionResult Company()
        {
            var model = companyServices.GetAll();
            return View(model);
        }

        public IActionResult CompanyDetails(int id)
        {
            //var model = detailsServices.GetDetailsByCompanyId(id);
            var model = detailsServices.GetAllbyComId(id);
            return View(model);
        }

        //---------------------------------------------


        [HttpGet]
        [Route("Company/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = companyServices.GetById(id);
            return View(model);
        }


        [HttpGet]
        public IActionResult EditDetails(int id)
        {
            var model = detailsServices.GetDetailsByCompanyId(id);
            return View(model);
        }


        [HttpPost]
        public IActionResult SaveEdit(Company company)
        {
            if (ModelState.IsValid)
            {
                companyServices.Edit(company);
            }
            return RedirectToAction("Company");
        }

        [HttpPost]
        public IActionResult SaveDetails(CompanyDetails details)
        {
            if (ModelState.IsValid)
            {
                detailsServices.Edit(details);
            }
            else RedirectToAction("CompanyDetails");
            return RedirectToAction("Company");
        }


        //---------------------------------------------

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCompany(string CompanyName,string Bulstat)
        {
            companyServices.Add(CompanyName, Bulstat);

            return RedirectToAction("Company");
        }

        [HttpPost]
        public IActionResult ContractDetails(string ContractName, string Address,
            string PostCode, string City, string StartDate, string EndDate
            , int CompanyId)
        {
            if (ModelState.IsValid)
            {
                detailsServices.Add(ContractName, Address, PostCode, City,
                StartDate, EndDate, CompanyId);
            }
           

            return RedirectToAction("CompanyDetails");
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                companyServices.Delete(id);
            }
            return RedirectToAction("Company");
        }

    }
}

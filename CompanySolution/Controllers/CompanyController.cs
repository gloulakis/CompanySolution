namespace CompanySolution.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CompanySolution.Domain.Services;
    using CompanySolution.Domain.Models;
    using CompanySolution.Data;
    using Microsoft.EntityFrameworkCore;

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

        public IActionResult CompanyDetails()
        {

            return View();

        }

        //---------------------------------------------


        [HttpGet]
        [Route("Company/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = companyServices.GetById(id);
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


        //---------------------------------------------

        [HttpPost("")]
        public IActionResult CreateCompany(Company _company)
        {
            if (ModelState.IsValid)
            {
                companyServices.Add(_company);
            }
            else
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction("Company");
        }


        public IActionResult CreateDepartment(int id, CompanyDetails company)
        {
            if (ModelState.IsValid)
            {
                detailsServices.Add(company);
            }
            else
            {
                return RedirectToAction("CreateDepartment");
            }
            return RedirectToAction("Company");
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

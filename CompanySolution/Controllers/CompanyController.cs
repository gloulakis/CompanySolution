namespace CompanySolution.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CompanySolution.Domain.Services;
    using CompanySolution.Domain.Models;

    public class CompanyController : Controller
    {
        private readonly ICompanyServices companyServices;

        public CompanyController(ICompanyServices companyServices)
        {
            this.companyServices = companyServices;
        }

        public IActionResult Company()
        {
            var model = companyServices.GetAll();

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

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

namespace CompanySolution.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CompanySolution.Domain.Services;
    using CompanySolution.Domain.Models;
    using System.Dynamic;
    using System.Linq;

    public class CompanyController : Controller
    {
        private readonly ICompanyServices companyServices;
        private readonly IDetailsServices detailsServices;

        public CompanyController(ICompanyServices companyServices)
        {
            this.companyServices = companyServices;
        }





        public IActionResult Company()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.company = companyServices.GetAll();
            mymodel.details = detailsServices.GetAllDetails().ToList();


            return View(mymodel);
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

        public IActionResult CreateDepartment(int id, CompanieDetails companieDetails)
        {
            if (ModelState.IsValid)
            {
                detailsServices.Add(companieDetails);
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

namespace CompanySolution.Domain.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using CompanySolution.Data;
    using CompanySolution.Domain.Models;

    public class CompanyServices : ICompanyServices
    {                                 
        private readonly ApplicationDbContext db;

        public CompanyServices(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add (string companyName, string Bulstat)
        {
            db.company.Add(new Company {CompanyName = companyName,Bulstat = Bulstat });
            db.SaveChanges();
        }

        public void Edit(Company company)
        {
            var ComEdit = db.company.FirstOrDefault(J => J.id == company.id);
            if (ComEdit != null)
            {
                ComEdit.CompanyName = company.CompanyName;
                ComEdit.Bulstat = company.Bulstat;
                db.SaveChanges();
            }
        }

        public IEnumerable<Company> GetAll()
        {
            return db.company.ToList();
        }


        public Company GetById(int id)
        {
            return db.company.FirstOrDefault(J => J.id == id);
        }

        public void Delete(int id)
        {
            Company com = this.GetById(id);
            db.company.Remove(com);
            db.SaveChanges();
        }
    }
}

namespace CompanySolution.Domain.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using CompanySolution.Data;
    using CompanySolution.Domain.Models;

    public class DetailsServices: IDetailsServices
    {
        private readonly ApplicationDbContext db;

        public DetailsServices(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(CompanyDetails details)
        {

            db.DbCompanyDetails.Add(details);
            db.SaveChanges();
        }

        public void Edit(CompanyDetails details)
        {
            var DetailsEdit = db.DbCompanyDetails.FirstOrDefault(d => d.DetailsId == details.DetailsId);
            if (DetailsEdit != null)
            {
                DetailsEdit.ContractNumber = details.ContractNumber;
                DetailsEdit.StartDate = details.StartDate;
                DetailsEdit.EndDate = details.EndDate;
                db.SaveChanges();
            }
        }

        public void CompanyDetails(CompanyDetails details)
        {
            var Details = db.DbCompanyDetails.FirstOrDefault(d => d.CompanyId == details.CompanyId);
            if (Details != null)
            {
                Details.CompanyId = details.CompanyId;
                Details.ContractNumber = details.ContractNumber;
                Details.EndDate = details.EndDate;
                Details.StartDate = details.StartDate;
                Details.EndDate = details.EndDate;
                db.SaveChanges();
            }
        }

     

        public IEnumerable<CompanyDetails> GetDetailsByComId(int id)
        {
            return GetAll().Where(C=>C.CompanyId == id).ToList();
        }

        public CompanyDetails GetDetailsById(int id)
        {
            return db.DbCompanyDetails.FirstOrDefault(D => D.DetailsId == id);
        }

        public CompanyDetails GetDetailsByCompanyId(int id)
        {
            return db.DbCompanyDetails.FirstOrDefault(D => D.CompanyId == id);
        }

        public void Delete(int id)
        {
            CompanyDetails det = this.GetDetailsById(id);
            db.DbCompanyDetails.Remove(det);
            db.SaveChanges();
        }

        public void Apply(int id)
        {
            CompanyDetails details = GetDetailsById(id);
        }

        public IEnumerable<CompanyDetails> GetAll()
        {
            return db.DbCompanyDetails.ToList();
        }

        public IEnumerable<CompanyDetails> GetAllbyComId(int id)
        {
            return db.DbCompanyDetails.Where(c => c.CompanyId == id).ToList();
        }
    }
}

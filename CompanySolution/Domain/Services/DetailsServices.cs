namespace CompanySolution.Domain.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using CompanySolution.Data;
    using CompanySolution.Domain.Models;

    public class DetailsServices: IDetailsServices
    {
        private readonly ApplicationDbContext db;

        public void Add(CompanieDetails details)
        {
            db.CompanyDetails.Add(details);
            db.SaveChanges();
        }

        public IEnumerable<CompanieDetails> GetAlldetails()
        {
            return db.CompanyDetails.ToList();
        }

        public void Edit(CompanieDetails details)
        {
            var DetailsEdit = db.CompanyDetails.FirstOrDefault(d => d.DetailsId == details.DetailsId);
            if (DetailsEdit != null)
            {
                DetailsEdit.ContractNumber = details.ContractNumber;
                DetailsEdit.StartDate = details.StartDate;
                DetailsEdit.EndDate = details.EndDate;
                db.SaveChanges();
            }
        }

        public IEnumerable<CompanieDetails> GetAllDetails()
        {
            return db.CompanyDetails.ToList();
        }

        public CompanieDetails GetById(int id)
        {
            return db.CompanyDetails.FirstOrDefault(D => D.DetailsId == id);
        }

        public CompanieDetails GetDetailsById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            CompanieDetails det = this.GetById(id);
            db.CompanyDetails.Remove(det);
            db.SaveChanges();
        }

        public void Apply(int id)
        {
            CompanieDetails details = GetById(id);
        }
    }
}

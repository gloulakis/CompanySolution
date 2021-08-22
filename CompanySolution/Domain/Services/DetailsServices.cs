namespace CompanySolution.Domain.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using CompanySolution.Data;
    using CompanySolution.Domain.Models;

    public class DetailsServices: IDetailsServices
    {
        private readonly ApplicationDbContext db;

        public CompanieDetails CompanieDetails { get; set; }

        public DetailsServices(ApplicationDbContext db)
        {
            this.db = db;
        }

        void IDetailsServices.Add(CompanieDetails details)
        {
            db.CompanyDetails.Add(details);
            db.SaveChanges();
        }

        void IDetailsServices.Apply(int id)
        {
            CompanieDetails details = this.GetById(id);
        }

        public CompanieDetails GetById(int _id)
        {
            return db.CompanyDetails.FirstOrDefault(D => D.DetailsId == _id);
        }

        void IDetailsServices.Delete(int id)
        {
            CompanieDetails det = this.GetById(id);
            db.CompanyDetails.Remove(det);
            db.SaveChanges();
        }


        IEnumerable<CompanieDetails> IDetailsServices.GetAll()
        {
            return db.CompanyDetails.ToList();
        }
    }
}

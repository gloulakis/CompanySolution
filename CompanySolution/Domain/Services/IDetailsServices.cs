namespace CompanySolution.Domain.Services
{
    using System.Collections.Generic;
    using CompanySolution.Domain.Models;

    public interface IDetailsServices
    {
        public void Add(string CN, string A, string PC, string C, string SD, string ED
            , int CompanyId);

        CompanyDetails GetDetailsById(int id);

        CompanyDetails GetDetailsByCompanyId(int id);

        void Edit(CompanyDetails details);

        public IEnumerable<CompanyDetails> GetAll();

        public IEnumerable<CompanyDetails> GetAllbyComId(int id);

        public IEnumerable<CompanyDetails> GetDetailsByComId(int id);
        public void Delete(int id);

        public void Apply(int id);
    }
}

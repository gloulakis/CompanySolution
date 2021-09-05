namespace CompanySolution.Domain.Services
{
    using System.Collections.Generic;
    using CompanySolution.Domain.Models;

    public interface ICompanyServices
    {
        public void Add(string name, string bulstat);

        Company GetById(int id);

        void Edit(Company company);

        public IEnumerable<Company> GetAll();

        public void Delete(int id);
    }
}

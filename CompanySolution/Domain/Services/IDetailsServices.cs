namespace CompanySolution.Domain.Services
{
    using System.Collections.Generic;
    using CompanySolution.Domain.Models;

    public interface IDetailsServices
    {
        public void Add(CompanieDetails details);

        CompanieDetails GetById(int id);

        public IEnumerable<CompanieDetails> GetAll();

        public void Delete(int id);

        public void Apply(int id);
    }
}

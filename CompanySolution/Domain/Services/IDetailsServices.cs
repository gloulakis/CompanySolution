using System;
using System.Collections.Generic;
using CompanySolution.Domain.Models;

namespace CompanySolution.Domain.Services
{
    public interface IDetailsServices
    {
        public void Add(CompanieDetails details);

        CompanieDetails GetDetailsById(int id);

        void Edit(CompanieDetails details);

        public IEnumerable<CompanieDetails> GetAllDetails();

        public void Delete(int id);

        public void Apply(int id);
    }
}

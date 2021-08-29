﻿namespace CompanySolution.Domain.Services
{
    using System.Collections.Generic;
    using CompanySolution.Domain.Models;

    public interface IDetailsServices
    {
        public void Add(CompanyDetails details);

        CompanyDetails GetDetailsById(int id);

        CompanyDetails GetDetailsByCompanyId(int id);

        void Edit(CompanyDetails details);
        
        public IEnumerable<CompanyDetails> GetDetails(int id);

        public void Delete(int id);

        public void Apply(int id);
    }
}

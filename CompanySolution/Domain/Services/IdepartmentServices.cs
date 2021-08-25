using System;
using System.Collections.Generic;
using CompanySolution.Domain.Models;

namespace CompanySolution.Domain.Services
{
    public interface IdepartmentServices
    {
        public void Add (Department department);

        Department GetById(int id);

        void Edit(Department department);

        public IEnumerable<Department> GetAll();

        public void Delete(int id);

        public void Apply(int id);
    }
}

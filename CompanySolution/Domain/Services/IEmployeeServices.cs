using System;
using System.Collections.Generic;
using CompanySolution.Domain.Models;

namespace CompanySolution.Domain.Services
{
    public interface IEmployeeServices
    {
        public void Add(Employee employee);

        Employee GetDetailsById(int id);

        void Edit(Employee employee);

        public IEnumerable<Employee> GetAllDetails();

        public void Delete(int id);

        public void Apply(int id);
    }
}

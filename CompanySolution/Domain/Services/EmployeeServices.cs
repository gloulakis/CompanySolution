using System;
using System.Collections.Generic;
using CompanySolution.Data;
using CompanySolution.Domain.Models;

namespace CompanySolution.Domain.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly ApplicationDbContext db;

        public EmployeeServices(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(Employee employee)
        {
            db.employees.Add(employee);
            db.SaveChanges();
        }

        public void Apply(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllDetails()
        {
            throw new NotImplementedException();
        }

        public Employee GetDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using CompanySolution.Data;
using CompanySolution.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanySolution.Domain.Services
{
    public class DepartmentServices : IdepartmentServices
    {
        private readonly ApplicationDbContext db;
        private readonly Company company;

        public DepartmentServices(ApplicationDbContext db,Company company)
        {
            this.db = db;
            this.company = company;
        }

        public void Add(Department department)
        {
            db.departments.Add(department);
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

        public void Edit(Department department)
        {
            var ComEdit = db.departments.FirstOrDefault(J => J.id == department.id);
            if (ComEdit != null)
            {
                ComEdit.Name = department.Name;
                db.SaveChanges();
            }
        }

        public IEnumerable<Department> GetAll(int id)
        {
            var department = db.departments.Where(c => c.id == id);
            return department.ToList();
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IdepartmentServices.Add(Department department)
        {
            throw new NotImplementedException();
        }

        void IdepartmentServices.Apply(int id)
        {
            throw new NotImplementedException();
        }

        void IdepartmentServices.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IdepartmentServices.Edit(Department department)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Department> IdepartmentServices.GetAll()
        {
            throw new NotImplementedException();
        }

        Department IdepartmentServices.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

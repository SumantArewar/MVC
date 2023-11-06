using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMSApi.Models;

namespace EMSApi.Models
{
    public class DepartmentRepository : IDept
    {
        EmsDbContext context = new EmsDbContext();

        public Department FindDept(int id)
        {
            var data = context.Departments.Find(id);
            return data;
        }
        public void AddDept(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
        public void EditDept(Department dept)
        {
            Department department = context.Departments.Find(dept.Id);
            dept.DeptName = department.DeptName;
            dept.Location = department.Location;
            context.SaveChanges();
        }
        public void DeleteDept(int id)
        {
            Department department = context.Departments.Find(id);
            context.Departments.Remove(department);
            context.SaveChanges();
        }
        public List<Department>GetDepartments()
        {
            return context.Departments.ToList();
        }
    }
}
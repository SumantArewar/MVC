using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSApi.Models
{
    public class DepartmentRepository : IDept
    {
        EmsDbContext context = new EmsDbContext();

        public void AddDept(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
        public void EditDept(De)
    }
}
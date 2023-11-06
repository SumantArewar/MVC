using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSApi.Models
{
    public interface IDept
    {
        List<Department> GetDepartments();
        Department FindDept(int id);
        void AddDept(Department dept);
        void EditDept(Department dept);
        void DeleteDept(int id);
        
    }
}
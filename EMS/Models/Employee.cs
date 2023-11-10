using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models;

public partial class Employee
{
    public int Id { get; set; } 
    public int EmpId { get; set; } 

    [Required(ErrorMessage ="Name is Required")]
    public string Name { get; set; } = null!;

    [Range(10000,90000,ErrorMessage ="Salary between 10000 and 90000")]
    public int Salary { get; set; }
    [Display(Name = "Email")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;
    [DataType(DataType.Date)]
    // [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString ="{0:yyyy-MM-dd}")]
    [DobCheck(ErrorMessage = "You should be 25  year of age to work in LTI")]
    public DateTime Dob { get; set; }

    [Display(Name="Department")]
    public int DeptId { get; set; }

    public virtual Department Dept { get; set; } = null!;
}

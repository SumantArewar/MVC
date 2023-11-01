using System.ComponentModel.DataAnnotations;

namespace EMS.Models;

public class DobCheck : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        
            DateTime birthdate = Convert.ToDateTime(value);
            int year = birthdate.Year;
            int currentyear = DateTime.Now.Year;
            if(currentyear - year >= 25)
                return true;
            else 
                return false;
        
    }
}
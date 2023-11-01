using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace dotnetapp.Models;

public class Zoo
{
    public int Id{get;set;}
    public int ZId{get;set;}

    public ICollection<Animal>?Animals{get;set;}
}
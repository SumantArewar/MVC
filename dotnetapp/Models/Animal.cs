using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace dotnetapp.Models;

public class Animal
{
    public int Id{get;set;}
    public string ?Name {get;set;}

    public Zoo ?Zoo{get;set;}
}
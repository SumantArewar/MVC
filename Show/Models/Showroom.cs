using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Show.Models;

public class Showroom
{
    public int SId{get;set;}
    public string Name{get;set;}
    public string Address{get;set;}

    public ICollection<Bike>Bikes{get;set;}
}

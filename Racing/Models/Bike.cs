using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Racing.Models
{
    public class Bike
    {
        [Key]
        public int Id{get;set;}
        public string? Name{get;set;}
        public string? Model{get;set;}

        public virtual Track? Track{get;set;}
    }
}
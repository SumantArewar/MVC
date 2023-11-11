using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Racing.Models
{
    public class Track
    {
        [Key]
        public int TrId{get;set;}
        public string? TrName{get;set;}
        public int Capcity{get;set;}

        public ICollection<Bike> ?Bike{get;set;}
    }
}
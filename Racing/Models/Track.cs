using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Racing.Models
{
    public class Track
    {
        public int TrId{get;set;}
        public string? TrName{get;set;}
        public int Capcity{get;set;}

        public ICollection<Bike> Bike{get;set;}
    }
}
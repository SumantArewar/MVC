using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models
{
    public class Movie
    {
        [Key]
        public int Id{get;set;}
        [Required]
        public string Name{get;set;}
        public int YearRelease{get;set;}
        public int Rating{get;set;}
        public ICollection<Deatil> Deatils{get;set;}
    }
}
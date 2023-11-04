// using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models
{
    public class Deatil
    {
        [Key]
        public int DeatilId{get;set;}
        [Required]
        [MaxLength(30)]
        public string Actor{get;set;}
        [ForeignKey("Movie")]
        public int MovieId{get;set;}
        [MaxLength(10)]
        public string Role{get;set;}
        [MaxLength(10)]
        public string Gender{get;set;}
        public Movie Movie{get;set;}


    }
}
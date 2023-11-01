using System.ComponentModel.DataAnnotations;
namespace PordMvc.Models;

public class Product
{
    [Display(Name = "Product Id")]
    [Key]
    [Required(ErrorMessage = "Id is Compulsory")]
    public int Id{get;set;}
    [Required(ErrorMessage = "Id is Compulsory")]
    public string ?Name{get;set;} // We use ? becoz it is nullable datatype
    [Range(100,900,ErrorMessage = "Price should be batween 100 and 900")]

    public int Price{get;set;}
    public int Stock{get;set;}
    
} 
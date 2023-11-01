using System;
using System.ComponentModel.DataAnnotations;

namespace Show.Models;

public class Bike
{
    public int Id{get;set;}
    public string? BikeName{get;set;}
    public string? BikeModel{get;set;}

    public Showroom Showroom{get;set;}
}
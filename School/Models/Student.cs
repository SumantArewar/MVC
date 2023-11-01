using System;
using 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.schema;

namespace School.Models;

public class Student
{
    public int StudentId{get;set;}
    public string StudentName{get;set;}
    public DateTime? DateOfBirth {get;set;}
    public byte[] Photo {get;set;}
    public decimal Heiht{get;set;}
    public float Weight{get;set;}
    public Grade Grade{get;set;}

}
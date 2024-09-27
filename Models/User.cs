using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creating_API.Models;
public class User
{
    
    public int Id  {get; set;}
    
    public string Name  {get; set;}
    
    public string LastName {get; set;}
    
    public string Email {get; set;}
    
    public string KeyWord {get; set;}
    
    public string PhoneNumber {get; set;}
    
    public DateOnly BirthDate {get; set;}
    
    public bool DrinksAlcohol  {get; set;}
    
    public DateOnly InvitationDate {get; set;}
    
    public bool HasAllergy {get; set;}
    
    public int EventId  {get; set;}
}
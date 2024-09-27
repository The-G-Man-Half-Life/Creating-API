using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Creating_API.Models;

[Table("User")]
public class User
{
    [Column("id")]
    [Key]
    public int Id  {get; set;}

    [Column("name")]
    [StringLength(50,MinimumLength =1,ErrorMessage ="You must write at least 1 character and a maximum of 50")]
    [Required]
    public string Name  {get; set;}
    
    [Column("last_name")]
    [StringLength(150,MinimumLength =1,ErrorMessage ="You must write at least 1 character and a maximum of 150")]
    [Required]
    public string LastName {get; set;}
    
    [Column("email")]
    [EmailAddress(ErrorMessage ="You must use a valid email format")]
    [Required]
    public string Email {get; set;}
    
    [Column("key_word")]
    [StringLength(50,MinimumLength =1,ErrorMessage ="You must write at least 1 character and a maximum of 50")]
    [Required]
    public string KeyWord {get; set;}
    
    [Column("phone_number")]
    [Required]
    [RegularExpression(@"^\+57\d{3}\d{3}\d{4}$", ErrorMessage = "El número de celular debe tener el formato: +57XXXXXXXXXX.")]
    [DisplayFormat(DataFormatString = "{0:+570000000000}", ApplyFormatInEditMode = true)]
    public string PhoneNumber {get; set;}
    
    [Column("birth_date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
    [Required]
    public DateOnly BirthDate {get; set;}
    

    [Column("drink_alcohol")]
    [Required]
    public bool DrinksAlcohol  {get; set;}
    
    [Column("invitation_date")]
    [DataType(DataType.Date)]
    [Required]
    public DateOnly InvitationDate {get; set;}
    
    [Column("has_allergy")]
    [Required]
    public bool HasAllergy {get; set;}
}
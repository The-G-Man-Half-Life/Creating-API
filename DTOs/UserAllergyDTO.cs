using System.ComponentModel.DataAnnotations;

namespace Creating_API.DTOs;
public class UserAllergyDTO
{   
    [Required]
    public int AllergyId {get; set;}

    [Required]
    public int UserId {get; set;}
}

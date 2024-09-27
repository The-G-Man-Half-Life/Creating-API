using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Net.Http.Headers;

namespace Creating_API.Models;

[Table("UserAllergy")]
public class UserAllergy
{
    [Column("id")]
    [Key]
    public int Id {get; set;}

    [Column("allergy_id")]
    [ForeignKey("Allergy")]
    [Required]
    public int AllergyId {get; set;}

    [Column("user_id")]
    [ForeignKey("User")]
    [Required]
    public int UserId {get; set;}
}

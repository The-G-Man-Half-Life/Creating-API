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
    [Required]
    public int AllergyId {get; set;}

    [ForeignKey(nameof(AllergyId))]
    public Allergy? Allergy {get; set;}

    [Column("user_id")]
    [Required]
    public int UserId {get; set;}

    [ForeignKey(nameof(UserId))]
    public User? User {get; set;}
}

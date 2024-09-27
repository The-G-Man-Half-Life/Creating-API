using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Creating_API.Models;

[Table("Allergy")]
public class Allergy
{
    [Column("id")]
    [Key]
    public int Id {get; set;}

    [Column("name")]
    [Required]
    [StringLength(50,MinimumLength =1,ErrorMessage = "The name must have at least 1 character and a maximum of 50")]
    public string Name {get; set;}
}
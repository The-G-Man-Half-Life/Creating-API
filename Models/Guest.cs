using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Creating_API.Models;

[Table("Guest")]
public class Guest
{
    [Column("id")]
    [Key]
    public int Id  {get; set;}

    [Column("name")]
    [StringLength(50,MinimumLength =1,ErrorMessage ="The minimum length is of 1 character and a maximum of 50")]
    [Required]
    public string Name {get; set;}

    [Column("last_name")]
    [StringLength(150,MinimumLength =1,ErrorMessage ="The minimum length is of 1 character and a maximum of 150")]
    [Required]
    public string LastName {get; set;}

    [Column("is_pet")]
    [Required]
    public bool IsPet {get; set;}

    [Column("user_id")]
    [ForeignKey("User")]
    [Required]
    public int UserId {get; set;}

    [Column("event_id")]
    [ForeignKey("Event")]
    [Required]
    public int EventId {get; set;}
}
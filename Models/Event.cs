using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Creating_API.Models;

[Table("Event")]
public class Event
{
    [Column("id")]
    [Key]
    public int id {get; set;}

    [Column("name")]
    [StringLength(50,MinimumLength =1,ErrorMessage ="You must write at least 1 character and a maximum of 50 characters")]
    [Required]
    public required string EventName {get; set;}

    [Column("date_of_the_event")]
    [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
    [Required]
    public DateOnly DateOfTheEvent {get; set;}

    [Column("date_of_creation_event")]
    [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
    [Required]
    public DateOnly CreationDate {get; set;}
}

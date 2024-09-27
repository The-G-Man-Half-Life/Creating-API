using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Creating_API.Models;

[Table("EventUser")]
public class EventUser
{
    [Column("id")]
    [Key]
    public int Id {get; set;}

    [Column("event_id")]
    [ForeignKey("Event")]
    [Required]
    public int EventId {get; set;}

    [Column("user_id")]
    [ForeignKey("User")]
    [Required]
    public int UserId {get; set;}
}
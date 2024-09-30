using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Creating_API.Models;

[Table("EventUser")]
public class EventUser
{
    [Column("id")]
    [Key]
    public int Id {get; set;}

    [Column("user_invitation_date")]
    [DataType(DataType.Date)]
    [Required]
    public DateOnly InvitationDate {get; set;}

    [Column("event_id")]
    [Required]
    public int EventId {get; set;}

    [ForeignKey(nameof(EventId))]
    public Event? Event {get; set;}

    [Column("user_id")]
    [Required]
    public int UserId {get; set;}

    [ForeignKey(nameof(UserId))]
    public User? User {get; set;} 
}
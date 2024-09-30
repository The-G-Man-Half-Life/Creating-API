using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Creating_API.Models;

[Table("Table")]
public class Table
{
    [Column("id")]
    [Key]
    public int Id {get; set;}

    [Column("event_id")]
    [Required]
    public int EventId {get; set;}

    [ForeignKey(nameof(EventId))]
    public Event? Event {get; set;}
}

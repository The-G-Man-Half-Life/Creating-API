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
    [ForeignKey("Event")]
    [Required]
    public int EventId {get; set;}
}

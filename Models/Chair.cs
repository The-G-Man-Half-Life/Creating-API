using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Creating_API.Models;

[Table("Chair")]
public class Chair
{
    [Column("id")]
    [Key]
    public int id {get; set;}

    [Column("table_id")]
    [ForeignKey("Table")]
    [Required]
    public int TableId {get; set;}

    [Column("person_id")]
    [ForeignKey("User")]
    [Required]
    public int UserId {get; set;}

    [Column("gues_id")]
    [ForeignKey("Guest")]
    public int GuestId {get;set;}
}

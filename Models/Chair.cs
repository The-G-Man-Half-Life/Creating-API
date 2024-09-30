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
    public int Id {get; set;}
    
    [Column("table_id")]
    [Required]
    public int TableId {get; set;}

    [ForeignKey(nameof(TableId))]
    public Table? Table {get; set;}


    [Column("person_id")]
    [Required]
    public int UserId {get; set;}

    [ForeignKey(nameof(UserId))]
    public User? User {get; set;}


    [Column("guest_id")]
    [Required]
    public int GuestId {get;set;}

    [ForeignKey(nameof(GuestId))]
    public Guest? Guest {get; set;}
}

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Creating_API.DTOs;

public class AllergyDTO
{
    private readonly DbContext Context;

    [Required(ErrorMessage ="Es obligatorio este campo")]
    // [Range(0,)]
    public int UserId {get; set;}

    [Required(ErrorMessage = "")]
    public int AllergyId {get; set;}

    public AllergyDTO(DbContext Context)
    {
        this.Context = Context;
    }
}
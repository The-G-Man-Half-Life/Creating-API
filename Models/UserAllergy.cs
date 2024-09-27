using Microsoft.Net.Http.Headers;

namespace Creating_API.Models;
public class UserAllergy
{
    public int Id {get; set;}
    public int AllergyId {get; set;}
    public int UserId {get; set;}
}

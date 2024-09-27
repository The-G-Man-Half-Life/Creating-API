namespace Creating_API.Models;


public class Event
{
    public int id {get; set;}

    public string name {get; set;}

    public int TablesAmount {get; set;}
    
    public int ChairsByTable {get; set;}

    public DateOnly DateOfTheEvent {get; set;}

    public DateOnly CreationDate {get; set;}
}

namespace ToDo.Model;

public class Todo 
{   
    public required int ID { get; set; }
    public string Deadline { get; set; } = string.Empty;
    public required bool Status { get; set; }
    public string Task  { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
}
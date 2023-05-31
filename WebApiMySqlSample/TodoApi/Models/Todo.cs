namespace TodoApi.Models;

public class Todo
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedOn { get; set; }
}
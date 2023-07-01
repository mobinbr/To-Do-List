namespace classlib;
public class ToDoItems
{
    public ToDoItems(string toDoItemsId , string details,DateTime dueTime)
    {
        ToDoItemsId = toDoItemsId;
        Details = details;
        DueTime = dueTime;
    }

    public string ToDoItemsId{get; set;}
    public string Details{get; set;}
    public DateTime DueTime{get; set;}
}
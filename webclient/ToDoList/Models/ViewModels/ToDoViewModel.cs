using System.Collections.Generic;

namespace ToDoList.Models.ViewModels
{
    public class ToDoListViewModel
    {
        public List<ToDoItems> ToDoList {get; set;}
        public ToDoItems ToDo {get; set;}
    }
}

using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using Microsoft.Data.Sqlite;
using ToDoList.Models.ViewModels;
using System.Collections.Generic;
using ListApiCli.Client;
using ListApiCli.Api;
using ListApiCli.Model;

namespace ToDoList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    Configuration config;
    ItemsApi api;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        config = new Configuration() {BasePath = "http://localhost:5171"};
        api = new ItemsApi(config);
    }

    public IActionResult Index()
    {
        return View(Display());
    }

    public ToDoListViewModel Display()
    {
        List<ToDoList.Models.ToDoItems> toDoList = new();
        var tasks = api.ItemsGet();
        foreach(var task in tasks)
        {
            toDoList.Add(new ToDoList.Models.ToDoItems
            {
                ToDoItemsId = task.ToDoItemsId,
                Details = task.Details,
                DueTime = task.DueTime
            });
        }
        return new ToDoListViewModel
        {
            ToDoList = toDoList
        };
    }

    public RedirectResult AddItem(ToDoListViewModel item)
    {
        var items = api.ItemsGet();
        foreach(var i in items)
        {
            if(i.ToDoItemsId == item.ToDo.ToDoItemsId)
                return Redirect("http://localhost:5224");
        }

        if(item.ToDo.DueTime >= DateTime.Now)
        {
            api.ItemsAddItemsPost(new ListApiCli.Model.ToDoItems(item.ToDo.ToDoItemsId, item.ToDo.Details, item.ToDo.DueTime));
            return Redirect("http://localhost:5224");
        }
        else
            return Redirect("http://localhost:5224");
    }

    public RedirectResult Delete(ToDoListViewModel Item)
    {
        var items = api.ItemsGet();
        foreach(var i in items)
        {
            if(i.ToDoItemsId == Item.ToDo.ToDoItemsId)
            {
                api.ItemsDeleteitemIdDelete(Item.ToDo.ToDoItemsId);
                return Redirect("http://localhost:5224");
            }
        }
        return Redirect("http://localhost:5224");
    }
}
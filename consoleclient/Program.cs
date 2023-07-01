using ListApiCli.Api; 
using ListApiCli.Model;
using ListApiCli.Client; 
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

public class program
{
    static int tableWidth = 50;
    public static void Main()
    {
        Configuration config = new Configuration() {BasePath = "http://localhost:5171"}; 
        ItemsApi api = new ItemsApi(config);
        HubConnection connection = new HubConnectionBuilder().WithUrl("http://localhost:5171/Connection").Build();
        connection.On("Refresh", () => {});
        connection.StartAsync();
        PrintInColor("\nWelcome", ConsoleColor.Cyan);

        switch (Menu())
        {
            case "1":
                Display(api);
                Main();
                break;
            case "2":
                Add(api);
                connection.SendAsync("Connect");
                Main();
                break;
            case "3":
                Delete(api);
                connection.SendAsync("Connect");
                Main();
                break;
        }
    }

    public static string Menu()
    {
        PrintInColor("Help:\n(Display) Enter 1 to observe ToDo List\n(Add) Enter 2 to add a task\n(Delete) Enter 3 to delete a task", ConsoleColor.Cyan);

        string input = Console.ReadLine();
        while(input != "1" && input != "2" && input != "3")
        {
            PrintInColor("Please enter 1 or 2 or 3 based on your need", ConsoleColor.Red);
            input = Console.ReadLine();
        }
        return input;
    }

    public static void Display(ItemsApi ap)
    {
        try
        {
            PrintLine();
            PrintRow("Tasks", "Details", "Due Date");
            PrintLine();
            
            foreach(var t in ap.ItemsGet())
                PrintRow($"{t.ToDoItemsId}", $"{t.Details}", $"{t.DueTime}");

            PrintLine();
            ReturnMain();
        }
        catch(Exception e)
        {
            PrintInColor($"{e.Message}", ConsoleColor.Red);
        }
    }

    public static void Add(ItemsApi ap)
    {
        string Task_Name, Details;
        Console.WriteLine("Task Name: ");
        Task_Name = Console.ReadLine();
        Console.WriteLine("\nDetails: ");
        Details = Console.ReadLine();
        Console.WriteLine("\nDue Date(please enter the date like 'month/day/year'): ");
        try
        {
            DateTime DueTime = DateTime.Parse(Console.ReadLine());
            ToDoItems items = new ToDoItems(Task_Name, Details, DueTime);
            ap.ItemsAddItemsPost(items);
            PrintInColor("Task added successfully!", ConsoleColor.Green);
            ReturnMain();
        }
        catch(Exception e)
        {
            Console.WriteLine("Wrong format!");
            ReturnMain();
        }
    }

    public static void Delete(ItemsApi ap)
    {
        // TTD = Tast To Delete
        Console.WriteLine("Task to delete: ");
        try
        {
            string TTD = Console.ReadLine();
            ap.ItemsDeleteitemIdDelete(TTD);
            PrintInColor("Task deleted successfully!", ConsoleColor.Red);
            ReturnMain();
        }
        catch(Exception e)
        {
            Console.WriteLine("Task not found!");
            ReturnMain();
        }
    }

    public static void ReturnMain()
    {
        Console.WriteLine("Enter any key to return Menu"); 
        Console.ReadKey();
    }

    public static void PrintInColor(string message, ConsoleColor c)
    {
        Console.ForegroundColor = c;
        Console.WriteLine(message);
        PrintLine();
        Console.ResetColor();
    }

    static void PrintLine()
    {
        Console.WriteLine(new string('-', tableWidth));
    }

    static void PrintRow(params string[] columns)
    {
        int width = (tableWidth - columns.Length) / columns.Length;
        string row = "|";

        foreach (string column in columns)
            row += AlignCentre(column, width) + "|";

        Console.WriteLine(row);
    }

    static string AlignCentre(string text, int width)
    {
        text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

        if (string.IsNullOrEmpty(text))
            return new string(' ', width);
        else
            return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
    }
}
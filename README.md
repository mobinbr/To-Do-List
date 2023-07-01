# To-Do-List

This repository contains three client applications developed for managing a to-do list. Each client application targets a different platform and provides different functionalities. Below is a brief overview of each client:

WPF Client

The WPF client is built using WPF (Windows Presentation Foundation) technology. It consists of several methods in the MainWindow.xaml.cs file, with three main methods: Click_Add, Click_Delete, and RefreshUI. These methods interact with the database by utilizing the methods provided in the ItemsApi class. Additionally, exception handling is implemented using try-catch blocks and if statements to prevent unexpected errors. The WPF client includes a user interface with a data grid and the mentioned buttons.

ASP.NET Core Client

The ASP.NET Core client is designed for web applications. The important files in this client include HomeController, ToDoListModel, and ToDoViewModel. The HomeController contains the main methods: Delete, AddItem, and Display, which also utilize the methods available in the ItemsApi. On the frontend side, the client includes cshtml.Form, _cshtml.Layout, and cshtml.Index for HTML, as well as css.Site for CSS. These files contain various classes for different parts of the website. Similar to the WPF client, the ASP.NET Core client features a page with a table and delete and add buttons.

Console Client

The Console client is a command-line application. It consists of a single file named Program.cs, which contains the main methods: Delete, Add, Display, and Menu. By entering the numbers 1, 2, or 3 in the console, the corresponding methods mentioned earlier are executed. Similar to the previous clients, the Console client also utilizes the methods provided by ItemsApi. Additionally, there are several methods for creating a table in the console and displaying sorted data.
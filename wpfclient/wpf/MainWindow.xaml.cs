using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ListApiCli.Client;
using ListApiCli.Api;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using classlib;

namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Configuration config;
        ItemsApi api;
        HubConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            config = new Configuration(){BasePath = "http://localhost:5171"};
            api = new ItemsApi(config);
            connection = new HubConnectionBuilder().WithUrl("http://localhost:5171/Connection").Build();
            connection.On("Refresh", () => RefreshUI());
            connection.StartAsync();
            RefreshUI();
        }

        public void Add_Click(object sender, RoutedEventArgs args)
        {
            if(tbDueDate.SelectedDate < DateTime.Now)
            {
                MessageError("Invalid Due Time!");
                return;
            }

            foreach(var i in api.ItemsGet())
            {
                if(i.ToDoItemsId == tbTaskName.Text)
                {
                    MessageError("Task already exists!");
                    return;
                }
            }

            if(tbTaskName.Text == string.Empty)
            {
                MessageError("No task name to add!");
                return;
            }

            else
            {
                api.ItemsAddItemsPost(new ListApiCli.Model.ToDoItems(tbTaskName.Text, tbDetails.Text, tbDueDate.SelectedDate.Value));
                connection.SendAsync("Connect");
            }    
        }

        public void Delete_Click(object sender, RoutedEventArgs args)
        {
            if(tbTaskName.Text == string.Empty)
            {
                MessageError("No task name to delete!");
                return;
            }

            try
            {
                api.ItemsDeleteitemIdDelete(tbTaskName.Text);
                connection.SendAsync("Connect");
            }
            catch
            {
                MessageError("Task not found!");
            }
        }

        public void RefreshUI()
        {
            tbToDoTasks.ItemsSource = api.ItemsGet();
            tbTaskName.Text = string.Empty;
            tbDetails.Text = string.Empty;
        }

        public void MessageError(string message) => 
        MessageBox.Show($"{message}","Error",MessageBoxButton.OK,MessageBoxImage.Error);
    }
}
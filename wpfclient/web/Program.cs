var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServerSideBlazor(); 
builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen(); 
builder.Services.AddScoped<ItemsService>(); 
builder.Services.AddSqlite<ItemsContext>("Data Source=ToDoItems.db"); 
var app = builder.Build(); 

app.MapHub<Connection>("/Connection");

app.UseSwagger();
app.UseSwaggerUI(); 
app.MapControllers(); 
app.Run();
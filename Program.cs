
using Microsoft.EntityFrameworkCore;
using WebApiProjectMUI_React.Models;
using WebApiProjectMUI_React.Repo;

var builder = WebApplication.CreateBuilder(args);
var allowedOrigines = "myOri";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>(); 
builder.Services.AddScoped<IOrderDetailsrepo, OrderDetailsrepo>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();
builder.Services.AddDbContext<StoreEntity>(op =>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
});
builder.Services.AddCors(op =>
{
    op.AddPolicy(allowedOrigines, po =>
    {
        po.AllowAnyMethod();
        po.AllowAnyHeader();
        po.AllowAnyOrigin();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseCors(allowedOrigines);
app.MapControllers();

app.Run();

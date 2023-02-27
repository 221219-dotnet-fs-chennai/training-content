using DataFluentApi.Entities;
using BusinessLogic;
//using Data_CodeFirst;
using Microsoft.EntityFrameworkCore;
using Models;
using DataFluentApi;

// HOST - Server for the Asp.Net Api
var builder = WebApplication.CreateBuilder(args);

//Service to add cache
builder.Services.AddMemoryCache();
//SERVICES - injected by Dependency Injection
// Add services to the container.
builder.Services.AddControllers().AddXmlSerializerFormatters();

// creating a policy which will allow any client from any domain to access this api using any header and any method
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        }
        )
    );

/*var policy1 = "some policy";
var policy2 = "some policy";

builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy1",
        policy =>
        {
            policy.WithOrigins("https://localhost.com",
                                "https://127.0.0.0");
        });

    options.AddPolicy("policy2",
        policy =>
        {
            policy.WithOrigins("https://azurewebsites.net")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});*/
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Getting the connection string from settings file like appSettings.Json, Secrest.json, launchSettings.json
var config = builder.Configuration.GetConnectionString("RestaurantDb");

// Db Contect class we create using scafolding is a dependancy to use its object reference in the EFSql Repo class
// Options.UseSqlServer() will create DbContextOptions class that hold our connection string
builder.Services.AddDbContext<RestaurantDbContext>(options=>options.UseSqlServer(config));

//We are creating the instance of EFRepo by Dependency Inverison
//builder.Services.AddScoped<IRepo<DataFluentApi.Entities.Restaurant>, EFRepo>();
builder.Services.AddScoped<IRepo<DataFluentApi.Entities.Restaurant>, DataFluentApi.EFRepo>();
builder.Services.AddScoped<IReviewRepo, ReviewRepo>();

//We are creating the instance of Logic by Dependency Inverison
builder.Services.AddScoped<IRestaurantLogic,RestaurantLogic>();

builder.Services.AddScoped<IReviewLogic, ReviewLogic>();


var app = builder.Build();
//MIDDLEWARES - a special piece of program which once added become a part of request response pipeline
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors(policy1);
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

using FactoryDesignPattern.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<StreamFactory>();
builder.Services.AddScoped<NetflixStreamService>().AddScoped
    <IStreamService,NetflixStreamService> (s => s.GetService<NetflixStreamService>());
builder.Services.AddScoped<AmazonStreamServices>().AddScoped
    <IStreamService,AmazonStreamServices>(s => s.GetService<AmazonStreamServices>());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

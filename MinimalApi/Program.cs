using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//adding dependency for in memory database
builder.Services.AddDbContext<ProductContext>(options =>
options.UseInMemoryDatabase("ProductList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Configure the http verbs

app.MapGet("/", () => "Hello world");
app.MapGet("/products/complete", async (ProductContext pc) =>
await pc.Products.ToListAsync());
app.MapGet("/products/{id}", async (int id, ProductContext pc) =>
await pc.Products.FindAsync(id));
app.MapPost("/products", async (Product p, ProductContext pc) =>
{
    pc.Products.Add(p);
    await pc.SaveChangesAsync();

});

app.MapPut("/product/{id}", async (int id, Product p, ProductContext pc) =>
{
    var ids = await pc.Products.FindAsync(id);
    if (ids is null) return Results.NotFound();
    ids.Name = p.Name;
    ids.price = p.price;
    await pc.SaveChangesAsync();
    return Results.NoContent();
    
});

app.MapDelete("/product/{id}", async (int id ,ProductContext pc) =>
{
    if(await pc.Products.FindAsync(id) is Product p)
    {
        pc.Products.Remove(p);
        await pc.SaveChangesAsync();
        return Results.Ok(p);
    }
    return Results.NotFound();
});

app.Run();

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int price { get; set; }
}

class ProductContext : DbContext
{
    public ProductContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
}



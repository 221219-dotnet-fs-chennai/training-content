# EF Core - Code First
- Most conventions and steps for EFCore Code first and EF6 are same
### Packages
- Install the listed packages in your DL project:
- `dotnet add package Microsoft.EntityFrameworkCore.Tools or Install-Package Microsoft.EntityFrameworkCore.Tools`
- `dotnet add package Microsoft.EntityFrameworkCore.SQLServer or Install-Package Microsoft.EntityFrameworkCore.SQLServer`
## Code First Steps
1. Have the following:
   - Data Layer
   - The necessary packages installed in DL project
   - Configure connection string. For our project with many layers, it is recommended to keep connection string in the User Secrets of Asp.Net core web API project.
2. Implement a DbContext
   - Override the OnConfiguring method to point to the connection string stored in your appsettings.json. Not required if you are configuring the Connection String in API project. 
   - Override the OnModelCreating method to manually map some relationships EF Core complains about
3. Run the migration code in the DL project
    - `dotnet ef migrations add NameOfMigration -c DbContext --startup-project <relative path to project file>. Ex dotnet ef migrations add InitialCreate -c PokeDbContext --startup-project ../PokemonApi/PokemonApi.csproj`
                       or
    - `Add-Migration "Name of the Migration" (In PMC point it to Data project)`
4. Update your DB in the DL project
    - `dotnet ef database update --startup-project <relative path to project file>` or
    - `Update-Database (In PMC point it to Data project)`
5. Any changes to your models/entities go to step 3

# ASP.NET
* Another framework included in our .NET 6 that specializes in creating web application in either C# or VB
* For us, we will just use it to create a restful web api instead of including the frontend tech just yet

## [Controller](https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-7.0)
* Their main responsiblity is to handle HTTP requests and formulate an appropriate HTTP response based on what functionality it is trying to achieve
* Usually you will a controller class in the controller folder and with suffix as `<classname>Controller` and it inherits from `ControllerBase`.
    * The ControllerBase class provides many [properties and methods](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase?view=aspnetcore-7.0) that are useful for handling HTTP requests.
* This is why the first thing we do to define an action (basically a method inside of controller) is to tell it what HTTP verb it should handle
    * Ex: [HttpGet] - no surprises handles http get requests
* You also specify the actual route/endpoints the client needs to use for specific functionalities inside of your controller
    * Ex: [Route(api/[controller])] - the endpoint has to be (website name).com/api/(The controller name)
* It will call on the appropriate business logic to process what the clients wants to do
    * You essentially replaced the console project to instead just have the web api project as the starting point

## Action Methods
* The public methods of the controller are called action methods or simply actions.
* When the Web API framework receives a request, it routes the request to an action.
### [Action Return Types](https://learn.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-7.0)
* ASP.NET Core provides the following options for web API controller action return types:
    * Specific type - The most basic action returns a primitive or complex data type, for example, string or a custom object.
    * IActionResult - to return appropriate status codes but type casting might be needed.
        * if there are multiple return types and paths in this type of action, liberal use of the [ProducesResponseType] attribute is necessary.
    * ActionResult<T> -  It enables returning a type deriving from ActionResult or return a specific type. 
## Model Binding/ Binding Source
* It is a way to bind data (JSON objects) coming from HTTP request to be automatically mapped into a C# model
* Remember how HTTP transfers information via JSON files? Well ASP.NET can automatically map that JSON object into a C# object
    * So instead of manually mapping it like our DL, it does it for us
    * Just need to know the fancy name that does that operation which is model binding
* Ex: controller action([FromBody] someModel p_model)
    * Mapping whatever JSON file you got into a "someModel" object that C# understands
* Model binding can also do it from C# object into JSON object
    * When we return a C# object in an action, it automatically creates a JSON object that gets put into an HTTP response
* Some binding sources that can be used are as follows:
    * [FromBody] - Request body
    * [FromForm] - Form data in the request body
    * [FromHeader] - Request header
    * [FromQuery] - Request query string parameter
    * [FromRoute] - Route data from the current request

## Routing
* Allows ASP.NET to know where to take the user's http request
    * In our case, which controller and which action inside of the controller should the http request go to
* It uses **routing middleware** to be able to find the appropriate controller and then the appropriate action within the controller to handle the request
    * It is the middleman between the asp.net app and the client
    * It also handled http responses and routes that information back to the client

## Filters
* They are used to create your own custom logic (your own code) if a certain event has happened
    * Applies to most filters but not all
### Authorization
* Used to determine whether the user is authorized for the request
* This will run first
### Resource
* Used for logging, caching, and other resource related operations
* You can configure whether to run the resource filter first or after an action
* Ex: OnResourceExecuting filter will run your custom code first before doing any model binding operations
* For optimization purposes
* Runs after Authorization
### Action
* Will perform your custom code after or before a controller action
### Exception
* Will perform your custom code after or before an exception
### Result
* Will perform some code after or before the execution of giving a view or IActionResult

## OpenAPI (Swagger)
* Just the fancy technical term for Swagger
* Swagger is a tool pre-built in our ASP.NET project with the sole purpose of checking if our rest api is definitely working
* As you have guess, we don't really have a console app so we can visually see that our app is working so they created swagger just for the purpose
* It will show you every action inside of a controller and also test them
    * It can check what http response body it gave
    * It can check what http request the client needs to give to make it work and so on
* Really useful debugging tool for our api

## [ASP.NET Caching](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/overview?view=aspnetcore-7.0)
* Storing information in your app and just recalling that information rather than doing another operation on your database
* Useful if you expect to use that information multiple times to do a single operation
* Useful if your function does a complex sql operation to get that data that takes time and to store that information to call on instead
* Might cause problems if database gets updated and using the cache information will be outdated
- In Asp.Net Core Web Api you can cache using:
    - In memory caches aka sticky sessions
    - Distributed Caches using Sql Server - Redis Caches, NCache.

## [Content Negotiation](https://learn.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-7.0)
- Whenever client request for a format of data using Accept header, this is called content Negotiation.
- By Default Asp.Net core offers Json data unless configured.By default, ASP.NET Core supports the following media types:
    - `application/json`
    - `text/json`
    - `text/plain`
- Some browsers also have default accept header like edge and IE requests for JSON.
- Or use Formatter custom or default
    - Add XML format support
        - `builder.Services.AddControllers().AddXmlSerializerFormatters();`
## [CORS](https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-7.0)
- **C**ross **O**rigin **R**equest **S**haring - is an HTTP-header based mechanism that allows a server to indicate any origins (domain, scheme, or port) other than its own from which a browser should permit loading resources.
- Browser security prevents a web page from making requests to a different domain than the one that served the web page. 
- This restriction is called the same-origin policy. 
- These two URLs have the same origin:
    - `https://example.com/foo.html`
    - `https://example.com/bar.html`
- These URLs have different origins than the previous two URLs:
    - `https://example.net: Different domain`
    - `https://www.example.com/foo.html: Different subdomain`
    - `http://example.com/foo.html: Different scheme`
    - `https://example.com:9000/foo.html: Different port`
- There are three ways to enable CORS:
    - In middleware using a named policy or default policy.
    - Using endpoint routing - for minimal apis, what we covered and learned in this training is Controller based apis.
    - With the [EnableCors] attribute.
- Microsoft recommends: Using the [EnableCors] attribute with a named policy provides the finest control in limiting endpoints that support CORS.

# Cloud Services
## What is a cloud?
- Its just another computer which is hidden from the consumer which is accessed via internet
## Why cloud services are required these days?
- On -premise (Physical infra - land, loaction, machines, ACs, Wires, Sys Admin team etc...)
- High investment cost in terms of onpprem setup
- High maintainence cost as well
- Heavy staff responsibilities
- cloud vs on-premise pros and cons read [here](https://www.morefield.com/blog/on-premises-vs-cloud/)
## Different types of [cloud models](https://www.chapter247.com/blog/what-is-cloud-computing-types-of-cloud-computing/)
- public 
- private
- Hybrid 
- multi-cloud 

## [Different types of cloud services](https://www.ibm.com/in-en/topics/iaas-paas-saas)
- IAAS - Infrastructure As A Service
- PAAS - Platform As A Service
- SAAS - Software As A Service
- DAAS - Data As A Service
- XAAS - Anything As A Service

## Deploying Asp.Net core web api to Azure
- [Article](https://aspnetcore.readthedocs.io/en/stable/tutorials/publish-to-azure-webapp-using-vs.html)
    - Not all steps are exactly how I showed but you can get a brief glimpse of it reading this article.
- [Another one from Microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-7.0)

# References
- [Asp.Net core Fundamentals - Understand asp.net core project structure, different files](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-7.0&tabs=windows)
- [Minimal APIs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/overview?view=aspnetcore-7.0)
- [Error Handling](https://learn.microsoft.com/en-us/aspnet/core/web-api/handle-errors?view=aspnetcore-7.0)
- [Open API and Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-7.0)
- [Get some more basics of asp.net core web api unit testing](https://www.youtube.com/watch?v=YxXf9Tc-Kj4)
    - this is video series using xUnit so you can understand the concept from here and implement in NUnit if you want
- [NUnit with Moq](https://www.infolytx.com/nunit-and-moq/)
    - I couldn't cover it in interest of time, but read it thoroughly and try to implement this into your project.

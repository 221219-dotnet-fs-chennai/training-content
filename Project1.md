# Find a trainer online
Agenda is to create an application to add professional trainers data in a database and these trainers are able to upload their profiles, so that vendors and client can reach out to them to offer business as well get their team trained on required skill sets.
## Sign Up trainer
### Functionalities
- User should be able to Sign Up for the app
- User should be able to login
- User should be able to add/modify/delete personal details (Location, fullname, gender, about me), contact (phone, email, website etc...)
- User should be able to add/modify/delete skills 
- User should be able to add/modify/delete companies worked in past
- User should be able to add/modify/delete education background 

### Models/tables
- User
- skills
- companies 
- education
- any extra table you want to add
#### Note
- add as many models/tables as you would need for your design

### Additional requirements
- Make sure you have a Database diagram and sql queries in place
- Exception handling
- input validation
- Logging (to a file not to a console)
    - Your app should store meaningful logging information (Such as exceptions, user’s action, what table is being accessed to, etc.).
    - You can use any logging framework, but I recommend using Serilog or NLog.
- Data should be persisted into database (no hard coded values)
- DB Structure should be in 3NF
- Code should have xml documentation via comments

### Common requirements
- Good git practises
- Server Side validation
- logging of exceptions, ADO.Net Sql commands and other events

### Design
- Project layout given will be only a suggestion, the general idea is a separation of concerns which is a requirement
- Use EFCore for middleware to connect application to database; either code first or data first approach.
- Use an Azure SQL Db in 3 NF; include a database diagram and script to generate Db and tables
- don't use too many public fields
- define and use atleast 1 interface
- try to incorporate 1 or more design patterns

#### core / domain / business logic
* class library
* contains all business logic
* contains domain classes (user/education/skill/company)
* documentation with `<summary>` XML comments on all public types and members (optional: `<params>` and `<return>`)
* (recommended: has no dependency on UI, data access, or any input/output considerations)

#### data access
* class library
* contains Entity Framework code (you can use any approache : code first or db first)
* contains data access logic but no business logic
* use repository pattern for separation of concerns
* DB should be on the cloud
    * try to have DB/network access async
#### Test
* have a testing project using NUnit
* your app should have at least 10 meaningful unit test that checks if validation is working as 
intended in your application.
* use TDD for some of the application
* focus on unit testing business logic
* data access tests (if present) should not impact the app's actual database

#### REST API
- Create endpoints(URLs) for each request type
- Data exposed in the form of xml or json
- Proper status code and status messages
- Exception handling
- CORS enabled
- Swagger working
- (optional) Deployed on Azure App Service 
- Connection strings should not be on git

#### UI
- Consume the REST API using Fetch API/ XMLHttprequest using JavaScript
- Have a web Front end using HTML
- Beautify the web front end with CSS or Bootstrap (preferably)

#### ASP.NET Core REST service
* follow standard HTTP uniform interface, except hypermedia
* good architecture
* server-side validation
* logging
* implement hypermedia, or, implement an API Description Language, e.g. using Swashbuckle / Swagger

## Technology stack 
- C#/.Net
- Sql Server Db/Azure Sql Databases
- Serilog/NLog
- NUnit
- Entity Framework core
- Asp.Net Core
- Moq for Mocking 


# Tips
- Start as soon as you get this project even if you don’t know how to do everything. You only have two weeks to create it and you need to utilize as much as you can pour in to have a working application.
- Don’t cheat! Copying other people’s repository in Github is grounds for immediately mutual release.
- Try to prioritize which functionality makes sense in a working project. If you can't store data in the database or have not created the API the whole purpose of the project is ruined.
- If you have any unclear understanding of the requirements listed above, ask your batchmates first. If they also don’t know, then you can ask me. First thing I’ll ask for you if you asked other people first. 
- Get comfortable talking with them since they will be your future group mates on 
working one enterprise project
- Push all working code to git on the evening before the presentation day and try not add last minute changes to the project as that might break your working code.
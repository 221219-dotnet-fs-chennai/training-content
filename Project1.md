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
- Data should be persisted into database (no hard coded values)
- DB Structure should be in 3NF
- Code should have xml documentation via comments

### Common requirements
- Good git practises
- Server Side validation
- logging of exceptions, ADO.Net Sql commands and other events

### Design
- Project layout given will be only a suggestion, the general idea is a separation of concerns which is a requirement
- Use ADO.Net for middleware to connect application to database; either connected or disconnected approach
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
* contains ADO.Net code
* contains data access logic but no business logic
* use repository pattern for separation of concerns
* DB should be on the cloud
    * try to have DB/network access async

#### ASP.NET Core REST service
* follow standard HTTP uniform interface, except hypermedia
* good architecture
* server-side validation
* logging
* implement hypermedia, or, implement an API Description Language, e.g. using Swashbuckle / Swagger

## Technology stack 
- .Net
- Sql Server Db/Azure Sql Databases
- C#
- NLog
- XUnit
- ADO.Net
- Asp.Net Core
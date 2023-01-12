# [Delegates](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)
- Type safe function pointers which can encapsulate a method and call it.
- Since a delegate can encapsulate a method it must have similar definition as of a type.
- Delegates have the following properties:
    - Delegates are similar to C++ function pointers, but delegates are fully object-oriented, and unlike C++ pointers to member functions, delegates encapsulate both an object instance and a method.
    - Delegates allow methods to be passed as parameters.
    - Delegates can be used to define callback methods.
    - Delegates can be chained together; for example, multiple methods can be called on a single event
    - Delegate can be single cast or multicast
        - single cast means a delegate points to single method
        - Multicast means, delegate pointing to more than 1 method. The order of execution of methods would be as these methods were binded/subcribed/added to delegates. 
        - Delegates maintains an invocation list in case of multicast delegates.
        Delegates can be used to  create Anonymous methods. Short hand of anonynous methods is known as Lambda expression
    - Lambda expressions are a more concise way of writing inline code blocks. Lambda expressions (in certain contexts) are compiled to delegate types.
- Predefined Delegates inn C#: 
    - Action - return type void, no parameters , 
    - Func - any return type, no parameters, 
    - Predicate -  bool return type, and iput parameters
# [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)
* Language-Integrated Query
* It is a query language that is very similar to our SQL but we can use it in C# or VB
* So like any query langauge, it is incredibly useful for filtering/acquiring/aggregating data
* Very useful documentation click [here](https://www.tutorialsteacher.com/linq)
## [Query Expression](https://learn.microsoft.com/en-us/dotnet/csharp/linq/query-expression-basics)
- A query is a set of instructions that describes what data to retrieve from a given data source (or sources) and what shape and organization the returned data should have. 
- A query is distinct from the results that it produces.
- Query expressions can be used to query and to transform data from any LINQ-enabled data source. 
## Method syntax
* It is more like C# in that you use methods to perform the queries
* For simeple filtering, I would use method syntaxes
## Query syntax
* It is more like SQL in that you create a statement-like operation using keywords
* I would use joins with query syntax since it is easier to understand

# ADO.NET
* Another library (that already exists in our .NET 6 framework) that specializes in connecting to different types of databases/data sources to do CRUD operations on
    * CRUD - create/read/update/delete data on the database
* It provides helpful classes that handles the connection, execution, and reading of the data from a database
* We used System.Data.SqlClient external package to specify we are specifically connecting to a SQL Server database
    * This package will change if you change the engine of your database

## SqlConnection (Can also be named as just Connection)
* A class that is used to establish a connection to a Sql Server database
* You can think of the SqlConnection object as a representation of an existing connection to a database
* The very first step required to start messing with a database

## SqlCommand (Can also be named as just Command)
* A class that is used to execute SQL statements to a SQL Server database
* You can think of the SqlCommand object as a representation of the query statement you want to execute

## SqlDataReader (Can also be name as just DataReader)
* A class that is used to read what is exactly given to you when you execute a SQL statement
* Since C# only understands classes and objects while SQL only understands tables, this class is the middle man that will provide the conversion tools required to convert SQL datatypes to C# datatypes
* You still have to map things manually but at least you can grab the data and convert it into datatypes that C# understands

## SqlDataAdapter
* A class that we don't need to use but it is the actual class that stores information in a DataSet after grabbing information from a database
* Not only that, it can also perform some query statements to also update the database (It is like a 2 in 1 a combination between SqlDataReader and SqlCommand)
* Difference is it stores the info in a Dataset and follows the disconnect architecture type
* Essentially it is the translator that converts SQL table into C# object (which is the DataSet)
    * With added benefit of also performing some database operations as well
### DataSet
* This is the actual model that SqlDataAdapter uses to store a "table" in C#
* You can think of it as a representation of a in-memory table in SQL but in C#

# Architecture of ADO.NET
* Ha! I scared you there for a second, no we don't need to know another architecture and how they structured and make ADO.net work
* Instead, we just need to know the two types of architecture and what's their difference
## Connected Architecture
* Your application has a constant connection to a database
    * At its core that is really all this means
* As a programmer, that means utilizing SqlConnection, SqlCommand, and (optional) SqlDataReader class so we are doing connected architecture
    * Remember .Open() method? Yeah that initiates a constant connection to the database
## Disconnected Architecture
* Your application only establishes a connection if it needs something with the database
* As a programmer, you need to utilize SqlDataAdapter class instead 
    * It still needs SqlConnection class to dictate what database you are trying to do operations on
        * However, you don't need to use .Open() method
    * Feel free to look up what that code looks like but we don't need to apply it

# References
- [If you want to have an easy start to Linq reading](https://www.tutorialsteacher.com/linq)
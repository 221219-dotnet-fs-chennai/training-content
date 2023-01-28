# What we have been doing so far
* A monolithic architecture
    * Meaning the frontend (anything visual to the user and the backend (the actual logic that does the function) are tightly coupled)
        * Tightly coupled just means if you update one thing, it breaks another thing since they are highly dependent on one another
        * So in our context, if we update something in BL, DL, and Model (the backend), there is a good chance it will break something in our UI (the frontend)
## Pros
* Prototyping an application and getting something working right away
* Simple applications or working on your own 

## Cons
* Horrible for scaling the application
* Impossible to develop backend and frontend separately
## SOA - Service Oriented Architecture
- A style of software design where services are provided to the other components by application components, through a communication protocol over a network
- By this We are decoupling backend and frontend and a communication protocol (can be HTTP, HTTPS, SMTP, etc.) to communicate between the two entities via the internet
- Definition - Architectural Approach in which applications make use of services available in the network. Two components of services are
    - Service Provider
    - Service Consumer
    - ![Image of Service](https://github.com/201019-UiPath/training-code/blob/main/images/Service.png)
- Both the components interact with each other via *Messages* (text/json/xml) over a *Protocol* (TCP, MSMQ, HTTP(s), named Pipes).
## What are Services?
* They are responsible for sending and receiving data
* They provide some sort of functionality that clients might want 
    * like a service in the real world (i.e. you go to a barber place to get a haircut service)
* They are independent of platforms and programming language
    * Meaning you can create one using any programming language and once deployed, any programming language can use it
    * Ex: Creating a service with C# and having a java application use it
- **Principles of SOA**
    - Standardized Service Contract: 
        - Must have a descritpion on what the service is about
        - This makes it easier for a client to understand what the service does
        - Like a service description document. Eg: [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio) for REST Apis, and [WSDL](https://www.tutorialspoint.com/wsdl/wsdl_introduction.htm) for SOAP services.
    - Loose Coupling: 
        - each service should be designed in a way that it is self contained component and has minimal dependencies on other services.
        -  Less dependency on each other (frontend and backend)
        - So, if the service functionality changes at any point in time, it should (must) not break the client application or stop it from working
    - Abstraction: 
        - You only know what the service does and how to use it but never on how they
        - Need not to expose the Service internal logic but it should be defined by its description document and the Service contract.
    - Reusability 
        - Logic was made in a way that it can be re-used as many times as the client wants
        - Other clients can also use your service at the same time without any issues
    - Autonomy: Services are encapsulated in terms of logic and consumer don't need to know about the implementation.
    - Service Statelessness
        - Service should not withhold information from one state to the other
        -  Ex: Any data used to do a functionality should be gone after doing the functionality
    - Discoverablity : Services are discoverable via end points etc..
    - Composablity: Using services as building blocks, sophisticated and complex operations.
    - ![Image for SOA](https://github.com/201019-UiPath/training-code/blob/main/images/SOA.png)
- Advantages of SOA: 
    - Service Resuablity, Easy maintainance, Platform independance, Availabilty, reliability, Scalability
    - Frontend and backend can be developed separately/parallely without any problem

- Disadvantages of SOA: 
    - load balancing, High costs and investments involved, High Overload could also because of network latency
    - As with adding more teams, communication can become an issue
        - Since frontend and backend are being developed separately they might not have the same idea on doing a functionality (which you might experience once you start working in teams!)
- SOA can be implemented in 2 ways:
    - [SOAP Service](https://www.guru99.com/soap-simple-object-access-protocol.html)-> a web service which uses XML format when it comes to exchanging of messages over various protocols (Http(s), TCP, MSMQ, named Pipes).
        - In .Net Framework use [WCF](https://www.tutorialspoint.com/wcf/wcf_architecture.htm) (Windows Communication Foundation) or [Asp.Net web Service](https://www.javatpoint.com/web-services-in-c-sharp)(old version of SOAP in .Net, before WCF came)
            - Communication between consumer and provider happens on SOAP Packet (XML data)
            - WCF Contracts:
                - Service Contract
                    - Operation Contract
                - Data Contract
                    - Data Member
                - Fault Contract
            - Consume a [SOAP Service](https://www.c-sharpcorner.com/article/calling-web-service-using-soap-request/) 
            - To test a SOAP Service you can use [SOAP Ui](https://www.soapui.org/)

    - [RESTFul Service](https://restfulapi.net/rest-architectural-constraints/)
        - [REST Principles/Constraints](https://restfulapi.net/)
        - REST only uses Http(s).
        - Messaging can use *xml/json* and other formats are also supported.
        - REST Api's are more reachable and this is why we more clients/consumers for REST service over SOAP Service.
        - In .Net REST Api can be implemented using **Asp.Net core web API**
        - To test the Web Api we can use [Postman](https://www.postman.com/downloads/) or [Fiddler](https://www.telerik.com/fiddler)
# REST
* Stands for Representational State Transfer
* It is an **architecture style** that uses SOA as its guide
* It tells you how you should transfer information and how you should communicate with the client
## What is an API?
* Application Programming Interface
* At its essence, it allows you to communicate and transfer information
## What is a resource?
* Anything that is being transferred, stored, processed, given, etc. (mostly objects for us)
## Guiding Principles of Rest
* Uniform Interface
    * Your service would have an interface defined by four constraints:
        * Identification of resources
            * Able to identify the resource you are trying to access
            * Ex: An endpoint that ends with /Pokemon/AllPokemon will give all the pokemon resource in the database
        * Manipulation of resources through representation
            * Using appropriate action verb to access/manipulate your resource
            * Ex: GET method to get all pokemons or POST method to add a pokemon
        * Self-description message
            * Any other information needed to process the data
            * Ex: the format the data will come in (JSON, XML, etc.)
        * Hypermedia as the engine of application state (HATEOAS)
            * Not implemented as much nowadays
            * It gives other potential actions the user can take after doing one action
            * Ex: GetAllPokemon would then give the user potential actions to take such as AddPokemon
* Client-Server
    * Client app will evolve separately from the server from the server app without any dependencies on each other
    * Same concept of when we change our DL from the file system to database without breaking the other projects
    * Decoupling the services from each other (Matters the most when we do MSA (microservices design pattern))
    * Same concept of one service being change shouldn't break a different service
* Layered System
    * Constraining the interactions of your components to the ones in the next Layer
    * The service should only have access to components it is dependent on
    * Ex: The BL can only access the DL and the UI can only access BL and not DL
* Stateless
    * Server isn't responsible for storing client state
    * It will just treat every http request as new or completely different even if it came from the same client or even doing the same http request (refreshing the page)
    * The client is the only one responsible for storing its own state (like storing cookies or tokens)
* Cacheable
    * Resource from the server can be cached if applicable
    * Meaning the client can store information that was sent by the server
    * Ex: once you get a list of pokemn, refreshing the page you instantly get that list of pokemon since it was stored already
* Code on Demand (optional)
    * Allows client functionality to be extended by downloading and executing code in a form of applets.
    * Outdated at this point (think of how in the past to play a game, the game has a loading process well that loading process is your computer downloading the scripts to run the game)
### Messages in Services
|    C#                      |         xml                                   |    json                         |
|----------------------------|-----------------------------------------------|---------------------------------|
|   `class Person{ `             |  `<person>`                                     |  `"person":{ `                    |
|        `int id=1; `          |       `<id>1</id> `                             |          `"id":1,`|
|        `string name="Bob";`  |       `<name>"Bob"</name>`                      |          `"name":"Bob"`|
|    `} `                      |  `</person>`                                    |         `}`|

- **Why industries prefer REST over SOAP service**
    - Light weight messaging using **Json**.
    - Easy setup and extend for REST over SOAP service.
    - Statelessness of RESTful service is helpful in scalability.
    - Reachability of clients because of HTTP as we have more devices supporting HTTP.
- **Why  still some industries are sticked to SOAP Service**
    - Because they offers exposing API via different protocols
    - Eg: Banks only want the Services and data exposed via their private network.

# HTTP in brief
- Hyper Text Transfer Protocol (Secured)
- The protocol that both computers have to follow in order to understand/communicate with each other and work together to display a nice looking website in your browser, register an account, login, etc.
- HTTP message structure: head (start-line, headers (optional)), empty line, body (optional)
- HTTP request message structure
    - start-line: HTTP method, request URI, HTTP version
- HTTP response message structure
    - start-line (called the status line): HTTP version, status code, status text (aka reason phrase, canned description of status code)
- some headers are only for request (e.g. Accept)
- some only for response (e.g. Server)
- some for both (e.g. Cache-Control)
- some for both, to describe the body when there is one (e.g. Content-Type, Content-Length)

## HTTP Life Cycle
* An overview of what happens if you put in a url in your browser and out comes a website
1. Client (your browser) will send a request (the url you sent)
2. The server will receive that request and will do some processes
3. The server will send an appropriate response (html, css, js, json, etc.)
4. The client will receive the response and the browser will process that response
## Domain Name System (DNS)
* It is essentially a directory of names and ip address
* It translates a pretty loorking name of a website (www.google.com) into some numerical ip address ranging from (0.0.0.0 - 255.255.255.255) for locating the right server and to process the http request
* Main reason is the same reason why you save people's phone number in contact in a form of a name instead of just their phone number
    * It is easier to remember!
### HTTP Headers
   - accept (request)
   - content-type
   - user-agent (request)
   - set-cookie (response)
   - cookie (request)
   - content-length (bytes)
   - content-type (media type)

### HTTP Verbs/Methods
- Describes what action the client wants the server to perform on a given resource  
    - What is a resource? Anything the server is providing counts as a resource
    - Common Verb
        - GET: Used to retrieve data from the server, safe (generate no change to visible system state (e.g. caching allowed))
        - GET, PUT, DELETE: idempotent (result of 1 request is identical to result of N requests - subsequent requests don't change anything. turning switch on, vs. toggling switch.)
        - POST Used to submit data to the server, is not safe or idempotent. POST N times, create N copies.
            - this is why the browser says "are you sure you want to send this request again" when you refresh or click "back" through forms and such

- other methods:
   - PATCH (allowed to be non-idempotent. partial replacement of resource)
   - HEAD (like GET, except, only send me the headers, not the body. client maybe wants to just see if resource exists, not necessarily get a representation of it. safe.)
   - OPTIONS (tell me what things I can do with this resource (e.g. which HTTP methods are allowed) - responds with "Allow" header. safe.)
   - TRACE (repeat back to me what you receive from me. for diagnostic purposes. idempotent)

- most important: get should be safe, post (and others) we can do changes.

### HTTP status codes
- 100 informational - this request-response is still ongoing
       - 100 continue: you sent the headers, ok, now send the body
- 200 successful
    - 200 ok: successful request
            for get
            in asp.net core: Ok(...)
      - 201 created: successful creation of resource. should generally return a copy of the resource created
            for post
            should also include Location header saying where it's at.
            CreatedAtRoute(...), CreatedAtAction(...)
       - 202 accepted: request received but hasn't been acted on yet.
       - 204 no content: success but we are not returning anything
            for put and delete
            NoContent()
    - 300 redirection
        301 moved permanently: resource isn't here
            should also include Location header saying where it's at.
*       302 found: resource isn't here, browser usually automatically requests new URL with GET
            temporary redirect
            should also include Location header saying where it's at.
            RedirectToAction(...), RedirectToRoute(...)
        304 not modified: you had e.g. "if-modified-since" header, and the resource hasn't been modified
    400 client error
*       400 bad request. generic code for any error that's the client's fault. (e.g. syntax of request is invalid)
            BadRequest()
*       401 unauthorized: really means unauthenticated. you did not identify yourself.
            Unauthorized()
        402 payment required: meme status code
*       403 forbidden: the true unauthorized. you don't have the rights to do this
            Forbidden()
*       404 not found
            NotFound()
        405 method not allowed: on this resource
            implemented by default in asp.net core
*       406 not acceptable: you used "accept" header and we can't give you that content type
            the server doesn't have to use 406, it can decide to use a fallback media type
        409 conflict: you can't do that because it's inconsistent with something else
*       415 unsupported media type
        418 i'm a teapot: you asked me to brew coffee
    500 server error
*       500 internalservererror
            StatusCode(500)
*       502 bad gateway - this server didn't make a mistake, but we had to call some OTHER server, and IT sent us something invalid
        505 HTTP version not supported
## HTTP Request
* It is essentially what the client sents 
* It will tell what HTTP verb the request will be all about (either GET, POST, PUT, etc.)
* It will tell what kind of actual data the client is trying to sent (in a JSON format)
* It has a bunch of other useful metadata things you don't need to know like ip addresses, urls, etc. things that might be useful for debugging purposes

## HTTP Response
* It is essentailly what the server sends back to the client
* It will give a **status code** if it was successful or not
* More metadata stuff for debugging purposes
* What kind of data the server is trying to sent to the client (in a JSON format)

# ASP.NET
* Another framework included in our .NET 6 that specializes in creating web application in either C# or VB
* For us, we will just use it to create a restful web api instead of including the frontend tech just yet

## Controller
* Their main responsiblity is to handle HTTP requests and formulate an appropriate HTTP response based on what functionality it is trying to achieve
* This is why the first thing we do to define an action (basically a method inside of controller) is to tell it what HTTP verb it should handle
    * Ex: [HttpGet] - no surprises handles http get requests
* You also specify the actual route/endpoints the client needs to use for specific functionalities inside of your controller
    * Ex: [Route(api/[controller])] - the endpoint has to be (website name).com/api/(The controller name)
* It will call on the appropriate business logic to process what the clients wants to do
    * You essentially replaced the console project to instead just have the web api project as the starting point

## Model Binding
* It is a way to bind data (JSON objects) coming from HTTP request to be automatically mapped into a C# model
* Remember how HTTP transfers information via JSON files? Well ASP.NET can automatically map that JSON object into a C# object
    * So instead of manually mapping it like our DL, it does it for us
    * Just need to know the fancy name that does that operation which is model binding
* Ex: controller action([FromBody] someModel p_model)
    * Mapping whatever JSON file you got into a "someModel" object that C# understands
* Model binding can also do it from C# object into JSON object
    * When we return a C# object in an action, it automatically creates a JSON object that gets put into an HTTP response

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

## ASP.NET Caching
* Storing information in your app and just recalling that information rather than doing another operation on your database
* Useful if you expect to use that information multiple times to do a single operation
* Useful if your function does a complex sql operation to get that data that takes time and to store that information to call on instead
* Might cause problems if database gets updated and using the cache information will be outdated



## Reference
- [Http](https://developer.mozilla.org/en-US/docs/Web/HTTP)
- [Overview of Http](https://developer.mozilla.org/en-US/docs/Web/HTTP/Overview)
- [Evolution of Http](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Evolution_of_HTTP)
- [Resources on Web](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Identifying_resources_on_the_Web)
- [MIME Types](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types)
- [Content Negotiation](https://developer.mozilla.org/en-US/docs/Web/HTTP/Content_negotiation)
- [Http Methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods)
- [Http Status codes](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status)
- soa:
   - https://www.ibm.com/cloud/learn/soa
   - https://martinfowler.com/bliki/ServiceOrientedAmbiguity.html
   - https://www.guru99.com/soa-principles.html
- REST conceptual:
   - https://martinfowler.com/articles/richardsonMaturityModel.html
   - https://restfulapi.net/
- REST implementation in ASP.NET Core:
   - https://docs.microsoft.com/en-us/aspnet/core/web-api
   - https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design
   - https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-implementation

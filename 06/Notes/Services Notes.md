## SOA - Service Oriented Architecture
- Architectural Approach in which applications make use of services available in the network. Two components of services are
    - Service Provider
    - Service Consumer
    - ![Image of Service](https://github.com/201019-UiPath/training-code/blob/main/images/Service.png)
- Both the components interact with each other via *Messages* (text/json/xml) over a *Protocol* (TCP, MSMQ, HTTP(s), named Pipes).
- **Principles of SOA**
    - Standardized Service Contract: A service should have a service description document. Eg: [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio) for REST Apis, and [WSDL](https://www.tutorialspoint.com/wsdl/wsdl_introduction.htm) for SOAP services.
    - Loose Coupling: each service should be designed in a way that it is self contained component and has minimal dependencies on other services.
    - Abstraction: Need not to expose the Service internal logic but it should be defined by its description document and the Service contract.
    - Reusability 
    - Autonomy: Services are encapsulated in terms of logic and consumer don't need to know about the implementation.
    - Discoverablity
    - Composablity: Using services as building blocks, sophisticated and complex operations.
    - ![Image for SOA](https://github.com/201019-UiPath/training-code/blob/main/images/SOA.png)
- Advantages of SOA: Service Resuablity, Easy maintainance, Platform independance, Availibilty, reliability, Scalability
- Disadvantages of SOA: load balancing, High costs and investments involved, High Overload could also because of network latency
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
    - Reachability of clients because of HTTP as we have more devices supporting HTTP    

** Difference between Soap and Rest **
 - https://medium.com/@olaoyeoluwapelumi/soap-apis-vs-rest-apis-82932da552b9


## Reference
- [Http](https://developer.mozilla.org/en-US/docs/Web/HTTP)
- [Overview of Http](https://developer.mozilla.org/en-US/docs/Web/HTTP/Overview)
- [Evolution of Http](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Evolution_of_HTTP)
- [Resources on Web](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Identifying_resources_on_the_Web)
- [MIME Types](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types)
- [Content Negotiation](https://developer.mozilla.org/en-US/docs/Web/HTTP/Content_negotiation)
- [Http Methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods)
- [Http Status codes](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status)

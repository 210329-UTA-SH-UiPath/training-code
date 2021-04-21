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
    - [SOAP Service]()-> a web service which uses XML format when it comes to exchanging of messages over various protocols (Http(s), TCP, MSMQ, named Pipes).
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
    - Reachability of clients because of HTTP as we have more devices supporting HTTP.
## EFCore Code-First
- Install packages from Package Manager Console(command line based) or Nuget Package Manger (GUI based)
    - `Microsoft.EntityFrameworkCore.Design`
    - `Microsoft.EntityFrameworkCore.Tools`
    - `Microsoft.EntityFrameworkCore.SqlServer`
- Create Entities and the DbContext class. Entities and DbContext class can be create in 2 ways:
    1. Data Annotations - used for validations as well adding constraints to Db schema.
    2. Fluent API - used for validations as well adding constraints to Db schema.
### Relationships
- 1-1 - one to one
- 1-* - one to many
- *-* - many to many (EFCore 5.x+ create a bridge/junction table in DB)
## ASP.Net Core Web API 
- [Content Negiotiation](https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-3.1): Whenever client request for a format of data using *Accept* header, this is called content Negotiation.
- By Default Asp.Net core offers Json data unless configured.
- Some browsers also have default accept header like edge and IE requests for JSON.
- Or use Formatter custom or default


## How can you consume an Asp.Net Web API
1. Client-side -> using JS or any frameworks based on client-scripting language
2. Server-side -> HttpClient

## references 
- [Practise](https://docs.microsoft.com/en-us/learn/modules/build-web-api-net-core/)

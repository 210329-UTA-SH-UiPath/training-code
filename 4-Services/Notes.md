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
### Return Types of Actions
- Specific Type (SuperHero, SuperPower)
  - Use IEnumerable for Synchronous operations but not recommended with large records
  - Use IAsyncEnumerable to return records in async way
- IActionResult (supports more or less all results as it is the super parent)
  - Use whenever you want to return multiple **ActionResult**
  - Different ActionResult like **OkObjectResult(200)**, **NotFoundResult(404)**, **BadRequestResult(400)**, **ContentResult**, **JsonResult**
- ActionResult<T>

## Validations:
- To check the user's input at client side as well as Server side we use validations
- Data Annotations: Can be used to:
    - Perform client side validations using annotations like StringLength/Range,RegularExpression, Required
    - Display Views : Datatype, Display Name
    - Mention schema logic: Key, Foreign Key, DataType
- You can also write the logic for the Validation in the models 
    ```
        private string _alias;
        
        public string Alias
        {

            get => _alias;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("SuperHero Alias must not be empty", nameof(value));
                }
                _alias = value;
            }
        }
    ```

## Lifetime of the context
- there are built in IoC containers that manages the lifetime of a registered service (Context)
    - **Singleton** - service will be available through out the lifetime of the application
    - **Transient** - it will create a new instance of the the specified service type every time you ask for it.
    - **Scoped** - it will create the instance of the specified service once per request and it will be shared in a single request.

### Different Attributes for Controllers and Actions
In Microsoft.AspNetCore.Mvc provides following attributes:
- [Route]
- [Bind]
- [HttpGet]
- [Produces] - specifies the data that an action returns
- [Consumes] - specifies the data that an action recieves
- [ApiController]
  
### Binding Source
- [FromBody]
- [FromForm]
- [FromQuery] - start a `query string` with `?` and if you have more than 1 parameter then use trailing `&`
- [FromRoute]
- [FromHeader]
- [FromServices]

### Model Binding
- It is a mechanism which allows the binding of values of parameters action methods from different locations of that data:
    - RouteData
    - FormCollection
    - QueryString
    - File

### [Routing](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0)
- mechanism to implement powerful and meaningful URLs and its mapping
- It is Performed by Routing Engine
- A routing engine has a route table which maintains the repository of the the patterns, controller, actions and its parameters.
- Link generation independant of the file structure of webserver.
- Routing can be done in 2 ways:
    1. Conventional based Routing - globally defining of the routes
    2. Attribute based Routing - Routes for Controller and action methods
- [Atrribute Routing for REST APIs](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0#attribute-routing-for-rest-apis)
- [Attribute routing with Http verb attributes](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0#attribute-routing-with-http-verb-attributes)
- [Resolving Ambigious links](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0#resolving-ambiguous-actions)


### [Content Negiotiation](https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-3.1): 
- **Content Negotiation** - Content negotiation occurs when the client specifies an Accept header. The default format used by ASP.NET Core is JSON.
- To create custom formatter - create a class (MyFormatter) which inhertis from TextOutputFormatter
- By Default Asp.Net core offers Json data unless configured.
- Some browsers also have default accept header like edge and IE requests for JSON.
- Or use Formatter custom or default
- ```
  services.AddControllers(options=>
          options.InputFormatters.Insert(0, new MyFormatter());
          options.OutputFormatters.Insert(0, new MyFormatter());
    );
  ```
## Security in Asp.Net Core Web API
### CORS
- Cross Origin Requests
- Mordern browsers only allow same origin requests for security purpose
- Same Origin 
    - http://www.abc.com/index.html
    - http://www.abc.com/aboutus.html
- Different Origins
  - https://www.abc.net
  - https://www.abc.com
  - tcp://abc.com
  - http:www.abc.com
  - https://www.abc.com:8085

#### Enable CORS
- There are three ways to enable CORS:
1. In middleware using a named policy or default policy.
2. Using endpoint routing.
3. With the [EnableCors] attribute.

### Authentication using JWT (this is not a part of curriculum, just for extra knowledge if anyone is curious)
- Authentication: user's identity is recognized
- Authorization: user is granted with access rights
- JWT: JSON Web Tokens
  - JWT has 3 parts separated by .
  - header.payload.signature

### [Secrets Management](https://dev.to/dotnet/how-to-store-app-secrets-for-your-asp-net-core-project-2j5b)
- to store sensitive/confidential data/environment/individual/application/centralized
- Hardcoded (not recommended at all), *Setting.json, Secrets file, Azure Key Vault (most recommended)
- Generate `Secrets.json` by **right clicking on the Api project** and click **Manage Secrets**
- the `Secrets.json` file is stored in `C:\Users\<username>\AppData\Roaming\Microsoft\UserSecrets\<GUID>`
- This  `Secrets.json` file is not pushed on source control and it is per individual basis

### [Swagger or Open API](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
- Documentation is an important practise in SOA.

## How can you consume an Asp.Net Core Web API
1. Client-side -> using JS or any frameworks based on client-scripting language. For JS -> XMLHttpRequest or fetch api
2. Server-side -> for C# -> HttpClient

## references 
- [Practise](https://docs.microsoft.com/en-us/learn/modules/build-web-api-net-core/)

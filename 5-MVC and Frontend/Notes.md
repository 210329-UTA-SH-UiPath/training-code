### [Asp.Net](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-5.0)
- Active Server Pages
- **History** 
    - .Net Framework (2002) 
    - Asp.Net WebForms (Rapid Application Development) 
        - Asp.Net forms had capability to drag and drop the controls 
        - Fat and unmanagable 
        - Tight coupling : front end code was tighlty coupled with server side
        - less testable
        - Very less Separation of BL, UI, DL
    - In 2010 and later versions .Net Framework introduced Asp.Net MVC is based on MVC design pattern

### MVC Design Pattern
- **Models**: That contains structure of the data, its validation and business logic for that data.
- **Views**: UI logic 
- **Controllers**: the component which handles users request.
- ![MVC lifecycle diagram](https://github.com/201019-UiPath/training-code/blob/main/images/MVC%20lifecycle%20-%20brief.png)

### .Net Core -> Asp.Net Core 
- Asp.Net Core MVC app: Web application with UI
    - MVC
    - Razor Pages
    - Blazor
- Asp.Net Core Web API: Service application for creating RESTful services
- Asp.Net core is compatible with all environments and platforms (macOS/Windows/Linux)
- **Hosts**: The physical environment supporting deployment of the Asp.Net Core app
    - IIS - Microsoft's server, Windows only
    - Kestrel - platform independant. Can be used in macOS, Linux, Windows
    - HTTP.sys
    - Nginx
    - Apache
    - Docker

### Controllers
- Handles all user interaction
- A controller class is inheriting Controller class from Microsoft.AspNetCore.Mvc namespace
- All public methods in controller class are called **Actions**
- Actions can be of basically 2 types:
    - GET - it will return you something like a view. By default if the action type isn't specified it is implicilty considered as Get type.
    - POST - They are used to submit some user input

### Actions
- They are the methods that handles the forwarded request from the controller
- They typically have a return type as *IActionResult*
- from IActionResult you can return various outputs:
    - ViewResult - View()
    - JsonResult - Json()
    - FileResult - File()
    - ContentResult - Content()
    - ActionResult - View()

### Passing data to views and [controllers](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/actions?view=aspnetcore-5.0)
- Controllers to view data can be passed in 2 ways:
    - Weakly-typed/loosely-typed:
        - ViewData: this is dictionery object which is a key value pair. It needs type casting for complex data except if its string.
        - ViewBag: this is dynamic type object which don't need casting for complex data. Also ViewBag is wrapper over viewdata
        - TempData:
            - ViewBag and ViewData can only pass values from controller actions to View but cannot pass it from one controller to another.
            - TempData can pass the value from one controller to another allowing 1 time read.
            - TempData.Keep() -> this method will preserve the value of TempData for next read.
    - Strongly-typed
        - by using Models in the views which are called view-models
        - 1 view is tied to only 1 model
    - Dynamic way

### [Views](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-5.0)
- Consists of UI logic
- supports C# and html
- C# code is accessed @ sign which is also called *Razor syntax*
- @chsarp one line code 
- ```
        @{
        multiple lines of C# code
        }
    ```
- Types of [Views](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-5.0):
    - Holding data:
        - Weakly-Typed
        - Strongly-Typed
        - Dynamic-Typed
    - Layout View - implement the principle **DRY(Do not Repeat Yourself)**
        - RenderBody()- placeholder for all the views
        - RenderSection() - a placeholder for view specific data
    - [Partial Views](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/partial?view=aspnetcore-5.0) 
        - Consist of a UI logic for small piece of view. This is used to render a small view within the primary view.
        - We use partial views:
            - Break large view in to small views for ease.
            - For reusing a view logic.
    - Excecution of view calls: _ViewStart -> _Layout -> Controller Specific View -> Partial View

### Model Binding
- It is a mechanism which allows the binding of values of parameters action methods from different locations of that data:
    - RouteData
    - FormCollection
    - QueryString
    - HTTP Headers

### [Routing](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0)
- mechanism to implement powerful and meaningful and searchable (SEO) URLs and its mapping
- It is Performed by Routing Engine
- A routing engine has a route table which maintains the repository of the the patterns, controller, actions and its parameters.
- Link generation independant of the file structure of webserver.
- Routing can be done in 2 ways:
    1. Conventional based Routing - globally defining of the routes
    2. Attribute based Routing - Routes for Controller and action methods

## Lifetime of the context
- there are built in IoC containers that manages the lifetime of a registered service (Context)
    - Singleton - service will be available through out the lifetime of the application
    - Transient - it will create a new instance of the the specified service type every time you ask for it.
    - Scoped - it will create the instance of the specified service once per request and it will be shared in a single request.


## Helpers in MVC Views
- There are 2 types of helpers which can be used to generate the html at runtime by razor engine
    - HTML Helpers: C# methods which create the HTML at run time
    - Tag Helpers: which are more like mark ups and HTML friendly syntaxes

## Validations:
- To check the user's input at client side as well as Server side we use validations.
- The validation attributes are checked on the client side before values are posted to the server, as well as on the server before the controller action is called.
- Data Annotations: Can be used to:
    - perform client side validations using annotations like StringLength/Range,RegularExpression, Required
    - Display Views : Datatype, Display Name
    - Mention schema logic: Key, Foreign Key, DataType

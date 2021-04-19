# PizzaBox

The goal of the project is to build a Pizza Ordering System.

## Architecture [REQUIRED]

+ [solution] PizzaBox.sln
  + [project - Api] PizzaBox.Api.csproj
  + [project - classlib] PizzaBox.Domain.csproj
    + [folder] Abstracts
    + [folder] Interfaces
    + [folder] Models
  + [project - classlib ] PizzaBox.Storing.csproj
    + [folder] Repositories
  + [project - xunit] PizzaBox.Testing.csproj
    + [folder] Tests
+ [solution] PizzaBoxFrontEnd.csproj
    + *Asp.Net Core MVC* project or *HTML/CSS/JS* project, either of them should make call to the Api project.
    + If its Asp.Net Core MVC front end it can use **HttpClient** or JS (**Ajax or Fetch Api**) to make calls to Api and if its HTML/CSS/JS project it should use JS (Ajax or Fetch Api) to make call the the Api project.
    + You can also use both the technologies to make you front end project.

## Requirements

The project should support objects of Customer, Store, Order, Pizza.

### store

+ [required] there should exist at least 2 stores for a customer to choose from
+ [required] each store should be able to view/list any and all of their completed/placed orders
+ [required] each store should be able to view/list any and all of their sales (amount of revenue weekly or monthly)

### order

+ [required] each order must be able to view/list/edit its collection of pizzas
+ [required] each order must be able to compute its pricing
+ [required] each order must be limited to a total pricing of no more than $250
+ [required] each order must be limited to a collection of pizzas of no more than 50

### pizza

+ [required] each pizza must be able to have a crust
+ [required] each pizza must be able to have a size
+ [required] each pizza must be able to have toppings
+ [required] each pizza must be able to compute its pricing
+ [required] each pizza must have no less than 2 default toppings
+ [required] each pizza must limit its toppings to no more 5

### customer

+ [required] must be able to view/list its order history
+ [required] must be able to only order from 1 location in a 24-hour period with no reset
+ [required] must be able to only order once every 2-hour period

## technologies

+ .NET Core - C#
+ .NET Core - EF (code-first or Database First) + SQL (I encourage for Code-First)
+ .NET Core - xUnit
+ Asp.Net Core MVC
+ Asp.Net Core Web Api
+ HTML/CSS/JS

## timelines

+ code-freeze on _April 26_ at 11:59p Eastern
+ presentation on _April 27_ starting at 9.30a Eastern
+ expect _mvp status_ for the project:
  - able to order at least 1 pizza (custom or preset)
  - able to save order in DB-system
  - The DB should have achieved normalization upto 3NF.
  - able to retrieve order and display to UI
  - able to have unit test implementation (try at least 10)
  - __implement of as many requirements as you can for Customer, Store, Pizza, Order__

## As a Customer

+ should be able to launch the application
+ should be able to view a list of available stores
+ should be able to select a store
+ should be able to place an order
+ order should be either a custom pizza or a preset pizzas
+ if a custom pizza is selected
  + should be able to select a crust, a size and a set of toppings
+ if a preset pizza is selected
  + should be able to select a pizza, a size 
+ should be able to view order
+ should be able to add or remove pizzas
+ should be able to checkout the order
+ should be able to view the order history
+ should be able to make new order

## As a Store

+ should be able to access the application
+ should be able to view an options menu for order history and sales report
+ should be able to select an option
+ if option for store orders
  + should be able to view order history
+ if option for store orders by customer (filtering)
  + should be able to view order history for a customer
+ if option for sales report
  + should be able to view revenue by week (inlcuding pizza type and count per type)
  + should be able to view revenue by month (including pizza type and count per type)

__the goal is to try to complete [required] requirements atleast in the time alloted and then you should try to create as many additional requirement or if you think anything better could be added feel free to do so (absolutely no burnout). 😊__

# Selling-Microservice

"Selling-Microservice" is a comprehensive microservices architecture-based e-commerce application. It is designed to demonstrate a full-stack, cloud-native approach integrating multiple services such as user identity, catalog management, basket processing, and order fulfillment. The architecture leverages various technologies including ASP.NET Core, Docker, RabbitMQ for event bus implementation, and Redis for caching and session storage.

## Microservices

1. **API Gateway** - Central entry point for the frontend, routing requests to various backend services using Ocelot API Gateway.
2. **Identity Service** - Manages user authentication and authorization, issuing JWT tokens for secure service communication.
3. **Catalog Service** - Provides product listings, including CRUD operations for catalog items stored in a SQL database.
4. **Basket Service** - Handles user shopping cart data stored in Redis, allowing for quick retrieval and updates.
5. **Order Service** - Manages order processing, integrates with the Basket service to convert baskets into orders and uses an internal event bus to handle domain events.
6. **Payment Service** - Processes payments and handles financial transactions.

   ![Microservice Architecture](https://github.com/burakgunce/Selling-Microservice/assets/87397100/83edaf45-6be1-4505-8e9d-06a6742868ca)

## Approaches

- **Microservice Architecture**  
  This approach divides the application into smaller, loosely coupled services, allowing for independent development, deployment, and scaling.

- **Onion Architecture**  
  It promotes a separation of concerns by dividing the application into distinct layers such as core, application, infrastructure, and UI.

- **CQRS Pattern**  
  Command Query Responsibility Segregation separates read and write operations, enabling optimized performance and scalability.

- **Mediator Pattern**  
  It facilitates communication between components by introducing a mediator object to handle interactions.

- **Domain Driven Design Pattern**  
  It emphasizes modeling the domain directly in code, focusing on the business logic and domain entities.

- **Generic Repository Pattern**  
  It provides a generic way to access data, reducing duplication and promoting consistency across repositories.

- **JWT (JSON Web Token) Authentication**  
  JWTs are used for secure communication, providing a way to encode claims between parties.

## Technologies

- **Entity Framework Core**  
  A powerful ORM for database interactions, simplifying data access and manipulation.

- **Automapper**  
  A tool for object-to-object mapping, reducing boilerplate code when transferring data between layers.

- **Mediatr**  
  A simple mediator implementation, facilitating decoupled communication between components.

- **RabbitMQ**  
  A message broker for event-driven architectures, ensuring reliable and asynchronous communication.

- **Redis**  
  An in-memory data store used for caching and session storage, enhancing performance.

- **Ocelot**  
  A lightweight API Gateway used for routing and request aggregation.

- **Consul**  
  A service discovery and configuration tool, promoting service registration and discovery.

- **Serilog**  
  A logging library providing structured logging capabilities for better diagnostics.

- **JWT (JSON Web Token) Authentication**  
  A standard for secure authentication, issuing and validating tokens for service communication.


| Technology / Library                                        | Version  |
|-------------------------------------------------------------|----------|
| .NET                                                        |  6.0      |
| MediatR                                                     | 12.2.0   |
| Ocelot                                                      | 23.2.2   |
| Ocelot.Provider.Consul                                      | 23.2.2   |
| Swashbuckle.AspNetCore                                      | 6.5.0    |
| StackExchange.Redis                                         | 2.7.33   |
| Microsoft.IdentityModel.Tokens                              | 7.5.1    |
| RabbitMQ.Client                                             | 6.8.1    |
| Consul                                                      | 1.7.14.3 |
| Microsoft.AspNetCore.Authentication.JwtBearer               | 6.0.29   |
| Serilog                                                     | 3.1.1    |
| Serilog.Sinks.Graylog                                       | 2.3.0    |
| Serilog.AspNetCore                                          | 5.0.0    |
| Serilog.Sinks.Console                                       | 4.0.1    |
| Polly                                                       | 8.3.1    |
| MediatR.Extensions.Microsoft.DependencyInjection          | 11.1.0   |
| Microsoft.AspNetCore.Http.Abstractions                    | 2.2.0    |
| AutoMapper                                                  | 13.0.1   |
| Microsoft.Extensions.DependencyInjection                  | 6.0.0    |
| Microsoft.VisualStudio.Azure.Containers.Tools.Targets     | 1.14.0   |
| Microsoft.Extensions.Logging                                | 6.0.0    |
| Microsoft.Extensions.Logging.Console                        | 6.0.0    |
| AspNetCore.HealthChecks.UI.Client                           | 6.0.3    |
| System.IdentityModel.Tokens.Jwt                             | 7.5.1    |
| Microsoft.EntityFrameworkCore.SqlServer                     | 6.0.29   |
| Microsoft.EntityFrameworkCore.Relational                    | 6.0.29   |
| Microsoft.EntityFrameworkCore.Tools                         | 6.0.29   |
| xunit.runner.visualstudio                                   | 2.4.5    |
| MSTest.TestFramework                                        | 3.3.1    |
| Microsoft.NET.Test.Sdk                                      | 17.5.0   |
| xunit                                                       | 2.4.2    |
| coverlet.collector                                          | 3.2.0    |
| Microsoft.EntityFrameworkCore                                 | 6.0.3    |
| Microsoft.Extensions.DependencyInjection.Abstractions   | 6.0.0    |
| Swashbuckle.AspNetCore                                      | 6.3.0    |
| Polly                                                       | 7.2.3    |
| System.Data.SqlClient                                       | 4.8.3    |
| Microsoft.Azure.ServiceBus                                  | 5.2.0    |
| Microsoft.Extensions.Logging.Abstractions                 | 6.0.4    |
| Newtonsoft.Json                                             | 13.0.3   |
| Microsoft.Extensions.Http                                   | 6.0.0    |
| Microsoft.AspNetCore.Components.WebAssembly                 | 6.0.20   |
| Blazored.LocalStorage                                       | 4.5.0    |
| Microsoft.AspNetCore.Components.WebAssembly.DevServer       | 6.0.20   |
| Microsoft.AspNetCore.Components.Authorization               | 6.0.29   |
| Microsoft.AspNetCore.Http.Extensions                        | 2.2.0    |



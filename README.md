# NorthwindApi

A layered Web API project developed using C# and .NET, based on the Northwind sample database. This project was built as part of my learning journey in backend development while following the **Software Developer Training Camp** by Engin Demiroğ.

## Technologies

- C#
- .NET / ASP.NET Core Web API
- Entity Framework Core
- JWT (JSON Web Token) Authentication
- FluentValidation
- Dependency Injection
- Autofac
- Castle.DynamicProxy
- Aspect-Oriented Programming (AOP)

## Project Architecture

The solution is organized into separate layers to improve maintainability and separation of concerns.

- **Core:** Shared infrastructure, cross-cutting concerns, and aspect implementations.
- **Entities:** Entity classes representing the application data model.
- **DataAccess:** Data access operations and database interaction.
- **Business:** Business logic, validation, and service operations.
- **WebAPI:** API endpoints and application entry point.

## Cross-Cutting Concerns

The project explores cross-cutting concerns using aspect-oriented programming, including:

- Validation
- Caching
- Cache invalidation
- Performance monitoring
- Transaction management

These concerns are implemented through interceptor-based approaches where applicable.

## Learning Objectives

This project is part of my ongoing practice in:

- Designing layered backend applications
- Implementing authentication with JWT
- Applying validation rules with FluentValidation
- Using dependency injection and Autofac
- Understanding aspect-oriented programming and cross-cutting concerns
- Organizing code for maintainability and reusability

## Acknowledgment

This project was developed while following Engin Demiroğ's training materials. Some infrastructure and cross-cutting concern implementations were adapted from the course's reference code for learning purposes.

## Status

Educational project — continuously learning and improving.

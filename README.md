# BrazilGeoAPI 🌎

BrazilGeoAPI is an API that provides geographical information about cities and states in Brazil. This project is part of a development challenge and aims to create a robust API with authentication, registration, search, and data import functionalities.

## Features 🔨

- **Authentication and Authorization:** The API offers secure authentication and authorization to protect sensitive data.
- **Email and Password Registration:** Users can register on the platform to access protected resources.
- **Login (Token, JWT):** Authentication is based on JWT tokens to ensure the security of sessions.
- **CRUD of Location:** The API allows creating, reading, updating, and deleting information about codes, states, and cities in Brazil.
- **City and State Search:** Users can search for cities and states based on specific criteria.
- **Data Import:** It is possible to import geographical data from an Excel file.

## Technologies Used ⚙️

- **.NET 7:** Version of the .NET framework for application development.
- **Asp.Net Core 7:** Microsoft's framework for developing APIs and web applications.
- **Entity Framework Core:** ORM technology for object and database entity relationships, using the Code First approach to generate tables from entity classes.
- **SQL Server:** Microsoft's Database Management System (DBMS) chosen for this project.
- **FLUNT:** Notification pattern developed by Balta.io.
- **CQRS:** Architectural pattern designed to separate responsibilities between commands and queries (Command Query Responsibility Segregation).
- **Adapter:** The Adapter pattern acts as a bridge between two incompatible interfaces; we use it to transform an entity into a Dto.
- **Clean Architecture:** Clean Architecture allows changes to have isolated impacts and makes the system easily extendable and maintainable.

![image](https://github.com/RaMadaSilva/BrasilGeoWebApi/assets/91338367/6931f1b7-5d8e-425d-8a07-cc52ba5a00e3)

## How to Use 🔍

1. Clone this repository.
2. Set up the development environment and necessary dependencies.
3. Run the application.
4. Access the API documentation (Swagger) to understand available routes and functionalities.
5. Start using the API's features.

## Contribution 🤝

Feel free to contribute improvements, bug fixes, and new features. To contribute, follow these steps:

1. Fork this repository.
2. Create a branch for your contribution: `git checkout -b feature/your-feature`.
3. Develop and test your changes.
4. Commit the changes: `git commit -m 'Add your message here'`.
5. Push the changes to your fork: `git push origin feature/your-feature`.
6. Create a pull request in this repository.

## License 📕

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

# .NET Core GraphQL with Clean Architecture

This project demonstrates how to build a .NET Core web application using GraphQL as the API layer and adhering to Clean Architecture principles. It showcases how to structure the solution with clear separation of concerns, allowing for independent development and testing of the application's business logic, data access layer, and GraphQL API.


## Table of Contents
- [Key-Features](#keyfeatures)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Key Features

- **GraphQL API:** Utilize the power of GraphQL to efficiently query and mutate data from a single endpoint, enabling clients to request precisely the data they need.

- **Clean Architecture:** The project follows Clean Architecture principles, ensuring a clear separation of concerns between the business logic, data access, and presentation layers.

- **Entity Framework Core:** Leverage the capabilities of Entity Framework Core, a robust and flexible ORM, for seamless data access and database management.

- **Dependency Injection:** Benefit from the built-in Dependency Injection feature in .NET Core for loose coupling and easier testing of components.

- **Unit Testing:** The project includes a comprehensive suite of unit tests for the core business logic, ensuring the reliability and stability of the application.

- **Scalable and Maintainable:** Designed with scalability and maintainability in mind, making it suitable for projects of varying sizes and complexities.

- **Easy Setup:** Quick and straightforward installation process, allowing developers to get up and running with the project in no time.

- **Contributor Friendly:** Welcoming contributions from the community, including bug reports, feature requests, and code contributions. See [Contributing](#contributing) for guidelines.

- **MIT License:** Released under the permissive MIT License, granting users the freedom to use, modify, and distribute the project with minimal restrictions.


## Installation

1. Clone the repository.
2. Open the solution in Visual Studio or your preferred code editor.

## Usage

### Prerequisites

Make sure you have the following installed:

- .NET Core SDK
- Visual Studio (optional, but recommended for a better development experience)

### Running the Application

1. Open a terminal and navigate to the 'AnimeGraphQL' folder.
2. Run the following command to launch the application:


3. The GraphQL API will be available at `https://localhost:5001/animegraphql` (or `http://localhost:5000/animegraphql`).

### Interacting with the GraphQL API

```
query{
  anime {
    name,
    rate,
    story
  }
}
```

## Contributing

welcome contributions to improve the project! To contribute, follow these steps:

1. Fork the repository.
2. Create a new branch for your changes.
3. Make your modifications and commit them with descriptive commit messages.
4. Push your changes to your fork.
5. Submit a pull request, explaining the changes and their purpose.

I appreciate your help in making this project better!

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

# .NET Core GraphQL with Clean Architecture

### Key Features:

Clean Architecture: The project follows Clean Architecture principles, ensuring a clear separation of the application's core business logic, infrastructure, and presentation layers.
GraphQL API: Utilizing GraphQL as the API layer allows for more flexible and efficient data querying, enabling clients to request precisely the data they need.
Entity Framework Core: The project uses Entity Framework Core as the ORM for data access, providing a reliable and scalable data access solution.
Dependency Injection: Leveraging the built-in Dependency Injection in .NET Core for loose coupling and easier testing.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

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

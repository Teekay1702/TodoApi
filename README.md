
# Todo API 📝 | C# .NET Controller-Based Web API

This is a controller-based RESTful API built using C# and .NET, designed to manage a To-Do list. It follows the MVC (Model-View-Controller) pattern and uses Microsoft.EntityFrameworkCore.InMemory for temporary data storage.

⚠ Note: This project requires running in Visual Studio, not VS Code.


## Features

- Create new tasks
- Retrieve all tasks or a specific tasks
- Update task details
- delete task
- Uses Entity Framework Core InMemory for data storage
- Controller-based architecture for clean separation of concerns


## Tech Stack

**Backend:** C# (.NET 9)

**Framework:** ASP.NET Core WebAPI

**Database:** Entity Framework Core InMemory


## Installation

Install the TodoAPI

1. Clone the repository 

```bash
  git clone https://github.com/Teekay1702/TodoApi.git

```

2. Open in Visual Studio

- Open Visual Studio (not VS Code).

- Click "Open a project or solution" and select the TodoApi.sln file.

3.  Run the API

- Press ctrl + F5 to run the API
## In-Memory Database Setup

This project uses Microsoft.EntityFrameworkCore.InMemory, meaning data is not persisted after the app restarts.
To configure the in-memory database, check Program.cs:

```bash
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseInMemoryDatabase("TodoList"));
```## 📝 API Endpoints

| **Method** | **Endpoint**        | **Description**        |
|------------|--------------------|-------------------------|
| **GET**    | `/api/todos`       | Get all tasks           |
| **GET**    | `/api/todos/{id}`  | Get a task by ID        |
| **POST**   | `/api/todos`       | Create a new task       |
| **PUT**    | `/api/todos/{id}`  | Update a task by ID     |
| **DELETE** | `/api/todos/{id}`  | Delete a task by ID     |

## Contributing

Contributions are welcome! If you find a bug or have a feature request, feel free to open an issue or submit a pull request.

Please adhere to this project's `code of conduct`.


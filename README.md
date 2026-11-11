# Qaraca Theatre – Back End (ASP.NET Core MVC)

Back end for Qaraca Theatre, a multi-page theatre website with interactive ticket booking and seat selection.
Final project of a 6-month Full-stack Software Development program, presented live to an evaluation panel for certification.

**Front end repository:** [Qaraca.teatr](https://github.com/tutu-creator/Qaraca.teatr)
**Live demo (front end):** [tutu-creator.github.io/Qaraca.teatr](https://tutu-creator.github.io/Qaraca.teatr/)

## Features
- Ticket booking with seat selection (available, selected, occupied)
- Repertoire management: plays, genres, duration, age rating and price
- Admin panel (Areas) to manage content
- Layered structure: Controllers, Data Access Layer, Models, ViewModels, Views
- Relational database with Entity Framework Core migrations
- Docker support

## Built With
- C#, ASP.NET Core MVC
- Entity Framework Core, SQL Server
- Razor Views, Bootstrap
- Docker

## Getting Started
1. Clone the repository.
2. Fill in the placeholder values in `appsettings.json` (connection string, email settings).
3. Run database migrations: `dotnet ef database update`
4. Start the app: `dotnet run --project "Final Layihe"`

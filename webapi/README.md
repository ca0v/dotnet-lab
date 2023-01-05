# WebAPI Lab

A dotnet webapi Lab

## Commands

    >dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.1
    >dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.1
    >dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.1
    >dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.1
    >dotnet tool install --global dotnet-aspnet-codegenerator --version 7.0.1

Assumes the sqlite database has user-related tables already,

    >dotnet ef dbcontext scaffold "Data Source=./database.sqlite" Microsoft.EntityFrameworkCore.Sqlite -o MyDbContext -c MyUserContext

Once the dbcontext has been generated,

    >npm run update-controller
    >npm run update-page
    >npm run watch

Open the view [UserDatabaseView](http://localhost:5202/UserDatabaseView)

Any changes to MyUserContext are reflected into the database,

    >npm run update-database

## Links

* [Swagger API](http://localhost:5202/swagger/index.html)
* [UserDatabaseView](http://localhost:5202/UserDatabaseView)
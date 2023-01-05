# WebAPI Lab

A dotnet webapi Lab

## Commands

* dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.1
* dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.1

I could not remember how to create a dbcontext, so I created the table and then...

* dotnet ef dbcontext scaffold "Data Source=./database.sqlite" Microsoft.EntityFrameworkCore.Sqlite -o MyDbContext -c MyUserContext

I could not remember how to create the services, so...

* dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.1
* dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.1
* dotnet tool install --global dotnet-aspnet-codegenerator --version 7.0.1

And then,

* npm run update-controller



## Links

* [Swagger API](http://localhost:5202/swagger/index.html)

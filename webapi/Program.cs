using Microsoft.EntityFrameworkCore;
using webapi.MyDbContext;

CreateSqliteDatabase.CreateDatabase();

var builder = WebApplication.CreateBuilder(args);

// Add sqlite dbcontext
builder.Services.AddDbContext<MyUserContext>();

// get the views to work
builder.Services.AddRazorPages();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add a sqlite database
// builder.Services.AddDbContext<DbContext>(options => options.UseSqlite("Data Source=database.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages(); // critical to get Pages to show
});

app.Run();

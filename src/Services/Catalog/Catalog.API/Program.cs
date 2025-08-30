using Carter;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});


app.MapCarter();


app.Run();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c=>{
    c.SwaggerEndpoint("/myapiapp/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = "myapiapp/swagger"; // serve swagger UI at /myapiapp/swagger
});

app.UseAuthorization();

app.MapControllers();

app.Run();

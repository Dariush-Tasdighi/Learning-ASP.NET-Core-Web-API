// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder = Microsoft.AspNetCore
//	.Builder.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// using Microsoft.AspNetCore.Builder;
//app.MapGet(pattern: "/",
//	handler: () => "Hello World!");

//app.Run();
// **************************************************

// **************************************************
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = Microsoft.AspNetCore
	.Builder.WebApplication.CreateBuilder(args: args);

// using Microsoft.Extensions.DependencyInjection;
builder.Services
	.AddControllers();

var app =
	builder.Build();

app.UseHttpsRedirection();

// using Microsoft.AspNetCore.Builder;
app.MapControllers();

app.Run();
// **************************************************

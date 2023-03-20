using Microsoft.AspNetCore.Builder;

var builder = Microsoft.AspNetCore
	.Builder.WebApplication.CreateBuilder(args: args);

var app =
	builder.Build();

// using Microsoft.AspNetCore.Builder;
app.MapGet(pattern: "/",
	handler: () => "Hello World!");

app.Run();

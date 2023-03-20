namespace Server.Controllers;

//[Microsoft.AspNetCore.Mvc.Route
//	(template: "googooli")]

// https://localhost:7001/googooli

//[Microsoft.AspNetCore.Mvc.Route
//	(template: "step01")]

// https://localhost:7001/step01

// ممکن است، بی‌دقتی کنیم
//[Microsoft.AspNetCore.Mvc.Route
//	(template: "stop01")]

// https://localhost:7001/step01

//[Microsoft.AspNetCore.Mvc.Route
//	(template: "[controller]")]

// https://localhost:7001/step01

//[Microsoft.AspNetCore.Mvc.Route
//	(template: "api/[controller]")]

// https://localhost:7001/api/step01

[Microsoft.AspNetCore.Mvc.Route(template:
	Infrastructure.RouteConstants.Default)]

// https://localhost:7001/step01

//public class Step01Controller :
//	Microsoft.AspNetCore.Mvc.ControllerBase
public class Step01Controller : Infrastructure.BaseController
{
	public Step01Controller() : base()
	{
	}

	[Microsoft.AspNetCore.Mvc.HttpGet]
	public string SomeFunction()
	{
		return "Hello, World!";
	}
}

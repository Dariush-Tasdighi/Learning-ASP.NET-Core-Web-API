namespace Server.Controllers;

[Microsoft.AspNetCore.Mvc.Route(template:
	Infrastructure.RouteConstants.Default)]
public class Step02Controller : Infrastructure.BaseController
{
	public Step02Controller() : base()
	{
	}

	[Microsoft.AspNetCore.Mvc.HttpGet]
	public string Get()
	{
		return "Hello, World!";
	}
}

namespace Server.Controllers;

[Microsoft.AspNetCore.Mvc.Route(template:
	Infrastructure.RouteConstants.Default)]
public class Step03Controller : Infrastructure.BaseController
{
	public Step03Controller() : base()
	{
	}

	// **************************************************
	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public string SomeName()
	//{
	//	var message =
	//		"Hello, World!";

	//	return message;
	//}
	// **************************************************

	// **************************************************
	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//[Microsoft.AspNetCore.Mvc.HttpPost]
	//public Microsoft.AspNetCore.Mvc.IActionResult SomeName()
	//{
	//	var message =
	//		"Hello, World!";

	//	return Content(content: message);
	//}
	// **************************************************

	// **************************************************
	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public string SomeName()
	//{
	//	var message =
	//		"Hello, World!";

	//	return message;
	//}

	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public Microsoft.AspNetCore.Mvc.IActionResult SomeName()
	//{
	//	var message =
	//		"Hello, World!";

	//	return Content(content: message);
	//}

	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public Microsoft.AspNetCore.Mvc.ActionResult SomeName()
	//{
	//	var message =
	//		"Hello, World!";

	//	return Content(content: message);
	//}

	/// <summary>
	/// بیشتر توصیه می‌شود
	/// </summary>
	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public Microsoft.AspNetCore.Mvc.ContentResult SomeName()
	//{
	//	var message =
	//		"Hello, World!";

	//	return Content(content: message);
	//}
	// **************************************************

	// **************************************************
	// خطا می‌دهد C# از نظر
	// **************************************************
	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public Microsoft.AspNetCore.Mvc.IActionResult SomeName()
	//{
	//	var message =
	//		"Hello, World!";

	//	return Content(content: message);
	//}

	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public Microsoft.AspNetCore.Mvc.IActionResult SomeName()
	//{
	//	var message =
	//		"Hello, World!";

	//	return Content(content: message);
	//}
	// **************************************************

	// **************************************************
	// خطا می‌دهد Web API از نظر
	// **************************************************
	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public Microsoft.AspNetCore.Mvc.IActionResult SomeName1()
	//{
	//	var message =
	//		"Hello, World!";

	//	return Content(content: message);
	//}

	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public Microsoft.AspNetCore.Mvc.IActionResult SomeName2()
	//{
	//	var message =
	//		"Hello, World!";

	//	return Content(content: message);
	//}
	// **************************************************

	// **************************************************
	[Microsoft.AspNetCore.Mvc.HttpGet]
	public Models.User SomeName()
	{
		// **************************************************
		//Models.User user = new Models.User();

		//user.Username = "Dariush";
		//user.Password = "1234512345";
		//user.FullName = "Dariush Tasdighi";
		// **************************************************

		// **************************************************
		//Models.User user = new();

		//user.Username = "Dariush";
		//user.Password = "1234512345";
		//user.FullName = "Dariush Tasdighi";
		// **************************************************

		// **************************************************
		//var user = new Models.User();

		//user.Username = "Dariush";
		//user.Password = "1234512345";
		//user.FullName = "Dariush Tasdighi";
		// **************************************************

		// **************************************************
		//var user = new Models.User() { Username = "Dariush", Password = "1234512345", FullName = "Dariush Tasdighi" };
		// **************************************************

		// **************************************************
		//var user = new Models.User { Username = "Dariush", Password = "1234512345", FullName = "Dariush Tasdighi" };
		// **************************************************

		// **************************************************
		//var user =
		//	new Models.User
		//	{
		//		FullName = "Dariush Tasdighi",
		//		Username = "Dariush",
		//		Password = "1234512345"
		//	};
		// **************************************************

		// **************************************************
		//var user =
		//	new Models.User
		//	{
		//		FullName = "Dariush Tasdighi",
		//		Username = "Dariush",
		//		Password = "1234512345",
		//	};
		// **************************************************

		// **************************************************
		var user =
			new Models.User
			{
				Username = "Dariush",
				Password = "1234512345",
				FullName = "Dariush Tasdighi",
			};
		// **************************************************

		return user;
	}
	// **************************************************

	// **************************************************
	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//public Models.User SomeName2_1()
	//{
	//	Models.User user =
	//		new Models.User
	//		{
	//			Id = 1,
	//			Username = "User1",
	//			Password = "12345",
	//			FullName = "Dariush Tasdighi",
	//		};

	//	return user;
	//}

	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//[Microsoft.AspNetCore.Mvc.Route(template: "GetSomeUser")]
	//public Models.User SomeName2_2()
	//{
	//	Models.User user =
	//		new Models.User
	//		{
	//			Id = 2,
	//			Username = "User2",
	//			Password = "12345",
	//			FullName = "Ali Reza Alavi",
	//		};

	//	return user;
	//}

	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//[Microsoft.AspNetCore.Mvc.Route(template: "SomeName2_2")] // احتمال سوتی دادن
	//public Models.User SomeName2_2()
	//{
	//	Models.User user =
	//		new Models.User
	//		{
	//			Id = 2,
	//			Username = "User2",
	//			Password = "12345",
	//			FullName = "Ali Reza Alavi",
	//		};

	//	return user;
	//}

	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//[Microsoft.AspNetCore.Mvc.Route(template: nameof(SomeName2_2))]
	//public Models.User SomeName2_2()
	//{
	//	Models.User user =
	//		new Models.User
	//		{
	//			Id = 2,
	//			Username = "User2",
	//			Password = "12345",
	//			FullName = "Ali Reza Alavi",
	//		};

	//	return user;
	//}
	// **************************************************

	// **************************************************
	/// <summary>
	/// نگاه ذیل خیلی توصیه نمی‌شود
	/// </summary>
	//[Microsoft.AspNetCore.Mvc.HttpGet]
	//[Microsoft.AspNetCore.Mvc.Route(template: "/GetSomeUser")]
	//public Models.User SomeName3()
	//{
	//	Models.User user =
	//		new Models.User
	//		{
	//			Id = 1,
	//			Username = "User1",
	//			Password = "12345",
	//			FullName = "Dariush Tasdighi",
	//		};

	//	return user;
	//}
	// **************************************************

	// **************************************************
	//[Microsoft.AspNetCore.Mvc.HttpGet(template: "GetSomeUser")]
	//public Models.User SomeName()
	//{
	//	Models.User user =
	//		new Models.User
	//		{
	//			Id = 1,
	//			Username = "User1",
	//			Password = "12345",
	//			FullName = "Dariush Tasdighi",
	//		};

	//	return user;
	//}
	// **************************************************
}

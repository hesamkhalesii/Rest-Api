using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly Dictionary<string, Dictionary<string, string>> adminApi = new Dictionary<string, Dictionary<string, string>>
		{
			{
				"9056313355", new Dictionary<string, string>
				{
					{ "Role", "Admin" },
					{ "Password", "admin" },
					{ "Access", "All" },
					{ "Phonenumber", "09056313355" }
				}
			},
			{
				"9127278971", new Dictionary<string, string>
				{
					{ "Role", "Admin" },
					{ "Password", "12345" },
					{ "Access", "JustAddServer" },
					{ "Phonenumber", "09127278971" }
				}
			}
		};

		private readonly Dictionary<string, Dictionary<string, Dictionary<string, string>[]>> users = new Dictionary<string, Dictionary<string, Dictionary<string, string>[]>>()
{
	{
		"9056313355", new Dictionary<string, Dictionary<string, string>[]>
		{
			{
				"UserInfo", new Dictionary<string, string>[]
				{
					new Dictionary<string, string>
					{
						{ "ProductStatus", "Preparation" },
						{ "Statusvalue", "60%" },
						{ "QrLink", "https://atmiran.com/wp-content/uploads/2016/12/barcode-2d.png" },
						{ "ConfingLink", "https://atmiran.com/wp-content/uploads/2016/12/barcode-2d.png" },
						{ "ServerList", "[9, 15, 18, 46, 16, 48, 23, 123, 43, 76, 112, 90, 14, 55]" },
						{ "ServerStatus", "غیر فعال" },
						{ "ConfingName", "#C998_32" },
						{ "Supportprotocol", "WireGurd" },
						{ "SubscriptionTime", "60" },
						{ "SubscriptionTimeLeft", "25" },
						{ "Supportsoftware", "اندروید و ویندوز" }
					}
				}
			}
		}
	},
	{
		"9127278971", new Dictionary<string, Dictionary<string, string>[]>
		{
			{
				"UserInfo", new Dictionary<string, string>[]
				{
					new Dictionary<string, string>
					{
						{ "ProductStatus", "Preparation" },
						{ "Statusvalue", "60%" },
						{ "QrLink", "https://atmiran.com/wp-content/uploads/2016/12/barcode-2d.png" },
						{ "ConfingLink", "https://atmiran.com/wp-content/uploads/2016/12/barcode-2d.png" },
						{ "ServerList", "[9, 15, 18, 46, 16, 48, 23, 123, 43, 76, 112, 90, 14, 55]" },
						{ "ServerStatus", "غیر فعال" },
						{ "ConfingName", "#C998_32" },
						{ "Supportprotocol", "WireGurd" },
						{ "SubscriptionTime", "60" },
						{ "SubscriptionTimeLeft", "25" },
						{ "Supportsoftware", "اندروید و ویندوز" }
					}
				}
			}
		}
	}
};




		private readonly Dictionary<string, Dictionary<string, Dictionary<string, string>>> orderTracking = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>()
{
	{
		"9056313355", new Dictionary<string, Dictionary<string, string>>
		{
			{
				"Ordertracking", new Dictionary<string, string>
				{
					{ "loginCode", "Hi83na939SD" },
					{ "PhoneNumber", "09056313355" }
				}
			}
		}
	},
	{
		"9127278971", new Dictionary<string, Dictionary<string, string>>
		{
			{
				"Ordertracking", new Dictionary<string, string>
				{
					{ "loginCode", "koldf89B" },
					{ "PhoneNumber", "09127278971" }
				}
			}
		}
	},
	{
		"9121333164", new Dictionary<string, Dictionary<string, string>>
		{
			{
				"Ordertracking", new Dictionary<string, string>
				{
					{ "loginCode", "koldf89B" },
					{ "PhoneNumber", "09121333164" }
				}
			}
		}
	}
};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public Dictionary<string, object> Get()
		{
			return new Dictionary<string, object>()
			{
				{ "adminApi", adminApi },
				{ "Users", users },
				{ "orderTracking", orderTracking }
			};
		}
	}
}

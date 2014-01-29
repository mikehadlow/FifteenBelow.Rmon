using System.Reflection;
using Nancy;
using Nancy.Responses;

namespace FifteenBelow.Rmon.Hendon
{
    public class Home : NancyModule
    {
        public Home()
        {
            Get["/"] = parameters => Response.AsRedirect("api", RedirectResponse.RedirectType.Permanent);
        }
    }

    public class ApiBase : NancyModule
    {
        public ApiBase() : base("api")
        {
            Get["/"] = parameters => new Api
            {
                Version = Assembly.GetExecutingAssembly().GetName().Version.ToString()
            };
        }
    }

    public class Api
    {
        public string Version { get; set; }
    }
}
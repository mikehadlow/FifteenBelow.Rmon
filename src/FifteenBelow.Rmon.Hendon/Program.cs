using System;
using System.Threading;
using Nancy.Hosting.Self;

namespace FifteenBelow.Rmon.Hendon
{
    class Program
    {
        static void Main(string[] args)
        {
            const string uri = "http://localhost:8888";
            Console.WriteLine("Listening on: {0}", uri);

            var configuration = new HostConfiguration {UrlReservations = {CreateAutomatically = true}};

            using (var host = new NancyHost(configuration, new Uri(uri)))
            {
                host.Start();
                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}

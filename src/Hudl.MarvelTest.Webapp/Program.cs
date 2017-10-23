using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Hudl.Marvel.Platform.Startup;
using System.Reflection;
using System.Linq;
using System;

namespace Hudl.SpeedTest.Webapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO - add this into platform? It's mostly just for local debugging purposes and only during startup,
            // but without it the ReflectionTypeLoadException has a rather useless log
            try
            {
                new MarvelWebHostBuilder<Startup>()
                    .Build()
                    .Run();
            }
            catch (ReflectionTypeLoadException ex)
            {
                if (ex.LoaderExceptions.Any())
                {
                    foreach (var loaderException in ex.LoaderExceptions)
                    {
                        Console.WriteLine(loaderException);
                    }
                }
                throw ex;
            }
        }
    }
}

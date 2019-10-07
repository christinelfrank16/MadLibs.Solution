using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MadLib
{
  public class Program
  {
      public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        // .UseWebRoot("Content")    : allows you to change wwwroot folder name to 'Content' -> css styling
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }

  }
}
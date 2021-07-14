using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Turnos
{
    public class Program
    {

        //! Main se ejecutara cuando ejecutemos la aplicacion
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //! Metodo que hace servir nuestra aplicacion con el servidor kestre
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

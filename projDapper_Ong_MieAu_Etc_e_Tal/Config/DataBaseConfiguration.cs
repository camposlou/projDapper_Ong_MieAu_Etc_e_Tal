using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Config
{
    public class DataBaseConfiguration
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static string Get()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);  //optional - tratativa de erro 
                                                                                     //reloadOnChange - se alterar alguma coisa no arquivo de configuração, ele pega a string atualizada   
            Configuration = builder.Build();
            return Configuration["ConnectionStrings:DefaultConnection"];
           
        }
    }
}

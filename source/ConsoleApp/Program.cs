using System;
using System.Configuration;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing System.DateTime.Now");
            Console.WriteLine("");
            Console.WriteLine("System.DateTime.Now = " + DateTime.Now.ToLongTimeString());
            IDateTimeProxy dateTimeProxy = new DateTimeProxy();
            Console.WriteLine("System.DateTime.Now = " + dateTimeProxy.Now.ToLongTimeString());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Testing System.Configuration.ConfigurationManager");
            Console.WriteLine("");
            Console.WriteLine(@"System.Configuration.ConfigurationManager.AppSettings[""item1""] = " + ConfigurationManager.AppSettings["item1"]);
            IConfigurationManagerProxy configurationManager = new ConfigurationManagerProxy();
            Console.WriteLine(@"configurationManager.AppSettings[""item1""] = " + configurationManager.AppSettings["item1"]);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Testing System.Configuration.ConfigurationManager");
            Console.WriteLine("");
            Console.WriteLine(@"System.Configuration.ConfigurationManager.AppSettings[""item1""] = " + ConfigurationManager.AppSettings["item1"]);
            Console.WriteLine(@"configurationManager.AppSettings[""item1""] = " + configurationManager.ConnectionStrings["item1"]);
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}

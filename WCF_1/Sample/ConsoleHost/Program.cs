using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Sample.People));
            host.Open();
            Console.WriteLine("服务启动啦********");
            Console.ReadLine();
        }
    }
}

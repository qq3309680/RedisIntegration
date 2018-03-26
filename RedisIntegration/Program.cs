using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "tanzhen";
            new RedisHelper().Set("abc", s, 10);
            Console.WriteLine("ok");
            Console.ReadKey();

            Console.WriteLine(new RedisHelper().Get<string>("abc"));
            //Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}

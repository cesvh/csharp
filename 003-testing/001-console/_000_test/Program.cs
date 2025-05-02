using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_test
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Something()
        {
            return "Hello World!";
        }

        public static bool Login(string user, string pass) => user == "admin" && pass == "admin";
    }
}

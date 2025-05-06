using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001TestDifDir
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Test()
        {
            return "Test";
        }

        public static bool Login(string user, string pass) => user == "admin" && pass == "admin";
    }
}

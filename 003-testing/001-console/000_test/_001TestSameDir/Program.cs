using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001TestSameDir
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

        public static bool Login(string user, string password)
        {
            return user == "admin" && password == "1234";
        }
    }
}

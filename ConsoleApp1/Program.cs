using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client aze = new ServiceReference1.Service1Client();
            string str = aze.GetData(10);
        }
    }
}

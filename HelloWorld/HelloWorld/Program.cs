using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomHelloWorld chw = new CustomHelloWorld();
            Console.WriteLine(chw.SayCustomHello("Ajay"));
            Console.Read();
        }
    }
}

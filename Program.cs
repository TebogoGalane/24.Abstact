using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abstact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle car1 = new vehicle();
            corsa cars2 = new corsa();

            Console.WriteLine(cars2.wheels);

            Console.Read();

        }
    }
}

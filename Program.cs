using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, Func<int, Func<int, int>>> add = x => y => z => x + y + z;

            WriteLine(add(1)(2)(3));

            Func<Func<int>> Closure = () =>
            {
                int property = 1;
                return () =>
                {
                    WriteLine(property);
                    return property = property + 1;
                };
            };

            var closure = Closure();

            closure();
            closure();
            closure();

            ReadLine();
        }
    }
}

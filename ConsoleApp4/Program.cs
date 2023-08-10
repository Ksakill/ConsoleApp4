using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Variablelength = 16;
            double width = 5.1;

            Console.WriteLine(Variablelength * width);

            int area = width * Variablelength; // Opgave B: du kan ikke converte en int til doubel (data type er int og kan ikke rume en doubel.

            double d = width * Variablelength; // Opgave C: data type er en doubel dette virker fordi at tallet are en doubel
            Console.WriteLine(d);
        }
    }
}

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

            Console.Clear();
            List<int> numbers = new List<int>();
            int num;
            Console.WriteLine("Debe ingresar 10 numeros.");
            while (numbers.Count() < 2)
            {
                Console.WriteLine(string.Format("{0}) Ingrese un numero par: ", (numbers.Count() +1 )));
                bool isNumeric = int.TryParse(Console.ReadLine(), out num);
                if (isNumeric) {
                    if (num % 2 == 0)
                    {
                        numbers.Add(num);
                    }
                    else {
                        Console.WriteLine("No es numero par!");
                    }
                } else {
                    Console.WriteLine("Debe ingresar solo numeros!");
                }
            }
            var output = string.Join(", ", numbers.Select(x => x.ToString()).ToArray());

            var newVector = string.Join(", ", numbers.Select(x => x + 1).ToArray());

            Console.WriteLine("Vector ingresado por el usuario: ");
            Console.WriteLine(output);
            Console.WriteLine("Vector de aplicacion: ");
            Console.WriteLine(newVector);
            Console.ReadLine();
        }

 
    }
}

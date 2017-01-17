using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteForaDoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = Convert.ToDouble(Console.ReadLine());
            double area = 3.14159 * raio * raio;
            
            Console.WriteLine("A="+String.Format("{0:0.0000}",area));
            Console.ReadKey();

        }
    }
}

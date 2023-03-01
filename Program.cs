using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lyakhov_lab2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Количество людей = ");
            int n = int.Parse(Console.ReadLine());

            Person[] People = new Person[n];
            for (int i = 0;i< n;i++)
            {
                People[i] = new Person();
            }
            for (int i = 0; i < n; i++)
            {
                People[i].Input();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(People[i]);
                Console.WriteLine();
            }
            Person firstperson = new Person();

            Console.ReadLine();
        }
    }
}

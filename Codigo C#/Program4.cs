using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
      public sealed class Program
    {
        static void Main(string[] args)
        {
            //var idade = 25;
            //IList<int> numero=new List<int>();
            //for (int i = 0; i<=10; i++)
            //{
            //    numero.Add(i);
            //}
            //foreach (int i in numero)
            //{ 
            //    Console.WriteLine(i);
            //}
            
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            if (num % 2 == 0)
            {
                Console.WriteLine($"O Numero é par {num}");
            }
            else
            {
                Console.WriteLine($"O numero é impar{num}");
            }
        }
    }
}

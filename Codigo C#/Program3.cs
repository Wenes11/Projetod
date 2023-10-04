using System;

namespace Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade <18)
            {
                Console.WriteLine($"Permissão não concedida {idade}");
            }else 
            {
                Console.WriteLine($"Permissão concedida {idade}");
            }
        }
    }
}

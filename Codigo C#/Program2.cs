using System;
using System.Linq.Expressions;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int res;
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 1 para soma,2 para subtrair, 3 multiplicar, 4 para dividir");
            var test = Convert.ToInt32(Console.ReadLine());
            switch (test)
            {
                case 1:
                    res = num1+num2;
                    Console.WriteLine($"O Resultado da soma é :{res}");
                    break;  
                case 2:
                    res = num1-num2;
                    Console.WriteLine($"O resultado da subtração é :{res}");
                    break;
                case 3:
                    res = num1*num2;
                    Console.WriteLine($"O resultado da multplicação é :{res}");
                    break;
                case 4:
                    res = num1/num2;
                    Console.WriteLine($"O resultado da divisão é :{res}");
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite um nome ");
            string nome = Console.ReadLine();
          List<string> pessoas= new List<string>();
            pessoas.Add("Pereira");
            pessoas.Add("Luizinho");
            pessoas.Add("Mari");
            pessoas.Add("Andre");
            pessoas.Add("Carlos");
            pessoas.Add("Andressa");
            if (pessoas.Contains(nome))
            {
                Console.WriteLine("Esta na lista ");
                pessoas.Remove(nome);
            }
            else {
               Console.WriteLine("Não esta na lista");
                pessoas.Add(nome);
            }
        foreach(string s in pessoas) {
           Console.WriteLine("Pessoa: {0}",s);
            }
        }
    }
}

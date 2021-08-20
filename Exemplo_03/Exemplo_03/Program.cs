using Exemplo_03.Entities;
using System;

namespace Exemplo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Caio", Email = "caiofelipebss@hotmail.com", Idade = 27, Cpf = 70213072416 };
            Client b = new Client { Name = "Caio Felipe", Email = "caiofelipebss@hotmail.com", Idade = 27, Cpf = 70213072416 };

            
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(a.Equals(b));
        }
    }
}


// GetHashCode e Equals personalizados.
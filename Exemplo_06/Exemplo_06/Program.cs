using System;
using System.Collections.Generic;

namespace Exemplo_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Caio";
            cookies["email"] = "caiofelipebss@hotmail.com";
            cookies["phone"] = "8193932222";
            cookies["phone"] = "8197971234"; // Como o Dictionary não admite repetições do objeto chave, ele irá sobrescrever para o segundo valor.

            Console.WriteLine(cookies["email"]);            

            Console.WriteLine("Phone number: " + cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
            foreach (KeyValuePair<string, string> item in cookies) // Para cada item do tipo KeyValuePair "string, string" dentro de Cookies, faça
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // Também poderia ser escrito assim:  foreach(var item in cookies)
        }
    }
}


// Dictionary

/*
 * 
 * Alguns métodos importantes:
        • dictionary[key] - acessa o elemento pela chave informada
        • Add(key, value) - adiciona elemento (exceção em caso de repetição)
        • Clear() - esvazia a coleção
        • Count - quantidade de elementos
        • ContainsKey(key) - verifica se a dada chave existe
        • ContainsValue(value) - verifica se o dado valor existe
        • Remove(key) - remove um elemento pela chave
*/
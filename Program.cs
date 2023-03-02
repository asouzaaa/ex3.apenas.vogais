using System;
using System.Globalization;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string str = Console.ReadLine();

            Console.Write("Vogais encontradas na string: ");
            foreach (char c in str)
            {
                if (IsVowel(c))
                {
                    Console.Write(c + " ");
                }
            }

            Console.ReadKey();
        }
        static bool IsVowel(char c)
        {
            switch (char.ToLower(c))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
               default: 
                        return false;

            }
        }
    }

}
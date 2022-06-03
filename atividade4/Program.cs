using System;

namespace atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = Console.ReadLine();
            char[] chars = new char[texto.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = texto[i];
            }

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
        }
    }
}

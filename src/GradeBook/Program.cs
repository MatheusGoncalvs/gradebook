using System;

namespace GradeBook
{
    class Program
    {
        //Metodo principal do programa. parametro args é um array de strings
        static void Main(string[] args)
        {
            //Utilizando interpolação de Strings com expressão C# $"{}"
            Console.WriteLine($"Hello {args[0]} !");

            //Utilizando concatenação de Strings
            //Console.WriteLine("Hello" + args[0] + "!");
        }
    }
}

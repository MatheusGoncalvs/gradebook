using System;

namespace GradeBook
{
    class Program
    {
        //Metodo principal do programa. parametro args é um array de strings
        static void Main(string[] args)
        {

            if(args.Length > 0) {
                //Utilizando interpolação de Strings com expressão C# $"{}"
                Console.WriteLine($"Hello {args[0]} !");
            }else {
                Console.WriteLine("Hello Stranger!");
            }
            
            //Utilizando concatenação de Strings
            //Console.WriteLine("Hello" + args[0] + "!");
        }
    }
}

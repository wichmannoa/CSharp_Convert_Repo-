using System;
/*Created for github*/
namespace SimpleConvertor
{
    class Convertor
    {
        static void Main(string[] args)
        {
            char[] characters;
            Console.WriteLine("What is your name, friend? ");
            characters = Console.ReadLine().ToCharArray();
            Console.WriteLine("Char\tBinary\t\tOctal\tDecimal\tHex");
            foreach (var item in characters)
            {               
                Console.WriteLine(item  + "\t0" + Convert.ToString(item, 2) + "\t" + Convert.ToString(item, 8) + "\t" + Convert.ToString(item, 10) + "\t" + Convert.ToString(item, 16));
            }
            Console.ReadLine();
        }
    }
}

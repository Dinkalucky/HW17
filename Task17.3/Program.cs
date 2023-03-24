using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            dynamic translation = "";
            var dictionary = new
            {
                ukr = new string[]{"яблуко", "груша", "мама", "сестра", "любов", "стіл", "сонце", "веселка", "радість", "кіт", "малина", "пташка" },
                eng = new string[] { "apple", "pear", "mother", "sister", "love", "steel", "sun", "merry", "radist", "whale", "raspberry", "birdie" },
            };

            for (int i = 0; i < dictionary.ukr.Length; i++)
            {
                translation += dictionary.ukr[i] + "-" + dictionary.eng[i] + "\n";
            }

            Console.WriteLine(translation);
            Console.ReadKey();
        }
    }
}

using System;

namespace HomeWork2
{
    class Program
    {
        static string checkMyLine()
        {


            int myline = 0;
            string line;

            line = Console.ReadLine();
            myline = int.Parse(line);
            if ((myline != 1) & (myline != 2) & (myline != 3))
            {
                Console.WriteLine("Please follow the instructions and try again");
                return checkMyLine();
            }

            return line;
        }

        static void Main(string[] args)
        {
            Console.Write("About which language do you want to know information? 1 - English, 2 - Spanish, 3 - Ukrainian ");
            string line = checkMyLine();
            byte languageValue;
            languageValue = byte.Parse(line);
            Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
            Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
            Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");
        }
        public enum Language : byte
        {
            English = 1,
            Spanish = 2,
            Ukrainian = 3
        }
    }
}


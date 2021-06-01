using System;

namespace Homework1_2
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
            //string line = Console.ReadLine();
            //int myline = int.Parse(line);
            ////Console.WriteLine($"{myline}");
            // byte languageValue;
            //switch (myline)
            //{
            // case 1:
            // case 2:
            //case 3:
            // languageValue = byte.Parse(line);
            // Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
            // Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
            // Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");
            // break;
            // default:
            //  Console.WriteLine("Please follow the instructions and try again");
            //  string line1 = Console.ReadLine();
            //myline = int.Parse(line1);
            //continue;
            //int myline = int.Parse(line);
            //Console.WriteLine($"{myline}");
            // byte languageValue;
            //break;


            //while (myline != 1)
            // {// | (myline != 2) | (myline != 3)
            //     Console.WriteLine("Please follow the instructions and try again");
            // }
            //  languageValue = byte.Parse(line);
            //     Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
            //   Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
            //    Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");
            //bool t;
            // if ((myline == 1) | (myline == 2) | (myline == 3))
            //{
            //     languageValue = byte.Parse(line);
            //    Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
            //    Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
            //   Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");
            //}
            // else
            // { 
            //    Console.WriteLine("Please follow the instructions and try again"); 
            //}

            //int integer = 1;
            ////int a, b, c = 2;
            //double dd = 1.5D;
            //float f = 1.3F;
            //char symbol = 'x';
            //string text = "Some text";
            //char textSymbol = text[0];

            //decimal first = 10M;
            //decimal second = 10.2M;
            //decimal sum = first + second;

            //Console.WriteLine("Sum " + sum);
        }

        public enum Language : byte
        {
            English = 1,
            Spanish = 2,
            Ukrainian = 3
        }
    }
}

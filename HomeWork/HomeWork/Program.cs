using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = 7;

            for (int i = 1; i <= lines; i++)
            {
                Console.Write(new String(' ', lines - i));
                Console.WriteLine(new String('.', i * 2 - 1));
            }
        }
    }
}
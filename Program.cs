using System;
using static System.Net.Mime.MediaTypeNames;

namespace szelseb
{
    internal class Program
    {
        public static int intData(string text)
        {
            bool error;
            string inputText;
            int num;
            do {
                Console.WriteLine(text);
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out num);
                if (error)
                {
                    Console.WriteLine("pozitiv szam. ujra");
                }
            } while (error);
            return num;
        }

        public static int[] IntBlock(int count,  string text)
        {
            bool error;
            string inputText;
            int[] intBlock = new int[count+1];
            for (int i = 1; i <= count; i++)
            {
                do
                {
                    Console.WriteLine(text);
                    inputText = Console.ReadLine();
                    error = !int.TryParse(inputText, out intBlock[i]);
                    if (error)
                    {
                        Console.WriteLine("pozitiv szam. ujra");
                    }
                } while (error);
            }
            return intBlock;
        }
            
        static void Main(string[] args)
        {
            int dayCount = intData("add meg a napok szamat");
            int raceDays = intData("add meg a versenynapoknapok szamat");
 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите предложение:");            
            string[] sentence = TakeWords(Console.ReadLine());
            WriteWords(sentence);
        }

        public static string[] TakeWords(string words)
        {
            string[] sentence = words.Split(' ');            
            return sentence;
        }

        public static void WriteWords(string[] check)
        {
            Console.Write($"\n");
            Console.WriteLine("Ваше предложение по словам:");
            foreach (string word in check)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}

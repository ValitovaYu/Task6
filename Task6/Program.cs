using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        /* Ввести с клавиатуры предложение.Предложение представляет собой слова, разделенные пробелом. 
         Знаки препинания не используются. Найти самое длинное слово в строке.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, состоящее из слов, разделенных пробелом, без знаков препинания");
            string startString = Console.ReadLine();
            string [] arrayString = startString.Split();                       
            string maxWord= string.Empty;
            for (int i = 0; i < arrayString.Length; i++)
            {
                if (arrayString[i].Length> maxWord.Length)
                {                    
                    maxWord = arrayString[i];
                }

            }
                        
            Console.WriteLine("Самое длинное слово: {0}", maxWord);
            Console.ReadKey();

        }
    }
}

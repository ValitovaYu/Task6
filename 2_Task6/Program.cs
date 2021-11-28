using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Task6
{
    class Program
    {
        /* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
         Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом 
        без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»)*/

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, состоящее из слов, разделенных пробелом, без знаков препинания");
            string s = Console.ReadLine();
            s = s.ToLower();
            s = s.Replace(" ", "");


            char[] sArray = s.ToCharArray();
            Array.Reverse(sArray);
            string sFinal = new string(sArray);

            if (s == sFinal)
            {
                Console.WriteLine("палиндром");
            }
            else
            Console.WriteLine("НЕ палиндром");

            Console.ReadKey();
        }
    }
}

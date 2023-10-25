using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
       // static void Main(string[] args)
       // {
            //Задание 1.Разработать программу с использованием класса StringBuilder, которая для заданной строки s:
            //Вариант 7.меняет местами первую букву со второй, третью с четвертой и т.д.

            //Console.WriteLine("Введите строку: ");
            //string input = Console.ReadLine();

            //StringBuilder stringBuilder = new StringBuilder(input);

            //for (int i = 0; i < stringBuilder.Length - 1; i += 2)
            //{
            //    char temp = stringBuilder[i];
            //    stringBuilder[i] = stringBuilder[i + 1];
            //    stringBuilder[i + 1] = temp;
            //}

            //Console.WriteLine("Измененная строка: " + stringBuilder.ToString());

            //Задание 2. Дана строка, в которой содержится осмысленное текстовое сообщение. Слова сообщения разделяются пробелами и знаками препинания.
            //Вариант 7.Найти все самые короткие слова сообщения.

        //    Console.WriteLine("Введите текстовое сообщение: ");
        //    string input = Console.ReadLine();

        //    string[] words = input.Split(new[] { ' ', ',', '.', '!', '?', ':', ';', '(', ')', '"', '\'', '-' }, StringSplitOptions.RemoveEmptyEntries);

        //    var shortestWords = FindShortestWords(words);

        //    if (shortestWords.Any())
        //    {
        //        Console.WriteLine("Самые короткие слова в сообщении:");
        //        foreach (string word in shortestWords)
        //        {
        //            Console.WriteLine(word);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Сообщение не содержит слов.");
        //    }
        //}

        //static string[] FindShortestWords(string[] words)
        //{
        //    if (words.Length == 0)
        //    {
        //        return new string[0];
        //    }

        //    int shortestLength = words.Min(word => word.Length);
        //    return words.Where(word => word.Length == shortestLength).ToArray();
        
        //}

     




    }
}
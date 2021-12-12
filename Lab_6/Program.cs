using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();
            // Представляем строку ввиде массива элементов
            string[] str = input.Split(new Char[] {' ', ' ', ' ', ' ', ' ',' ', ' '  }, StringSplitOptions.RemoveEmptyEntries); 
            // Используем метод Split для вывода слова по количеству букв 
            int maxlen = 0, index = 0;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                 }
            }
            Console.WriteLine("Самое длинное слово: {0}", str[index]);
            Console.ReadLine(); 

             
        }
    }
}

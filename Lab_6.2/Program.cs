using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string input = Console.ReadLine();
           string ss= string.Empty;
           string sss= string.Empty;   
            
            for (int x = input.Length - 1; x >= 0; x--)
            {
                if (input[x].ToString() != " ")
                {
                    ss += input[x].ToString().ToLower();
                }
            }
            for (int a = 0; a < input.Length; a++)
            {

                if (input[a].ToString() != " ")
                {
                    sss += input[a].ToString().ToLower();
                }
            }
            if (ss == sss)
            Console.WriteLine("Данное предложение является полидромом");
            else
            Console.WriteLine("Данная запись не является полиндромом");
            Console.ReadKey();
                    
            
        }

        
    }
}


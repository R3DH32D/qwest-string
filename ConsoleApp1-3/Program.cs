using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    public class Logic
    {
        public static string Rearrangement(string word, string outPut)
        {
            if (word.Length % 2 == 0)
            {
                for (int i = 0; i < word.Length - 1; i += 2)
                {
                    outPut = outPut + word[i + 1] + word[i];

                }
               
            }
            else { outPut = "Введено неверное слово, перезапустите программу и повторите попытку"; }

            return outPut;
        }
    }
     internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово-");
            string word = Console.ReadLine();

            string outPut = "";
            var outPutMessage = Logic.Rearrangement( word, outPut);
            Console.WriteLine(outPutMessage);

        }
    }

}


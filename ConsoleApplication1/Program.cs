using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofItem = 0;
            Console.Write("How many inputs? ");

            numberofItem = Convert.ToInt32(Console.ReadLine());
            myInput(numberofItem);
        }
        static void myInput(int numberofItem)
        {
            List<int> num = new List<int>();
            int output = 0, count = 0;
            string inputedodd = null;

            for (int i = 0; i < numberofItem; i++)
            {
                Console.Write($"\n{i + 1}) insert a number ");
                int myinput = Convert.ToInt32(Console.ReadLine());
                if (num.Contains(myinput) || myinput <= 0)
                {
                    i += -1;
                    Console.WriteLine("Number already in the list!");
                }
                else
                {
                    num.Add(myinput);
                }
            }

            foreach (int no in num)
            {
                if (no % 2 == 1)
                {
                    output += no;
                    count += 1;
                    inputedodd += no+"+";
                }
            }

            inputedodd = inputedodd.Substring(0, inputedodd.Length - 1);
            Console.WriteLine("\nNumber of odd {0} [{1}]", count, inputedodd);
            Console.WriteLine("The sum of odd number {0}", output);
            Console.ReadLine();
        }
    }
}

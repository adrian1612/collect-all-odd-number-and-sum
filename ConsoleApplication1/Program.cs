using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            int sumofodd = 0, sumofeven = 0, count = 0, counteven = 0;
            string inputedodd = null, inputedeven = null;
            
            for (int i = 0; i < numberofItem; i++)
            {
                Console.Write($"\n{i + 1}) insert a number ");
                int myinput = Convert.ToInt32(Console.ReadLine());
                if (num.Contains(myinput) || myinput <= 0)
                {
                    i += -1;
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You inserted a number already in the list please reinsert a unique number");
                    Console.ResetColor();
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
                    sumofodd += no;
                    count += 1;
                    inputedodd += no+"+";
                }
                else
                {
                    sumofeven += no;
                    counteven += 1;
                    inputedeven += no + "+";
                }
            }

            inputedodd = inputedodd.Substring(0, inputedodd.Length - 1);
            inputedeven = inputedeven.Substring(0, inputedeven.Length - 1);

            Console.WriteLine("\nNumber of odd {0} ({1} = {2})", count, inputedodd, sumofodd);
            Console.WriteLine("Number of even {0} ({1} = {2})", counteven, inputedeven, sumofeven);
            Console.WriteLine("Max Number {0}",num.Max());
            Console.WriteLine("Min Number {0}", num.Min());

            num.Sort();
            string me = null;
            foreach (int item in num)
            {
                me += item+",";
            }
            me = me.Substring(0, me.Length - 1);
            Console.WriteLine("Sort {0}",me);
            Console.ReadLine();
            Application.Restart();
        }
    }
}

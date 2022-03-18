using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_numbers_separate_by_hypen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separate by hypen : ");
            var name = Console.ReadLine();
            var numarray = name.Split('-');
            int firstValue = Convert.ToInt32(numarray[0]);

            bool cons = true;
            for (var i = 0; i < numarray.Length; i++)
            {
                if (Convert.ToInt32(numarray[i])-i != firstValue)
                {
                    cons = false;
                    break;
                }
            }
            if (cons)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}

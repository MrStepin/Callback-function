using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback_functions
{
    class Program
    {
        delegate bool Condition(int[] massive);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of massive:");
            int i, size = Convert.ToInt32(Console.ReadLine());
            int[] massive = new int[size];
            Console.WriteLine("Enter elements through space::");
            string[] num = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            for (i = 0; i < massive.Length; ++i)
            {
                massive[i] = Convert.ToInt32(num[i]);
            }

            Checker checker = new Checker();

            Condition condition = checker.Any;
            bool checkerCondition = condition(massive);
            if (checkerCondition == true)
            {
                Console.WriteLine("Any true");
            }
            else
            {
                Console.WriteLine("Any false");
            }
            condition = checker.All;
            if (checkerCondition == true)
            {
                Console.WriteLine("All true");
            }
            else
            {
                Console.WriteLine("Not all true");
            }
            Console.ReadKey();
        }
    }
}

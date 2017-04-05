using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovCSharpBook06ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the last positive number you want to print counting from 1 -> ");
            string userInp = Console.ReadLine();

            CheckInput(userInp);

        }

        private static void CheckInput(string userInp)
        {
            uint num = 0;
            bool checkValue = uint.TryParse(userInp, out num);

            if (checkValue)
            for (int i = 0; i <= num; i++)
            {
                Console.Write(" {0} ", i);
            }

            else
            { Console.WriteLine("Please enter positive integer"); };
        }
    }
}

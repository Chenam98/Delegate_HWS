using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HWS
{
    public class SimpleCalculator
    {
        public int NumberGetter()
        {
            Console.WriteLine("please enter a positive number");
            int PositiveNum = int.Parse(Console.ReadLine());

            if (PositiveNum < 0 || PositiveNum <= 0)
            {
                Console.WriteLine("Try again");
                NumberGetter();
            }

            return PositiveNum;
        }

        public void PrintMenu()
        {
            Console.WriteLine("choose an option:\n 1-Add \n 2-Substruct \n 3-Divide \n 4-Multiply");
        }

        public int GetUserChoice()
        {
            Console.WriteLine("enter a number between 1 - 4 included.");
            int oneTillFour = int.Parse(Console.ReadLine());

            if (oneTillFour < 1 || oneTillFour > 4)
                Console.WriteLine("Try again");

            return oneTillFour;
        }

        public double Calculate(int n1, int n2, int Option)
        {
            double result = Option;

            switch (Option)
            {
                case 1:
                    return n1 + n2;
                case 2:
                    return n1 - n2;
                case 3:
                    return n1 / n2;
                case 4:
                    return n1 * n2;
                default:
                    break;
            }
            return result;
        }

        public void PrintResultNicely(int n1, int n2, int Option, double result)
        {
            string str = Option.ToString();
            switch (Option)
            {
                case 1:
                    str = "+";
                    break;
                case 2:
                    str = "-";
                    break;
                case 3:
                    str = "/";
                    break;
                case 4:
                    str = "*";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"************\n result : {result} \n************ ");
        }
    }
}

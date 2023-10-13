using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //первая задача
            firstTask();
            //вторая задача
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigits(number));
        }
        static void firstTask()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int carry = 0;
            string result = "";

            int maxLength = Math.Max(input1.Length, input2.Length);
            input1 = input1.PadLeft(maxLength, '0');
            input2 = input2.PadLeft(maxLength, '0');

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int digit1 = input1[i] - '0';
                int digit2 = input2[i] - '0';

                int sum = digit1 + digit2 + carry;
                carry = sum / 10;
                result = (sum % 10) + result;
            }

            if (carry > 0)
            {
                result = carry + result;
            }

            Console.WriteLine(result.TrimStart('0'));
        }

        static int SumDigits(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return number % 10 + SumDigits(number / 10);
            }
        }
    }
}

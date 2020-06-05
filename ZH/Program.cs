using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Last num " + (num%10));
            while (true)
            {
                if (num / 10 < 1)
                {
                    num = num % 10;
                    break;
                }
                else
                {
                    num = num / 10;
                }
            }
            Console.WriteLine("First num " + num);
            Console.ReadKey();
            
        }
        
    }
}

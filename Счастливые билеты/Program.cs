using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Счастливые_билеты
{
    class Program
    {
        static void Main(string[] args)
        {
        link1:
            int n, f, ticket, quantity = 0;
            int i = 0;
            int summ1 = 0, summ2 = 0, number;
            int numsh = 0;
            string s2;
            Console.WriteLine("Enter number of ticket");
            string s1 = Convert.ToString(Console.ReadLine());
            if (int.TryParse(s1, out n))                
            {
                n = Convert.ToInt32(s1);
                if(n < 10)
                {                    
                    Console.WriteLine("Error!");
                    goto link1;
                }
            }

            else
            {
                Console.WriteLine("Error!");
                goto link1;
            }

            for (ticket = 10; ticket < n + 1; ticket++)
            {
                Console.WriteLine();
                summ1 = 0;
                summ2 = 0;
                Console.WriteLine("Ticket №" + ticket);
                string s3 = Convert.ToString(ticket);
                numsh = s3.Length / 2;
                for (i = 0; i < numsh; i++)
                {
                    s2 = s3[i].ToString();
                    number = Convert.ToInt32(s2);
                    summ1 = summ1 + number;
                }

                f = s3.Length - numsh;
                for (i = s3.Length; i > f; i--)
                {
                    s2 = s3[i-1].ToString();
                    number = Convert.ToInt16(s2);
                    summ2 = summ2 + number;
                }
                if (summ1 == summ2)
                {
                    Console.WriteLine("Ticket №" + ticket + " is lucky");
                    quantity++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are " + quantity + " lucky ticket before your");
            Console.Write("Would you like to go out (y):");
            string inp = Convert.ToString(Console.ReadLine());
            if (inp == "y")
                Console.WriteLine("Gg");
            else
            {
                Console.WriteLine();
                goto link1;
            }
        }
    }
}

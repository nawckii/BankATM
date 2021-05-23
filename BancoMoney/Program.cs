/*
 Challenge: create a program who simulate a ATM, someone gives a price and the program will return the value in 1, 2, 5, 10, 25, 50, 100 $
 */
using System;

namespace BancoMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 0;
            try
            {
                Console.Write("enter the amount to be withdrawn: ");
                money = Convert.ToInt32(Console.ReadLine());
                if (money < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Something wrong, try again!");
                return ;
            }
            int v1=0,v2=0,v5=0,v10=0,v25=0,v50=0,v100 = 0;
            while((v1+(v2*2)+(v5*5)+(v10*10)+(v25*25)+(v50*50)+(v100*100)) < money)
            {
                v1++;
                if(v1 == 2)
                {
                    v1-=2;
                    v2++;

                }
                if(v2 == 2 && v1 == 1)
                {
                    v2-=2;
                    v1--;
                    v5++;
                }
                if (v5 == 2)
                {
                    v5-=2;
                    v10++;

                }
                if (v10 == 2 && v5 == 1)
                {
                    v10-=2;v5--;
                    v25++;
                }
                if (v25 == 2)
                {
                    v25-=2;
                    v50++;
                }
                if(v50 == 2)
                {
                    v50-=2;
                    v100++;
                }
            }
            Console.WriteLine("note | amount");
            Console.WriteLine(" 1\t {0}\n 2\t {1}\n 5\t {2}\n 10\t {3}\n 25\t {4}\n 50\t {5}\n 100\t {6}\ntotal = {7}", v1,v2,v5,v10,v25,v50,v100, (v1 + (v2 * 2) + (v5 * 5) + (v10 * 10) + (v25 * 25) + (v50 * 50) + (v100 * 100)));
            
        }
    }
}

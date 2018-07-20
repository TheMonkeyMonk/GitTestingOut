using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis

{

    class Program
    {
       static int countDigits(string num)
        {
            int i = 0;
            int sum = 0;
            while(i<num.Length)
            {
                sum += int.Parse(num[i].ToString());
                i++;
            }

            return sum;
        }
        static void Main(string[] args)
        {

            int l = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int low = 0, high = 0;
            bool s = false;
            int checker = 0;
            for(int i = l;i<=d;i++)
            {
                if(countDigits(i.ToString())==x&&s==false)
                {
                    low = i;
                    s = true;
                }
                if (countDigits(i.ToString()) == x )
                {
                    high = i;
                }

            }

            Console.WriteLine(low);
            Console.WriteLine(high);


        }

    }
 
   }

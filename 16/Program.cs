using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no:");
            int a = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= a; i++) 

                    if(a % i ==0 )

                    Console.WriteLine("Prime No:"+i);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIO
{
    internal class age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            int agee = Convert.ToInt32((Console.ReadLine()));

            if (agee <= 20)
                Console.WriteLine("UNGDOMPRIS: 80 KR!");

            if (agee >= 64)
                Console.WriteLine("PENSIONÄRPRIS: 90 KR!");

            else if (agee >= 21 && agee <= 64)
                Console.WriteLine("STANDARTPRIS: 120 KR!");

            ;


        }

    }
}

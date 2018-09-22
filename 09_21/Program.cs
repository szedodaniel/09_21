using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg a darabszámot!");
            int db = Convert.ToInt32(Console.ReadLine());
            int[] t = new int[db];

            int max;
            int min;
           
            Console.WriteLine("Kérem adjon meg {0}db számot", db);



          


            for (int i = 0; i < db; i++)
            {
                t[i] = int.Parse(Console.ReadLine());
            }


            max = t[0];
            min = t[0];

            for (int i = 1; i < db; i++)
            {
                if (t[i] > max)
                {

                    max = t[i];
                }
                if (t[i] < min)
                    min = t[i];
               
            }




            Console.WriteLine("maximum érték: {0}, minimum érték: {1}", max, min);








            Console.ReadLine();
        }
    }
}

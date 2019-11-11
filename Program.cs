using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tar1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] a = new int[20];
            int[] b = new int[20];
            for (int i = 0; i < 40; i++)
                if (i > 19)
                    b[i - 20] = r.Next(18, 122);
                else a[i] = r.Next(18, 122);

            int[] c = new int[40];
            for (int j = 0; j < 20; j++)
            {
                if (a[j] > b[j])
                    c[j] = a[j] - b[j];
                else c[j] = b[j] - a[j];
            }

            for (int i = 0; i < 20; i++)
                Console.Write("{0,-5}", a[i]);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
                Console.Write("{0,-5}", b[i]);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
                Console.Write("{0,-5}", c[i]);


            Console.ReadKey();
        }

    }
}

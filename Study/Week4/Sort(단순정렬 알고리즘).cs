using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 1, 3, 2, 4 };

            Console.WriteLine("정렬 전 데이터");
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write("{0} ", a[k]);
            }
            Console.WriteLine("\n");

            int temp;

            for (int j = 0; j <= a.Length - 1; j++)
            {
                for (int i = j + 1; i <= a.Length - 1; i++)
                {
                    if (a[j] < a[i]){ //오름차순은 부등호 방향 반대로
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }

            Console.WriteLine("정렬 후 데이터");
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write("{0} ", a[k]);
            }
            Console.WriteLine("\n");
        }

    }
}
    

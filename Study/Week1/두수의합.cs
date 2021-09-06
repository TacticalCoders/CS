using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 두수의합
    {
        static void Main(string[] args)
        {
            int n1, n2, sum;

            Console.Write("첫 번째 정수 n1 입력:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("두 번째 정수 n2 입력:");
            n2 = Convert.ToInt32(Console.ReadLine());

            sum = n1 + n2;

            Console.WriteLine("{0}과 {1}의 합은 = {2}",n1 ,n2 ,sum);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 문자열합
    {
        static void Main(string[] args)
        {
            String s1 = "";
            String s2 = "";
            String sum;

            Console.WriteLine("첫 번째 문자열 입력:");
            s1 = Console.ReadLine();

            Console.WriteLine("두 번째 문자열 입력:");
            s2 = Console.ReadLine();

            sum = s1 + " " + s2;

            Console.Write("전체 문자열 -> ");
            Console.WriteLine(sum);
        }
    }
}

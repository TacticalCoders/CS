using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class RandomSu
    {
        static void Main(string[] args)
        {
            Random su = new Random();

            Console.WriteLine(su.Next()); //임의의 정수 발생.

            Console.WriteLine(su.Next(10)); // 0~9 사이의 임이의 정수 발생

            int a = su.Next(1, 10); // 1~9 사이의 정수 생성.,
            Console.WriteLine(a);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class Method_Sample
    {
        static void Main(string[] args)
        {
            Console.Write("사각형의 가로의 길이를 입력하세요 :");
            double w = Convert.ToInt32(Console.ReadLine());
            Console.Write("사각형의 세로의 길이를 입력하세요 :");
            double h = Convert.ToInt32(Console.ReadLine());

            int length = Convert.ToInt32(2 * (w + h));
            double Area = (w * h) / 2;

            Console.WriteLine("사각형의 둘레의 길이는 {0} 이고",length);
            Console.WriteLine("사각형 면적의 반은 {0} 이고",Area);

            if (w == h)
            {
                Console.WriteLine("정사각형이다.");
            }
            else
            {
                Console.WriteLine("직사각형이다.");
            }
        }
    }
}

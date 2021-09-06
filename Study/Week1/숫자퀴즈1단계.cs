using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 숫자퀴즈1단계
    {
        static void Main(string[] args)
        {
            int fix_su = 44;
            int input_su;
            int count = 0;

            while (true)
            {
                Console.Write("1부터 100사이 상대가 생각하고 있는 수를 입력하세요 :");
                input_su =  Convert.ToInt16(Console.ReadLine());
                count++;
                if(input_su < fix_su)
                {
                    Console.WriteLine("너무 작아!!");
                    continue;
                }
                else if(input_su > fix_su)
                {
                    Console.WriteLine("너무 커!!");
                    continue;
                }
                else if(input_su == fix_su)
                {
                    Console.WriteLine("정답!");
                    Console.WriteLine("시도횟수:{0}",count);
                    break;
                }
            }

        }
    }
}

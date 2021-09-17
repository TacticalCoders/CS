using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class 가위바위보_1단계
    {
        static void Main(string[] args)
        {
            Console.Write("컴퓨터와 가위바위보 게임(가위=1, 바위=2, 보=3):");
            int input = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int com = random.Next(1, 4);
            
            if(input==com)
                Console.WriteLine("비겼습니다.");   
            else if( (com  == input + 1) || (input -2 == com) )
                Console.WriteLine("졌습니다.");
            else if ((input == com + 1) || (com - 2 == input))
                Console.WriteLine("이겼습니다.");

            Console.WriteLine("컴퓨터는 {0}을 냈습니다.", com);
        }
    }
}

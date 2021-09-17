using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class 가위바위보_메소드
    {
        static int com1 = 0, com2 = 0, com3 = 0;
        static int win = 0, lose = 0, draw = 0;

        public static void countCom(int com){
            switch (com)
            {
                case 1: com1++; break;
                case 2: com2++; break;
                case 3: com3++; break;
            }
        }

        public static int isWin(int input, int com)
        {
            if (input == com)
            {
                Console.WriteLine("비겼습니다.");
                draw++;
                return 2;
            }
            else if ((com == input + 1) || (input - 2 == com))
            {
                Console.WriteLine("졌습니다.");
                lose++;
                return 0;
            }
            else if ((input == com + 1) || (com - 2 == input))
            {
                Console.WriteLine("이겼습니다.");
                win++;
                return 1;
            }

            return 4;
        }

        public static void Result()
        {
            Console.WriteLine("컴퓨터는 가위를 {0}회, 바위를 {1}회, 보를 {2}회 냈습니다.", com1, com2, com3);
            Console.WriteLine("승리 {0}회, 패배 {1}회, 무승부 {2}회", win, lose, draw);
        }

    }

    
}

ystem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class 가위바위보_3단계
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();

            while (true)
            {
                Console.Write("컴퓨터와 가위바위보 게임(가위=1, 바위=2, 보=3):");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1) break;

                int com = random.Next(1, 4);
                가위바위보_메소드.countCom(com);

                int showbu = 가위바위보_메소드.isWin(input, com);
                switch (showbu)
                {
                    case 1: Console.WriteLine("이겼습니다."); break;
                    case 0: Console.WriteLine("졌습니다."); break;
                    case 2: Console.WriteLine("비겼습니다."); break;
                    default: Console.WriteLine("잘못된 값이 입력되었습니다. 다시 입력해주세요"); continue;
                }

                Console.WriteLine("컴퓨터는 {0}을 냈습니다.", com);
                Console.WriteLine("-----------------------------------------------------");
            }

            가위바위보_메소드.Result();

        }
    }
}

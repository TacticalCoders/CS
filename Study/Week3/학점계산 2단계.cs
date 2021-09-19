using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class 학점계산_2단계
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("점수를 입력(종료: -999):");
                int score = Convert.ToInt32(Console.ReadLine());
                if (score == -999) break;
                String result = hakjum(score);
                Console.WriteLine(result);
            }
        }

        static String hakjum(int score)
        {
            switch (score / 10)
            {
                case 10:
                case 9: return "학점은 A" ; break;
                case 8: return "학점은 B" ; break;
                case 7: return "학점은 C" ; break;
                case 6: return "학점은 D" ; break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0: return "학점은 F"   ; break;
                default: return "점수 범위 초과 됨"; break;
            }
        }
    }
    
}

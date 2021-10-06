using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 성적처리_1단계
    {
        static void Main(string[] args)
        {
            int[,] jumsuData = new int[4, 7] { { 1, 33,44,55, 0, 0, 0 },
                                               { 2, 77, 88, 99, 0, 0, 0 },
                                               { 3, 55, 66, 77, 0, 0, 0 },
                                               { 4, 87, 88, 89, 0, 0, 0 } };

            Console.WriteLine("학번\t국어\t영어\t수학\t총점\t평균\t석차");
            Console.WriteLine("=====================================================");
            for (int i = 0; i < jumsuData.GetLength(0); i++)
            {
                for(int j = 0; j < jumsuData.GetLength(1); j++)
                {
                    if (j>0 && j < 4)
                        jumsuData[i, 4] += jumsuData[i, j];
                    else if (j == 4)
                        jumsuData[i, 5] = jumsuData[i, 4] / 3;

                    Console.Write("{0}\t",jumsuData[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}

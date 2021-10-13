//석차추가.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 성적처리_2단계
    {
        static void Main(string[] args)
        {
            int[,] jumsuData = new int[4, 7] { { 1, 33, 44, 55, 0, 0, 0 },
                                               { 2, 77, 88, 99, 0, 0, 0 },
                                               { 3, 55, 66, 77, 0, 0, 0 },
                                               { 4, 87, 88, 89, 0, 0, 0 } };

            string[] name = new string[] { "KBS", "SBS", "YTN", "MBC" };


            int[] sukcha = new int[4] { 0, 0, 0, 0 }; // 인덱스 순서대로.
            int[] order = new int[4] { 0, 0, 0, 0 };

            int sum = 0;

            for(int i = 0; i <jumsuData.GetLength(0); i++)
            {
                for(int j = 1; j <jumsuData.GetLength(1)-3; j++)
                {
                    sum += jumsuData[i, j];
                }
                jumsuData[i, 4] = sum; //총점
                jumsuData[i, 5] = sum / 3; //평균
                order[i] = sum;
                sum = 0;
            }

            //석차.
            //총점/평균 순서로 나열.(버블 정렬 사용)

            int temp;
            for(int k = 0; k < order.Length-1; k++) {
                for (int i = 0; i < order.Length - (k+1); i++)
                {
                    if (order[i] <= order[i + 1]) //큰 순서대로 정렬.
                    {
                        temp = order[i];
                        order[i] = order[i + 1];
                        order[i + 1] = temp;
                    }
                }
            }
            
            //ex 264 264 198 132 

            for(int i = 0; i < sukcha.Length; i++)
            {
                for(int k = 0; k < order.Length; k++)
                {
                    if(jumsuData[i, 4] == order[k])
                    {
                        if( k > 0 && (order[k] == order[k - 1]))
                        {
                            sukcha[i] = k;
                        }
                        else 
                          sukcha[i] = k + 1;               
                    }
                }
            }



            Console.WriteLine("학번\t이름\t국어\t영어\t수학\t총점\t평균\t석차");
            Console.WriteLine("============================================================");
            for (int i = 0; i < jumsuData.GetLength(0); i++)
            {
                for (int j = 0; j < jumsuData.GetLength(1); j++)
                {
                    
                    if (j == 1) Console.Write(name[i]+"\t");

                    if (j == 6) jumsuData[i, j] = sukcha[i];

                    Console.Write("{0}\t", jumsuData[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}

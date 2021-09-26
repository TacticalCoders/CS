using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 10,20,30,0}, { 40,50,60,0} };
            //int[,] arr = { { 10, 20, 30, 0 }, { 40, 50, 60, 0 } };

            for(int i = 0; i < arr.GetLength(0); i++) //GetLength(x) : 차원 x의 요소 수를 반환 -> 2  
            {
                for(int k = 0; k < arr.GetLength(1); k++)
                {
                    Console.Write( "{0}\t", arr[i,k]);
                    if (k == arr.GetLength(1) - 1) continue;
                    arr[i, arr.GetLength(1) - 1] += arr[i, k];
                }
                Console.WriteLine();
            }

        }
    }

}

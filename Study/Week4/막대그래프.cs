using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 막대그래프
    {
        static void Main(string[] args)
        {
            string[] name = { "김서방", "나서방", "다서방", "라서방", "마서방", "바서방" };
            int[] score = { 66, 77, 99, 55, 88, 75 };
            string[] graph = { "*", "*", "*", "*", "*", "*" };
            char[] grade = { 'A', 'A', 'A', 'A', 'A', 'A' };

            //메소드로 구현해보자.
            string temp = "";
            for(int k = 0; k < grade.Length; k++)
            {
                grade[k] = getGrade(score[k]);
                for(int j = 0; j < score[k]/10; j++)
                {
                    temp += "*";
                }
                graph[k] = temp;
                temp = "";
            }

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}",name[i], score[i], graph[i],grade[i]);
            }
        }

        static char getGrade(int score)
        {
            if (score >= 90) return 'A';
            else if (score >= 80) return 'B';
            else if (score >= 70) return 'C';
            else if (score >= 60) return 'D';
            else return 'F';
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 강병하_랜덤시험문제
{
    public partial class 랜덤넘버발생 : Form
    {
        public int[] randQuestion = new int[3];
        public int[] randBogi = new int[4];
        string Qhistory = "";
        string Bhistory = "";
        int QuestionIndex = 0, BogiIndex = 0;
        Random rand = new Random();

        public 랜덤넘버발생()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = makeRandQuestion();
            label6.Text = getQuestionStr();
            label7.Text = makeRandBogi();
            label8.Text = getBogiStr();
        }
        private bool isSameQ(int i, int value )
        {
            for(int j = 0; j < i; j++)
                if (randQuestion[j] == value) return true;
            return false;
        }
        private bool isSameB(int i, int value )
        {
            for (int j = 0; j < i; j++)
                if (randBogi[j] == value) return true;
            return false;
        }
        public string makeRandQuestion()
        {
            Qhistory = "";
            QuestionIndex = 0;
            for (int i = 0; QuestionIndex != 3; i++)
            {
                randQuestion[i] = rand.Next(5); //일단 추가
                Qhistory = Qhistory + Convert.ToString(randQuestion[i]) + " ";

                //지금까지 추가된 원소 중 중복이 발생하면 
                if (isSameQ(i, randQuestion[i])) i--;
                else QuestionIndex++;
            }

            return Qhistory;
        }
        public string makeRandBogi()
        {
            Bhistory = "";
            BogiIndex = 0;
            for (int m = 0; BogiIndex != 4; m++)
            {
                randBogi[m] = rand.Next(1,5); //일단 추가
                Bhistory = Bhistory + Convert.ToString(randBogi[m]) + " ";

                //지금까지 추가된 원소 중 중복이 발생하면 
                if (isSameB(m, randBogi[m])) m--;
                else BogiIndex++;

            }
            return Bhistory;
        }
        public string getQuestionStr()
        {
            string questionResult = "";
            for (int k = 0; k < randQuestion.Length; k++)
            {
                questionResult = questionResult + Convert.ToString(randQuestion[k]) + " ";
            }
            return questionResult;
        }
        public string getBogiStr()
        {
            string bogiResult = "";
            for (int p = 0; p < randBogi.Length; p++)
            {
                bogiResult = bogiResult + Convert.ToString(randBogi[p]) + " ";
            }
            return bogiResult;
        }
    }
}
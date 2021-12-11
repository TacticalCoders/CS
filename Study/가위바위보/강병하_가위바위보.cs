using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 가위바위보;

namespace 강병하_가위바위보게임
{
    public partial class 강병하_가위바위보 : Form
    {
        //*가위바위보.dll의 '게임' 클래스 내부*에서 게임 결과 데이터를 저장하도록 구현했습니다!

        게임 game = new 게임(); //게임 시작과 동시에 생성자로 인스턴스 생성. 

        public 강병하_가위바위보()
        {
            InitializeComponent();
            updateData();
        }

        bool result_view;

        private void btnGawei_Click(object sender, EventArgs e)
        {
            int my_num = 1;
            pb2.ImageLocation = "Images/gawei.jpg";

            game.user_num = my_num;
            game.com_num = game.getComNum(); //랜덤으로 컴퓨터 난수 발생.
            switch (game.com_num) { 
                case 1: pb1.ImageLocation = "Images/gawei.jpg"; break;
                case 2: pb1.ImageLocation = "Images/bawei.jpg"; break;
                case 3: pb1.ImageLocation = "Images/bo.jpg"; break;
            }
            lbResult.Text = game.whoWin();
            updateData();


        }

        private void btnBawei_Click(object sender, EventArgs e)
        {
            int my_num = 2;
            pb2.ImageLocation = "Images/bawei.jpg";

            game.user_num = my_num;
            game.com_num = game.getComNum(); //랜덤으로 컴퓨터 난수 발생.
            switch (game.com_num)
            {
                case 1: pb1.ImageLocation = "Images/gawei.jpg"; break;
                case 2: pb1.ImageLocation = "Images/bawei.jpg"; break;
                case 3: pb1.ImageLocation = "Images/bo.jpg"; break;
            }
            lbResult.Text = game.whoWin();
            updateData();
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            int my_num = 3;
            pb2.ImageLocation = "Images/bo.jpg";

            game.user_num = my_num;
            game.com_num = game.getComNum(); //랜덤으로 컴퓨터 난수 발생.
            switch (game.com_num)
            {
                case 1: pb1.ImageLocation = "Images/gawei.jpg"; break;
                case 2: pb1.ImageLocation = "Images/bawei.jpg"; break;
                case 3: pb1.ImageLocation = "Images/bo.jpg"; break;
            }
            lbResult.Text = game.whoWin();
            updateData();
        }

        private void btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();
        }

        private void Timer_View_Result_Tick(object sender, EventArgs e)
        {
            int size = 20;
            if (!result_view)
            {
                if (Width >= MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    result_view = true;
                    btn_View_Result.Text = "결과 접기 ◀";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            else
            {
                if (Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    result_view = false;
                    btn_View_Result.Text = "결과 보기 ▶";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width -= size;
                }
            }


        }

        private void updateData()
        {
            lb_Me_Score.Text = "내가 이긴 횟수  : " + Convert.ToString(game.getWin()) + "번";
            lb_Com_Score.Text = "컴퓨터가 이긴 횟수  : " + Convert.ToString(game.getLose()) + "번";
            lb_Draw_Score.Text = "서로 비긴 횟수 : " + Convert.ToString(game.getDraw()) + "번";
            lb_Total_Count.Text = "총 " + Convert.ToString(game.getGameCount()) + "번의 게임을 진행하였습니다.";

            lb_Me_S.Text = "가위횟수 : " + Convert.ToString(game.getUser1());
            lb_Me_R.Text = "바위횟수 : " + Convert.ToString(game.getUser2());
            lb_Me_P.Text = "보 횟수 : " + Convert.ToString(game.getUser3());

            lb_Com_S.Text = "가위횟수 : " + Convert.ToString(game.getCom1());
            lb_Com_R.Text = "바위횟수 : " + Convert.ToString(game.getCom2());
            lb_Com_P.Text = "보 횟수 : " + Convert.ToString(game.getCom3());

        }
    }
}

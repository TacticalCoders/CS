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
    public partial class 강병하_랜덤시험문제 : Form
    {
        GroupBox[] GB = new GroupBox[5]; // 그룹 박스 -2문제
        RadioButton[,] Bogi = new RadioButton[5, 5];  // 보기 -5개
        Label[] Quiz = new Label[2];            // 2 문제
        Label lbScore = new Label();     // 점수 표시 Label  
        Label lbBefore = new Label();
        Label lbBeforeArr = new Label();
        Label lbAfter = new Label();
        Label lbAfterArr = new Label();
        Button button = new Button();  // Button 
        int Score = 0;   // 점수 변수
       
        랜덤넘버발생 rand = new 랜덤넘버발생();

        public 강병하_랜덤시험문제()
        {
            InitializeComponent();

            string QuestionStr = "[문제 ";   // 1]  은 소스에서 추가 해야 함
            string[,] Question = new string[5, 6] {
               {"축구선수 손흥민의 소속팀은?","바르셀로나","살케04","토트넘","리버풀","토트넘" },
               {"인천대학교의 설립년도는?","1975년","1979년","1983년" ,"1987년","1979년" },
               {"니체가 쓴 책이 아닌 것은?","방법서설","선악의 저편","도덕의 계보학" ,"차라투스트라는 이렇게 말했다.","방법서설" },
               {"이 동물의 이름은?","캥거루","코알라","쿼카" ,"청설모","쿼카" }, //질문이 사진, 보기가 text
               {"다음 중 영화 <타이타닉>에 출연한 배우는?","디카프리오","브래드피트","톰 크루즈" ,"조니뎁","디카프리오" } //질문이 text, 보기가 사진.
            };

            // 중복 제거 전 라벨 동적생성.
            lbBefore.Name = "lbBefore";
            lbBefore.Text = "중복제거 전 문제";
            lbBefore.Size = new System.Drawing.Size(130, 30);
            lbBefore.Location = new System.Drawing.Point(370, 200);
            this.Controls.Add(lbBefore);

            // 랜덤으로 선택된 문제 인덱스 라벨(중복 제거 전).
            lbBeforeArr.Name = "lbBeforeArr";
            lbBeforeArr.Text = rand.makeRandQuestion();
            lbBeforeArr.Size = new System.Drawing.Size(150, 30);
            lbBeforeArr.Location = new System.Drawing.Point(370, 250);
            this.Controls.Add(lbBeforeArr);

            // 중복제거 후 라벨 동적생성.
            lbAfter.Name = "lbAfter";
            lbAfter.Text = "중복제거 후 문제";
            lbAfter.Size = new System.Drawing.Size(130, 30);
            lbAfter.Location = new System.Drawing.Point(370, 300);
            this.Controls.Add(lbAfter);

            // 랜덤으로 선택된 문제 인덱스 라벨.
            lbAfterArr.Name = "lbBeforeArr";
            lbAfterArr.Text = rand.getQuestionStr();
            lbAfterArr.Size = new System.Drawing.Size(150, 30);
            lbAfterArr.Location = new System.Drawing.Point(370, 350);
            this.Controls.Add(lbAfterArr);


            //점수 표시 라벨 동적생성.
            lbScore.Name = "lbScore";
            lbScore.Text = "Score";
            lbScore.Size = new System.Drawing.Size(90, 30);
            lbScore.Location = new System.Drawing.Point(300, 600);
            this.Controls.Add(lbScore);

            //채점 버튼 동적생성.
            button.Name = "btnSubmit";
            button.Text = "채점하기";
            button.Size = new System.Drawing.Size(90, 30);
            button.Location = new System.Drawing.Point(30, 600);
            button.Click += new EventHandler(button_Click);
            this.Controls.Add(button);

            int randQi = 0, randBi = 0, nextPosition = 0;
            for (int n = 0; n < rand.randQuestion.Length; n++)
            {
                GB[n] = new GroupBox();
                GB[n].Location = new System.Drawing.Point(10, 10 + nextPosition);
                if (rand.randQuestion[randQi] == 4) { GB[n].Size = new System.Drawing.Size(320, 220); nextPosition += 230; }
                else { GB[n].Size = new System.Drawing.Size(320, 150); nextPosition += 160;}
                GB[n].TabIndex = 0;
                GB[n].TabStop = false;
                GB[n].Text = QuestionStr + (n + 1) + "] " + Question[rand.randQuestion[randQi],0]; randQi++;
                this.Controls.Add(GB[n]);

                rand.makeRandBogi(); //보기 랜덤.
                randBi = 0;
                for (int i =0; i < 5; i++)
                {

                    if (i == 4)
                    {
                        Bogi[n, i] = new RadioButton();
                        Bogi[n, i].Location = new System.Drawing.Point(30, 30 + (i * 20));
                        Bogi[n, i].Size = new System.Drawing.Size(100, 20);
                        Bogi[n, i].Text = Question[rand.randQuestion[randQi - 1], 5]; //정답 데이터.
                        Bogi[n, i].Visible = false;

                    }
                    else { 

                        if(rand.randQuestion[randQi-1] == 3) //질문이 사진, 보기가 text -> 사진 추가 후 오른쪽에 보기 위치.
                        {
                            //사진 추가.
                            PictureBox pb = new PictureBox();
                            pb.Image = global::강병하_랜덤시험문제.Properties.Resources.quaka;
                            pb.Location = new System.Drawing.Point(20, 30);
                            pb.Name = "pictureBox1";
                            pb.Size = new System.Drawing.Size(100, 110);
                            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                            pb.TabIndex = 1;
                            pb.TabStop = false;
                            GB[n].Controls.Add(pb);

                            Bogi[n, i] = new RadioButton();
                            Bogi[n, i].Location = new System.Drawing.Point(150, 30 + (i * 25));
                            Bogi[n, i].Size = new System.Drawing.Size(100, 20);
                            Bogi[n, i].Text = Question[rand.randQuestion[randQi - 1], rand.randBogi[randBi]]; randBi++;
                            this.Controls.Add(Bogi[n, i]);
                            GB[n].Controls.Add(this.Bogi[n, i]);
                        }
                        else if(rand.randQuestion[randQi - 1] == 4) //질문이 text, 보기가 사진 -> 보기에 text속성을 주지 않고 사진을 지정. 
                        {
                            if (i <= 1)
                            {
                                Bogi[n, i] = new RadioButton();
                                Bogi[n, i].Location = new System.Drawing.Point(30, 60 + (i * 90));
                                Bogi[n, i].Size = new System.Drawing.Size(20, 20);
                                Bogi[n, i].Text = Question[rand.randQuestion[randQi - 1],i+1];
                                this.Controls.Add(Bogi[n, i]);
                                GB[n].Controls.Add(this.Bogi[n, i]);

                                if(i == 0) { 
                                    PictureBox pb = new PictureBox();
                                    pb.Image = global::강병하_랜덤시험문제.Properties.Resources._1;
                                    pb.Location = new System.Drawing.Point(50, 40 + (i * 90));
                                    pb.Name = "pictureBox1";
                                    pb.Size = new System.Drawing.Size(70, 80);
                                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                    pb.TabIndex = 1;
                                    pb.TabStop = false;
                                    GB[n].Controls.Add(pb);
                                }
                                else if(i == 1)
                                {
                                    PictureBox pb = new PictureBox();
                                    pb.Image = global::강병하_랜덤시험문제.Properties.Resources._2;
                                    pb.Location = new System.Drawing.Point(50, 40 + (i * 90));
                                    pb.Name = "pictureBox1";
                                    pb.Size = new System.Drawing.Size(70, 80);
                                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                    pb.TabIndex = 1;
                                    pb.TabStop = false;
                                    GB[n].Controls.Add(pb);
                                }
                            }
                            else
                            {
                                Bogi[n, i] = new RadioButton();
                                Bogi[n, i].Location = new System.Drawing.Point(165, 60 + ( (i-2) * 90));
                                Bogi[n, i].Size = new System.Drawing.Size(20, 20);
                                Bogi[n, i].Text = Question[rand.randQuestion[randQi - 1], i+1];
                                this.Controls.Add(Bogi[n, i]);
                                GB[n].Controls.Add(this.Bogi[n, i]);
                                if (i == 2) { 
                                    PictureBox pb = new PictureBox();
                                    pb.Image = global::강병하_랜덤시험문제.Properties.Resources._3;
                                    pb.Location = new System.Drawing.Point(185, 40 + ((i - 2) * 90));
                                    pb.Name = "pictureBox1";
                                    pb.Size = new System.Drawing.Size(70, 80);
                                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                    pb.TabIndex = 1;
                                    pb.TabStop = false;
                                    GB[n].Controls.Add(pb);
                                }
                                else if (i == 3)
                                {
                                    PictureBox pb = new PictureBox();
                                    pb.Image = global::강병하_랜덤시험문제.Properties.Resources._4;
                                    pb.Location = new System.Drawing.Point(185, 40 + ((i - 2) * 90));
                                    pb.Name = "pictureBox1";
                                    pb.Size = new System.Drawing.Size(70, 80);
                                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                    pb.TabIndex = 1;
                                    pb.TabStop = false;
                                    GB[n].Controls.Add(pb);
                                }
                            }

                            
                        }
                        else
                        {
                            Bogi[n, i] = new RadioButton();
                            Bogi[n, i].Location = new System.Drawing.Point(30, 30 + (i * 25));
                            Bogi[n, i].Size = new System.Drawing.Size(100, 20);
                            Bogi[n, i].Text = Question[rand.randQuestion[randQi - 1], rand.randBogi[randBi]]; randBi++;
                            this.Controls.Add(Bogi[n, i]);
                            GB[n].Controls.Add(this.Bogi[n, i]);
                        }
                    }
                }
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            //채점하기 버튼 이벤트 처리.
            Score = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if ( (Bogi[i, k].Checked == true) && (Bogi[i, k].Text == Bogi[i, 4].Text) )
                    {
                        Score++;
                    }
                }
            }
            lbScore.Text = "Score : " + Convert.ToString(Score) + "점";
        }
    }
}

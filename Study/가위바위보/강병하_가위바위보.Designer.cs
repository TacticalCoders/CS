
namespace 강병하_가위바위보게임
{
    partial class 강병하_가위바위보
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(강병하_가위바위보));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.lbCOM = new System.Windows.Forms.Label();
            this.lbME = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnGawei = new System.Windows.Forms.Button();
            this.btnBawei = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.Timer_View_Result = new System.Windows.Forms.Timer(this.components);
            this.btn_View_Result = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Me_Score = new System.Windows.Forms.Label();
            this.lb_Com_Score = new System.Windows.Forms.Label();
            this.lb_Draw_Score = new System.Windows.Forms.Label();
            this.lb_Total_Count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Me_S = new System.Windows.Forms.Label();
            this.lb_Me_R = new System.Windows.Forms.Label();
            this.lb_Me_P = new System.Windows.Forms.Label();
            this.lb_Com_S = new System.Windows.Forms.Label();
            this.lb_Com_R = new System.Windows.Forms.Label();
            this.lb_Com_P = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(60, 10);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(110, 90);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(60, 106);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(110, 90);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // lbCOM
            // 
            this.lbCOM.AutoSize = true;
            this.lbCOM.Location = new System.Drawing.Point(20, 50);
            this.lbCOM.Name = "lbCOM";
            this.lbCOM.Size = new System.Drawing.Size(17, 12);
            this.lbCOM.TabIndex = 2;
            this.lbCOM.Text = "컴";
            // 
            // lbME
            // 
            this.lbME.AutoSize = true;
            this.lbME.Location = new System.Drawing.Point(20, 146);
            this.lbME.Name = "lbME";
            this.lbME.Size = new System.Drawing.Size(17, 12);
            this.lbME.TabIndex = 3;
            this.lbME.Text = "나";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbResult.ForeColor = System.Drawing.Color.Blue;
            this.lbResult.Location = new System.Drawing.Point(19, 215);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(33, 13);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "결과";
            // 
            // btnGawei
            // 
            this.btnGawei.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGawei.ForeColor = System.Drawing.Color.Red;
            this.btnGawei.Image = ((System.Drawing.Image)(resources.GetObject("btnGawei.Image")));
            this.btnGawei.Location = new System.Drawing.Point(12, 263);
            this.btnGawei.Name = "btnGawei";
            this.btnGawei.Size = new System.Drawing.Size(100, 80);
            this.btnGawei.TabIndex = 5;
            this.btnGawei.Text = "1";
            this.btnGawei.UseVisualStyleBackColor = true;
            this.btnGawei.Click += new System.EventHandler(this.btnGawei_Click);
            // 
            // btnBawei
            // 
            this.btnBawei.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBawei.ForeColor = System.Drawing.Color.Red;
            this.btnBawei.Image = ((System.Drawing.Image)(resources.GetObject("btnBawei.Image")));
            this.btnBawei.Location = new System.Drawing.Point(127, 263);
            this.btnBawei.Name = "btnBawei";
            this.btnBawei.Size = new System.Drawing.Size(100, 80);
            this.btnBawei.TabIndex = 6;
            this.btnBawei.Text = "2";
            this.btnBawei.UseVisualStyleBackColor = true;
            this.btnBawei.Click += new System.EventHandler(this.btnBawei_Click);
            // 
            // btnBo
            // 
            this.btnBo.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBo.ForeColor = System.Drawing.Color.Red;
            this.btnBo.Image = ((System.Drawing.Image)(resources.GetObject("btnBo.Image")));
            this.btnBo.Location = new System.Drawing.Point(242, 263);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(100, 80);
            this.btnBo.TabIndex = 7;
            this.btnBo.Text = "3";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // Timer_View_Result
            // 
            this.Timer_View_Result.Tick += new System.EventHandler(this.Timer_View_Result_Tick);
            // 
            // btn_View_Result
            // 
            this.btn_View_Result.Location = new System.Drawing.Point(220, 146);
            this.btn_View_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_Result.Name = "btn_View_Result";
            this.btn_View_Result.Size = new System.Drawing.Size(87, 27);
            this.btn_View_Result.TabIndex = 8;
            this.btn_View_Result.Text = "결과보기";
            this.btn_View_Result.UseVisualStyleBackColor = true;
            this.btn_View_Result.Click += new System.EventHandler(this.btn_View_Result_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lb_Com_P);
            this.groupBox1.Controls.Add(this.lb_Com_R);
            this.groupBox1.Controls.Add(this.lb_Com_S);
            this.groupBox1.Controls.Add(this.lb_Me_P);
            this.groupBox1.Controls.Add(this.lb_Me_R);
            this.groupBox1.Controls.Add(this.lb_Me_S);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_Total_Count);
            this.groupBox1.Controls.Add(this.lb_Draw_Score);
            this.groupBox1.Controls.Add(this.lb_Com_Score);
            this.groupBox1.Controls.Add(this.lb_Me_Score);
            this.groupBox1.Location = new System.Drawing.Point(365, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 331);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "게임결과";
            // 
            // lb_Me_Score
            // 
            this.lb_Me_Score.AutoSize = true;
            this.lb_Me_Score.Location = new System.Drawing.Point(18, 28);
            this.lb_Me_Score.Name = "lb_Me_Score";
            this.lb_Me_Score.Size = new System.Drawing.Size(85, 12);
            this.lb_Me_Score.TabIndex = 0;
            this.lb_Me_Score.Text = "내가 이긴 횟수";
            // 
            // lb_Com_Score
            // 
            this.lb_Com_Score.AutoSize = true;
            this.lb_Com_Score.Location = new System.Drawing.Point(18, 59);
            this.lb_Com_Score.Name = "lb_Com_Score";
            this.lb_Com_Score.Size = new System.Drawing.Size(85, 12);
            this.lb_Com_Score.TabIndex = 1;
            this.lb_Com_Score.Text = "컴이 이긴 횟수";
            // 
            // lb_Draw_Score
            // 
            this.lb_Draw_Score.AutoSize = true;
            this.lb_Draw_Score.Location = new System.Drawing.Point(18, 94);
            this.lb_Draw_Score.Name = "lb_Draw_Score";
            this.lb_Draw_Score.Size = new System.Drawing.Size(57, 12);
            this.lb_Draw_Score.TabIndex = 2;
            this.lb_Draw_Score.Text = "비긴 횟수";
            // 
            // lb_Total_Count
            // 
            this.lb_Total_Count.AutoSize = true;
            this.lb_Total_Count.Location = new System.Drawing.Point(18, 134);
            this.lb_Total_Count.Name = "lb_Total_Count";
            this.lb_Total_Count.Size = new System.Drawing.Size(73, 12);
            this.lb_Total_Count.TabIndex = 3;
            this.lb_Total_Count.Text = "총 게임 횟수";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 2);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "나";
            // 
            // lb_Me_S
            // 
            this.lb_Me_S.AutoSize = true;
            this.lb_Me_S.Location = new System.Drawing.Point(30, 232);
            this.lb_Me_S.Name = "lb_Me_S";
            this.lb_Me_S.Size = new System.Drawing.Size(53, 12);
            this.lb_Me_S.TabIndex = 6;
            this.lb_Me_S.Text = "가위횟수";
            // 
            // lb_Me_R
            // 
            this.lb_Me_R.AutoSize = true;
            this.lb_Me_R.Location = new System.Drawing.Point(31, 264);
            this.lb_Me_R.Name = "lb_Me_R";
            this.lb_Me_R.Size = new System.Drawing.Size(53, 12);
            this.lb_Me_R.TabIndex = 7;
            this.lb_Me_R.Text = "바위횟수";
            // 
            // lb_Me_P
            // 
            this.lb_Me_P.AutoSize = true;
            this.lb_Me_P.Location = new System.Drawing.Point(30, 299);
            this.lb_Me_P.Name = "lb_Me_P";
            this.lb_Me_P.Size = new System.Drawing.Size(45, 12);
            this.lb_Me_P.TabIndex = 8;
            this.lb_Me_P.Text = "보 횟수";
            // 
            // lb_Com_S
            // 
            this.lb_Com_S.AutoSize = true;
            this.lb_Com_S.Location = new System.Drawing.Point(149, 232);
            this.lb_Com_S.Name = "lb_Com_S";
            this.lb_Com_S.Size = new System.Drawing.Size(53, 12);
            this.lb_Com_S.TabIndex = 9;
            this.lb_Com_S.Text = "가위횟수";
            // 
            // lb_Com_R
            // 
            this.lb_Com_R.AutoSize = true;
            this.lb_Com_R.Location = new System.Drawing.Point(149, 264);
            this.lb_Com_R.Name = "lb_Com_R";
            this.lb_Com_R.Size = new System.Drawing.Size(53, 12);
            this.lb_Com_R.TabIndex = 10;
            this.lb_Com_R.Text = "바위횟수";
            // 
            // lb_Com_P
            // 
            this.lb_Com_P.AutoSize = true;
            this.lb_Com_P.Location = new System.Drawing.Point(149, 299);
            this.lb_Com_P.Name = "lb_Com_P";
            this.lb_Com_P.Size = new System.Drawing.Size(45, 12);
            this.lb_Com_P.TabIndex = 11;
            this.lb_Com_P.Text = "보 횟수";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "컴";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(120, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(2, 140);
            this.label14.TabIndex = 13;
            // 
            // 강병하_가위바위보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_View_Result);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.btnBawei);
            this.Controls.Add(this.btnGawei);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbME);
            this.Controls.Add(this.lbCOM);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(370, 400);
            this.Name = "강병하_가위바위보";
            this.Text = "가위바위보";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lbCOM;
        private System.Windows.Forms.Label lbME;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnGawei;
        private System.Windows.Forms.Button btnBawei;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Timer Timer_View_Result;
        private System.Windows.Forms.Button btn_View_Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Total_Count;
        private System.Windows.Forms.Label lb_Draw_Score;
        private System.Windows.Forms.Label lb_Com_Score;
        private System.Windows.Forms.Label lb_Me_Score;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_Com_P;
        private System.Windows.Forms.Label lb_Com_R;
        private System.Windows.Forms.Label lb_Com_S;
        private System.Windows.Forms.Label lb_Me_P;
        private System.Windows.Forms.Label lb_Me_R;
        private System.Windows.Forms.Label lb_Me_S;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
    }
}


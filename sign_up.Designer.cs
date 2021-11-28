
namespace on_off_proj
{
    partial class sign_up
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_sign_up_ID = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_PW = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_Name = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_Nickname = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_Address = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_image_path = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_sing_up_save = new on_off_proj.RoundedButton();
            this.pictureBox_sign_up = new on_off_proj.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sign_up)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(60, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(60, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(60, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(60, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "별명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(60, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "PW";
            // 
            // textBox_sign_up_ID
            // 
            this.textBox_sign_up_ID.BackColor = System.Drawing.Color.White;
            this.textBox_sign_up_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sign_up_ID.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_sign_up_ID.Location = new System.Drawing.Point(104, 241);
            this.textBox_sign_up_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sign_up_ID.Name = "textBox_sign_up_ID";
            this.textBox_sign_up_ID.Size = new System.Drawing.Size(179, 24);
            this.textBox_sign_up_ID.TabIndex = 6;
            this.textBox_sign_up_ID.TextChanged += new System.EventHandler(this.textBox_sign_up_ID_TextChanged);
            // 
            // textBox_sign_up_PW
            // 
            this.textBox_sign_up_PW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sign_up_PW.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_sign_up_PW.Location = new System.Drawing.Point(104, 284);
            this.textBox_sign_up_PW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sign_up_PW.Name = "textBox_sign_up_PW";
            this.textBox_sign_up_PW.Size = new System.Drawing.Size(155, 14);
            this.textBox_sign_up_PW.TabIndex = 7;
            this.textBox_sign_up_PW.TextChanged += new System.EventHandler(this.textBox_sign_up_PW_TextChanged);
            // 
            // textBox_sign_up_Name
            // 
            this.textBox_sign_up_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sign_up_Name.Location = new System.Drawing.Point(104, 327);
            this.textBox_sign_up_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sign_up_Name.Name = "textBox_sign_up_Name";
            this.textBox_sign_up_Name.Size = new System.Drawing.Size(155, 14);
            this.textBox_sign_up_Name.TabIndex = 8;
            this.textBox_sign_up_Name.TextChanged += new System.EventHandler(this.textBox_sign_up_Name_TextChanged);
            // 
            // textBox_sign_up_Nickname
            // 
            this.textBox_sign_up_Nickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sign_up_Nickname.Location = new System.Drawing.Point(104, 370);
            this.textBox_sign_up_Nickname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sign_up_Nickname.Name = "textBox_sign_up_Nickname";
            this.textBox_sign_up_Nickname.Size = new System.Drawing.Size(155, 14);
            this.textBox_sign_up_Nickname.TabIndex = 9;
            // 
            // textBox_sign_up_Address
            // 
            this.textBox_sign_up_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sign_up_Address.Location = new System.Drawing.Point(104, 407);
            this.textBox_sign_up_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sign_up_Address.Name = "textBox_sign_up_Address";
            this.textBox_sign_up_Address.Size = new System.Drawing.Size(155, 14);
            this.textBox_sign_up_Address.TabIndex = 10;
            // 
            // textBox_sign_up_image_path
            // 
            this.textBox_sign_up_image_path.Location = new System.Drawing.Point(116, 93);
            this.textBox_sign_up_image_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sign_up_image_path.Name = "textBox_sign_up_image_path";
            this.textBox_sign_up_image_path.Size = new System.Drawing.Size(88, 21);
            this.textBox_sign_up_image_path.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(63, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 2);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(63, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 2);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(62, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 2);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(62, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 2);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(63, 427);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 2);
            this.panel5.TabIndex = 18;
            // 
            // button_sing_up_save
            // 
            this.button_sing_up_save.BackColor = System.Drawing.Color.LightCyan;
            this.button_sing_up_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_sing_up_save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_sing_up_save.FlatAppearance.BorderSize = 0;
            this.button_sing_up_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sing_up_save.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 15F, System.Drawing.FontStyle.Bold);
            this.button_sing_up_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_sing_up_save.Location = new System.Drawing.Point(93, 459);
            this.button_sing_up_save.Name = "button_sing_up_save";
            this.button_sing_up_save.Size = new System.Drawing.Size(150, 38);
            this.button_sing_up_save.TabIndex = 19;
            this.button_sing_up_save.Text = "sign up";
            this.button_sing_up_save.UseVisualStyleBackColor = false;
            this.button_sing_up_save.Click += new System.EventHandler(this.button_sing_up_save_Click);
            // 
            // pictureBox_sign_up
            // 
            this.pictureBox_sign_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_sign_up.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox_sign_up.Image = global::on_off_proj.Properties.Resources.유튜브_기본프로필_하늘색;
            this.pictureBox_sign_up.Location = new System.Drawing.Point(73, 18);
            this.pictureBox_sign_up.Name = "pictureBox_sign_up";
            this.pictureBox_sign_up.Size = new System.Drawing.Size(197, 196);
            this.pictureBox_sign_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_sign_up.TabIndex = 13;
            this.pictureBox_sign_up.TabStop = false;
            this.pictureBox_sign_up.Click += new System.EventHandler(this.pictureBox_sign_up_Click);
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 522);
            this.Controls.Add(this.button_sing_up_save);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_sign_up);
            this.Controls.Add(this.textBox_sign_up_Address);
            this.Controls.Add(this.textBox_sign_up_Nickname);
            this.Controls.Add(this.textBox_sign_up_Name);
            this.Controls.Add(this.textBox_sign_up_PW);
            this.Controls.Add(this.textBox_sign_up_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sign_up_image_path);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sign_up";
            this.Text = "sign_up";
            this.Load += new System.EventHandler(this.sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sign_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_sign_up_ID;
        private System.Windows.Forms.TextBox textBox_sign_up_PW;
        private System.Windows.Forms.TextBox textBox_sign_up_Name;
        private System.Windows.Forms.TextBox textBox_sign_up_Nickname;
        private System.Windows.Forms.TextBox textBox_sign_up_Address;
        private System.Windows.Forms.TextBox textBox_sign_up_image_path;
        private RoundPictureBox pictureBox_sign_up;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private RoundedButton button_sing_up_save;
    }
}


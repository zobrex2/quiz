namespace WindowsFormsApplication1
{
    partial class Form_G
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ASK_T = new System.Windows.Forms.Label();
            this.BTN_A1 = new System.Windows.Forms.Button();
            this.BTN_E = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.BTN_A3 = new System.Windows.Forms.Button();
            this.BTN_A2 = new System.Windows.Forms.Button();
            this.BTN_A4 = new System.Windows.Forms.Button();
            this.LBL_Q = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_TIMER = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ASK_T
            // 
            this.ASK_T.BackColor = System.Drawing.Color.Teal;
            this.ASK_T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ASK_T.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASK_T.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ASK_T.Location = new System.Drawing.Point(12, 165);
            this.ASK_T.Name = "ASK_T";
            this.ASK_T.Size = new System.Drawing.Size(760, 80);
            this.ASK_T.TabIndex = 0;
            this.ASK_T.Text = "My ask is here!";
            this.ASK_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ASK_T.Click += new System.EventHandler(this.ASK_T_Click);
            // 
            // BTN_A1
            // 
            this.BTN_A1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_A1.Font = new System.Drawing.Font("ChunkFive Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_A1.Location = new System.Drawing.Point(17, 328);
            this.BTN_A1.Name = "BTN_A1";
            this.BTN_A1.Size = new System.Drawing.Size(353, 81);
            this.BTN_A1.TabIndex = 5;
            this.BTN_A1.Text = "APADISI1";
            this.BTN_A1.UseVisualStyleBackColor = false;
            this.BTN_A1.Click += new System.EventHandler(this.BTN_A1_Click);
            this.BTN_A1.MouseEnter += new System.EventHandler(this.BTN_A1_MouseEnter);
            // 
            // BTN_E
            // 
            this.BTN_E.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_E.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_E.Location = new System.Drawing.Point(667, 610);
            this.BTN_E.Name = "BTN_E";
            this.BTN_E.Size = new System.Drawing.Size(110, 39);
            this.BTN_E.TabIndex = 7;
            this.BTN_E.Text = "EXIT";
            this.BTN_E.UseVisualStyleBackColor = false;
            this.BTN_E.Click += new System.EventHandler(this.BTN_E_Click);
            this.BTN_E.MouseEnter += new System.EventHandler(this.BTN_E_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 73);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 49);
            this.label1.TabIndex = 12;
            this.label1.Text = "GAMES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 610);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 39);
            this.button5.TabIndex = 13;
            this.button5.Text = "HOME";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            // 
            // BTN_A3
            // 
            this.BTN_A3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_A3.Font = new System.Drawing.Font("ChunkFive Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_A3.Location = new System.Drawing.Point(17, 415);
            this.BTN_A3.Name = "BTN_A3";
            this.BTN_A3.Size = new System.Drawing.Size(353, 81);
            this.BTN_A3.TabIndex = 14;
            this.BTN_A3.Text = "APADISI3";
            this.BTN_A3.UseVisualStyleBackColor = false;
            this.BTN_A3.Click += new System.EventHandler(this.BTN_A3_Click);
            this.BTN_A3.MouseEnter += new System.EventHandler(this.BTN_A3_MouseEnter);
            // 
            // BTN_A2
            // 
            this.BTN_A2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_A2.Font = new System.Drawing.Font("ChunkFive Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_A2.Location = new System.Drawing.Point(419, 328);
            this.BTN_A2.Name = "BTN_A2";
            this.BTN_A2.Size = new System.Drawing.Size(353, 81);
            this.BTN_A2.TabIndex = 15;
            this.BTN_A2.Text = "APADISI2";
            this.BTN_A2.UseVisualStyleBackColor = false;
            this.BTN_A2.Click += new System.EventHandler(this.BTN_A2_Click);
            this.BTN_A2.MouseEnter += new System.EventHandler(this.BTN_A2_MouseEnter);
            // 
            // BTN_A4
            // 
            this.BTN_A4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_A4.Font = new System.Drawing.Font("ChunkFive Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_A4.Location = new System.Drawing.Point(419, 415);
            this.BTN_A4.Name = "BTN_A4";
            this.BTN_A4.Size = new System.Drawing.Size(353, 81);
            this.BTN_A4.TabIndex = 16;
            this.BTN_A4.Text = "APADISI4";
            this.BTN_A4.UseVisualStyleBackColor = false;
            this.BTN_A4.Click += new System.EventHandler(this.BTN_A4_Click);
            this.BTN_A4.MouseEnter += new System.EventHandler(this.BTN_A4_MouseEnter);
            // 
            // LBL_Q
            // 
            this.LBL_Q.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Q.Font = new System.Drawing.Font("Broadway", 18F);
            this.LBL_Q.Location = new System.Drawing.Point(519, 126);
            this.LBL_Q.Name = "LBL_Q";
            this.LBL_Q.Size = new System.Drawing.Size(253, 39);
            this.LBL_Q.TabIndex = 17;
            this.LBL_Q.Text = "Question: 1 of 10";
            this.LBL_Q.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBL_TIMER
            // 
            this.LBL_TIMER.BackColor = System.Drawing.Color.Transparent;
            this.LBL_TIMER.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TIMER.Location = new System.Drawing.Point(677, 71);
            this.LBL_TIMER.Name = "LBL_TIMER";
            this.LBL_TIMER.Size = new System.Drawing.Size(100, 23);
            this.LBL_TIMER.TabIndex = 18;
            this.LBL_TIMER.Text = "00:00:00";
            this.LBL_TIMER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_G
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.quiz;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.LBL_TIMER);
            this.Controls.Add(this.LBL_Q);
            this.Controls.Add(this.BTN_A4);
            this.Controls.Add(this.BTN_A2);
            this.Controls.Add(this.BTN_A3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_E);
            this.Controls.Add(this.BTN_A1);
            this.Controls.Add(this.ASK_T);
            this.Name = "Form_G";
            this.Text = "Form_T";
            this.Load += new System.EventHandler(this.Form_T_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ASK_T;
        private System.Windows.Forms.Button BTN_A1;
        private System.Windows.Forms.Button BTN_E;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BTN_A3;
        private System.Windows.Forms.Button BTN_A2;
        private System.Windows.Forms.Button BTN_A4;
        private System.Windows.Forms.Label LBL_Q;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_TIMER;
    }
}
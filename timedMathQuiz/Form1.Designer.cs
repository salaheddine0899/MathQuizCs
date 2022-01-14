namespace timedMathQuiz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.prodLeftLabel = new System.Windows.Forms.Label();
            this.prodRightLabel = new System.Windows.Forms.Label();
            this.divLeftLabel = new System.Windows.Forms.Label();
            this.divRightLabel = new System.Windows.Forms.Label();
            this.sumRes = new System.Windows.Forms.NumericUpDown();
            this.subRes = new System.Windows.Forms.NumericUpDown();
            this.multRes = new System.Windows.Forms.NumericUpDown();
            this.divRes = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divRes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Location = new System.Drawing.Point(68, 91);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(35, 13);
            this.plusLeftLabel.TabIndex = 1;
            this.plusLeftLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "+";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Location = new System.Drawing.Point(151, 91);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(35, 13);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "=";
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = true;
            this.minusLeftLabel.Location = new System.Drawing.Point(68, 120);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(35, 13);
            this.minusLeftLabel.TabIndex = 5;
            this.minusLeftLabel.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "-";
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Location = new System.Drawing.Point(151, 120);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(35, 13);
            this.minusRightLabel.TabIndex = 7;
            this.minusRightLabel.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "/";
            // 
            // prodLeftLabel
            // 
            this.prodLeftLabel.AutoSize = true;
            this.prodLeftLabel.Location = new System.Drawing.Point(68, 148);
            this.prodLeftLabel.Name = "prodLeftLabel";
            this.prodLeftLabel.Size = new System.Drawing.Size(41, 13);
            this.prodLeftLabel.TabIndex = 13;
            this.prodLeftLabel.Text = "label14";
            // 
            // prodRightLabel
            // 
            this.prodRightLabel.AutoSize = true;
            this.prodRightLabel.Location = new System.Drawing.Point(151, 148);
            this.prodRightLabel.Name = "prodRightLabel";
            this.prodRightLabel.Size = new System.Drawing.Size(41, 13);
            this.prodRightLabel.TabIndex = 14;
            this.prodRightLabel.Text = "label15";
            // 
            // divLeftLabel
            // 
            this.divLeftLabel.AutoSize = true;
            this.divLeftLabel.Location = new System.Drawing.Point(68, 175);
            this.divLeftLabel.Name = "divLeftLabel";
            this.divLeftLabel.Size = new System.Drawing.Size(41, 13);
            this.divLeftLabel.TabIndex = 15;
            this.divLeftLabel.Text = "label16";
            // 
            // divRightLabel
            // 
            this.divRightLabel.AutoSize = true;
            this.divRightLabel.Location = new System.Drawing.Point(151, 175);
            this.divRightLabel.Name = "divRightLabel";
            this.divRightLabel.Size = new System.Drawing.Size(41, 13);
            this.divRightLabel.TabIndex = 16;
            this.divRightLabel.Text = "label17";
            // 
            // sumRes
            // 
            this.sumRes.Location = new System.Drawing.Point(277, 84);
            this.sumRes.Name = "sumRes";
            this.sumRes.Size = new System.Drawing.Size(120, 20);
            this.sumRes.TabIndex = 21;
            // 
            // subRes
            // 
            this.subRes.Location = new System.Drawing.Point(277, 113);
            this.subRes.Name = "subRes";
            this.subRes.Size = new System.Drawing.Size(120, 20);
            this.subRes.TabIndex = 22;
            // 
            // multRes
            // 
            this.multRes.Location = new System.Drawing.Point(277, 146);
            this.multRes.Name = "multRes";
            this.multRes.Size = new System.Drawing.Size(120, 20);
            this.multRes.TabIndex = 23;
            // 
            // divRes
            // 
            this.divRes.Location = new System.Drawing.Point(277, 172);
            this.divRes.Name = "divRes";
            this.divRes.Size = new System.Drawing.Size(120, 20);
            this.divRes.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Start Quiz !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_quiz);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(230, 26);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 294);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divRes);
            this.Controls.Add(this.multRes);
            this.Controls.Add(this.subRes);
            this.Controls.Add(this.sumRes);
            this.Controls.Add(this.divRightLabel);
            this.Controls.Add(this.divLeftLabel);
            this.Controls.Add(this.prodRightLabel);
            this.Controls.Add(this.prodLeftLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sumRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label prodLeftLabel;
        private System.Windows.Forms.Label prodRightLabel;
        private System.Windows.Forms.Label divLeftLabel;
        private System.Windows.Forms.Label divRightLabel;
        private System.Windows.Forms.NumericUpDown sumRes;
        private System.Windows.Forms.NumericUpDown subRes;
        private System.Windows.Forms.NumericUpDown multRes;
        private System.Windows.Forms.NumericUpDown divRes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
    }
}


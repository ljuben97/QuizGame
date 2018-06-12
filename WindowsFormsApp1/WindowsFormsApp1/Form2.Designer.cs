namespace WindowsFormsApp1
{
    partial class Form2
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
            this.anw1 = new System.Windows.Forms.Button();
            this.anws2 = new System.Windows.Forms.Button();
            this.answ3 = new System.Windows.Forms.Button();
            this.answ4 = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.lblKraj = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anw1
            // 
            this.anw1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.anw1.Location = new System.Drawing.Point(47, 267);
            this.anw1.Name = "anw1";
            this.anw1.Size = new System.Drawing.Size(219, 52);
            this.anw1.TabIndex = 0;
            this.anw1.Text = "button1";
            this.anw1.UseVisualStyleBackColor = false;
            this.anw1.Click += new System.EventHandler(this.anw1_Click);
            // 
            // anws2
            // 
            this.anws2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.anws2.Location = new System.Drawing.Point(448, 267);
            this.anws2.Name = "anws2";
            this.anws2.Size = new System.Drawing.Size(219, 52);
            this.anws2.TabIndex = 1;
            this.anws2.Text = "button2";
            this.anws2.UseVisualStyleBackColor = false;
            this.anws2.Click += new System.EventHandler(this.anws2_Click);
            // 
            // answ3
            // 
            this.answ3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.answ3.Location = new System.Drawing.Point(47, 366);
            this.answ3.Name = "answ3";
            this.answ3.Size = new System.Drawing.Size(219, 52);
            this.answ3.TabIndex = 2;
            this.answ3.Text = "button3";
            this.answ3.UseVisualStyleBackColor = false;
            this.answ3.Click += new System.EventHandler(this.answ3_Click);
            // 
            // answ4
            // 
            this.answ4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.answ4.Location = new System.Drawing.Point(448, 366);
            this.answ4.Name = "answ4";
            this.answ4.Size = new System.Drawing.Size(219, 52);
            this.answ4.TabIndex = 3;
            this.answ4.Text = "button4";
            this.answ4.UseVisualStyleBackColor = false;
            this.answ4.Click += new System.EventHandler(this.answ4_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuestion.Enabled = false;
            this.btnQuestion.Location = new System.Drawing.Point(47, 163);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(620, 69);
            this.btnQuestion.TabIndex = 4;
            this.btnQuestion.Text = "button1";
            this.btnQuestion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(548, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вкупно Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.BackColor = System.Drawing.Color.Transparent;
            this.lblPoeni.Location = new System.Drawing.Point(654, 24);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(13, 13);
            this.lblPoeni.TabIndex = 6;
            this.lblPoeni.Text = "0";
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKraj.Location = new System.Drawing.Point(61, 94);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(0, 26);
            this.lblKraj.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(620, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(296, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 58);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblKraj);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.answ4);
            this.Controls.Add(this.answ3);
            this.Controls.Add(this.anws2);
            this.Controls.Add(this.anw1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anw1;
        private System.Windows.Forms.Button anws2;
        private System.Windows.Forms.Button answ3;
        private System.Windows.Forms.Button answ4;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
    }
}
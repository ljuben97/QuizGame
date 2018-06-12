namespace WindowsFormsApp1
{
    partial class Form4
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
            this.btnQuizTime = new System.Windows.Forms.Button();
            this.btnQuizMillioner = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuizTime
            // 
            this.btnQuizTime.BackColor = System.Drawing.Color.White;
            this.btnQuizTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizTime.Location = new System.Drawing.Point(25, 182);
            this.btnQuizTime.Name = "btnQuizTime";
            this.btnQuizTime.Size = new System.Drawing.Size(162, 46);
            this.btnQuizTime.TabIndex = 0;
            this.btnQuizTime.Text = "Квиз на време";
            this.btnQuizTime.UseVisualStyleBackColor = false;
            this.btnQuizTime.Click += new System.EventHandler(this.btnQuizTime_Click);
            // 
            // btnQuizMillioner
            // 
            this.btnQuizMillioner.BackColor = System.Drawing.Color.White;
            this.btnQuizMillioner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizMillioner.Location = new System.Drawing.Point(25, 245);
            this.btnQuizMillioner.Name = "btnQuizMillioner";
            this.btnQuizMillioner.Size = new System.Drawing.Size(162, 51);
            this.btnQuizMillioner.TabIndex = 1;
            this.btnQuizMillioner.Text = "Кој сака да биде милионер?";
            this.btnQuizMillioner.UseVisualStyleBackColor = false;
            this.btnQuizMillioner.Click += new System.EventHandler(this.btnQuizMillioner_Click);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.White;
            this.btnScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.Location = new System.Drawing.Point(25, 332);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(162, 51);
            this.btnScores.TabIndex = 2;
            this.btnScores.Text = "Рекорди";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(25, 146);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(162, 20);
            this.txtIme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добредојдовте во неверојатниот квиз";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вашето име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Внесете го вашето име и изберете";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "кој тип на квиз ќе го играте!";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.quiz_comets_ngsversion_1414771454905;
            this.ClientSize = new System.Drawing.Size(803, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnQuizMillioner);
            this.Controls.Add(this.btnQuizTime);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuizTime;
        private System.Windows.Forms.Button btnQuizMillioner;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
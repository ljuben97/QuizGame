namespace WindowsFormsApp1
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
            this.anw1 = new System.Windows.Forms.Button();
            this.anws2 = new System.Windows.Forms.Button();
            this.answ3 = new System.Windows.Forms.Button();
            this.answ4 = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anw1
            // 
            this.anw1.Location = new System.Drawing.Point(76, 280);
            this.anw1.Name = "anw1";
            this.anw1.Size = new System.Drawing.Size(233, 51);
            this.anw1.TabIndex = 0;
            this.anw1.Text = "button1";
            this.anw1.UseVisualStyleBackColor = true;
            this.anw1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anws2
            // 
            this.anws2.Location = new System.Drawing.Point(350, 280);
            this.anws2.Name = "anws2";
            this.anws2.Size = new System.Drawing.Size(232, 51);
            this.anws2.TabIndex = 2;
            this.anws2.Text = "button2";
            this.anws2.UseVisualStyleBackColor = true;
            this.anws2.Click += new System.EventHandler(this.anws2_Click);
            // 
            // answ3
            // 
            this.answ3.Location = new System.Drawing.Point(76, 364);
            this.answ3.Name = "answ3";
            this.answ3.Size = new System.Drawing.Size(233, 53);
            this.answ3.TabIndex = 3;
            this.answ3.Text = "button3";
            this.answ3.UseVisualStyleBackColor = true;
            this.answ3.Click += new System.EventHandler(this.answ3_Click);
            // 
            // answ4
            // 
            this.answ4.Location = new System.Drawing.Point(350, 364);
            this.answ4.Name = "answ4";
            this.answ4.Size = new System.Drawing.Size(232, 53);
            this.answ4.TabIndex = 4;
            this.answ4.Text = "button4";
            this.answ4.UseVisualStyleBackColor = true;
            this.answ4.Click += new System.EventHandler(this.answ4_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Enabled = false;
            this.btnQuestion.Location = new System.Drawing.Point(76, 179);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(506, 64);
            this.btnQuestion.TabIndex = 5;
            this.btnQuestion.Text = "Test";
            this.btnQuestion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.answ4);
            this.Controls.Add(this.answ3);
            this.Controls.Add(this.anws2);
            this.Controls.Add(this.anw1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button anw1;
        private System.Windows.Forms.Button anws2;
        private System.Windows.Forms.Button answ3;
        private System.Windows.Forms.Button answ4;
        private System.Windows.Forms.Button btnQuestion;
    }
}


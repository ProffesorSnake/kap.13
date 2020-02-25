namespace övning_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.tbxin = new System.Windows.Forms.TextBox();
            this.tbxut = new System.Windows.Forms.TextBox();
            this.tbxStad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stad:";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(225, 198);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "button1";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.BtnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(440, 198);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 2;
            this.btnPop.Text = "button2";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.BtnPop_Click);
            // 
            // tbxin
            // 
            this.tbxin.Location = new System.Drawing.Point(225, 261);
            this.tbxin.Multiline = true;
            this.tbxin.Name = "tbxin";
            this.tbxin.Size = new System.Drawing.Size(107, 149);
            this.tbxin.TabIndex = 3;
            // 
            // tbxut
            // 
            this.tbxut.Location = new System.Drawing.Point(440, 261);
            this.tbxut.Multiline = true;
            this.tbxut.Name = "tbxut";
            this.tbxut.Size = new System.Drawing.Size(97, 149);
            this.tbxut.TabIndex = 4;
            // 
            // tbxStad
            // 
            this.tbxStad.Location = new System.Drawing.Point(291, 78);
            this.tbxStad.Name = "tbxStad";
            this.tbxStad.Size = new System.Drawing.Size(100, 20);
            this.tbxStad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inmatad ordning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PLats på stacken";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxStad);
            this.Controls.Add(this.tbxut);
            this.Controls.Add(this.tbxin);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.TextBox tbxin;
        private System.Windows.Forms.TextBox tbxut;
        private System.Windows.Forms.TextBox tbxStad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


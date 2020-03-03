namespace _3
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
            this.btnNykund = new System.Windows.Forms.Button();
            this.btnExpe = new System.Windows.Forms.Button();
            this.tbxförst = new System.Windows.Forms.TextBox();
            this.tbxsist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNykund
            // 
            this.btnNykund.Location = new System.Drawing.Point(233, 293);
            this.btnNykund.Name = "btnNykund";
            this.btnNykund.Size = new System.Drawing.Size(75, 23);
            this.btnNykund.TabIndex = 0;
            this.btnNykund.Text = "button1";
            this.btnNykund.UseVisualStyleBackColor = true;
            this.btnNykund.Click += new System.EventHandler(this.BtnNykund_Click);
            // 
            // btnExpe
            // 
            this.btnExpe.Location = new System.Drawing.Point(396, 293);
            this.btnExpe.Name = "btnExpe";
            this.btnExpe.Size = new System.Drawing.Size(75, 23);
            this.btnExpe.TabIndex = 1;
            this.btnExpe.Text = "button2";
            this.btnExpe.UseVisualStyleBackColor = true;
            this.btnExpe.Click += new System.EventHandler(this.BtnExpe_Click);
            // 
            // tbxförst
            // 
            this.tbxförst.Location = new System.Drawing.Point(233, 262);
            this.tbxförst.Multiline = true;
            this.tbxförst.Name = "tbxförst";
            this.tbxförst.Size = new System.Drawing.Size(238, 25);
            this.tbxförst.TabIndex = 2;
            // 
            // tbxsist
            // 
            this.tbxsist.Location = new System.Drawing.Point(306, 215);
            this.tbxsist.Name = "tbxsist";
            this.tbxsist.Size = new System.Drawing.Size(165, 20);
            this.tbxsist.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxsist);
            this.Controls.Add(this.tbxförst);
            this.Controls.Add(this.btnExpe);
            this.Controls.Add(this.btnNykund);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNykund;
        private System.Windows.Forms.Button btnExpe;
        private System.Windows.Forms.TextBox tbxförst;
        private System.Windows.Forms.TextBox tbxsist;
    }
}


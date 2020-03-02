namespace övning132
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
            this.tbxord = new System.Windows.Forms.TextBox();
            this.btnkontroll = new System.Windows.Forms.Button();
            this.tbxres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxord
            // 
            this.tbxord.Location = new System.Drawing.Point(292, 127);
            this.tbxord.Name = "tbxord";
            this.tbxord.Size = new System.Drawing.Size(100, 20);
            this.tbxord.TabIndex = 0;
            // 
            // btnkontroll
            // 
            this.btnkontroll.Location = new System.Drawing.Point(292, 200);
            this.btnkontroll.Name = "btnkontroll";
            this.btnkontroll.Size = new System.Drawing.Size(75, 23);
            this.btnkontroll.TabIndex = 1;
            this.btnkontroll.Text = "kontroll";
            this.btnkontroll.UseVisualStyleBackColor = true;
            this.btnkontroll.Click += new System.EventHandler(this.Btnkontroll_Click);
            // 
            // tbxres
            // 
            this.tbxres.Location = new System.Drawing.Point(292, 167);
            this.tbxres.Name = "tbxres";
            this.tbxres.Size = new System.Drawing.Size(100, 20);
            this.tbxres.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxres);
            this.Controls.Add(this.btnkontroll);
            this.Controls.Add(this.tbxord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxord;
        private System.Windows.Forms.Button btnkontroll;
        private System.Windows.Forms.TextBox tbxres;
    }
}


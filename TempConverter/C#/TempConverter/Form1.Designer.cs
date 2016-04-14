namespace TempConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TempC = new System.Windows.Forms.TextBox();
            this.TempF = new System.Windows.Forms.TextBox();
            this.TempK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatuur ºC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperatuur ºF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperatuur K";
            // 
            // TempC
            // 
            this.TempC.Location = new System.Drawing.Point(99, 12);
            this.TempC.Name = "TempC";
            this.TempC.Size = new System.Drawing.Size(100, 20);
            this.TempC.TabIndex = 4;
            this.TempC.TextChanged += new System.EventHandler(this.TempC_TextChanged);
            // 
            // TempF
            // 
            this.TempF.Enabled = false;
            this.TempF.Location = new System.Drawing.Point(99, 38);
            this.TempF.Name = "TempF";
            this.TempF.Size = new System.Drawing.Size(100, 20);
            this.TempF.TabIndex = 5;
            this.TempF.TextChanged += new System.EventHandler(this.TempF_TextChanged);
            // 
            // TempK
            // 
            this.TempK.Enabled = false;
            this.TempK.Location = new System.Drawing.Point(99, 64);
            this.TempK.Name = "TempK";
            this.TempK.Size = new System.Drawing.Size(100, 20);
            this.TempK.TabIndex = 6;
            this.TempK.TextChanged += new System.EventHandler(this.TempK_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 97);
            this.Controls.Add(this.TempK);
            this.Controls.Add(this.TempF);
            this.Controls.Add(this.TempC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TempConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TempC;
        private System.Windows.Forms.TextBox TempF;
        private System.Windows.Forms.TextBox TempK;
    }
}


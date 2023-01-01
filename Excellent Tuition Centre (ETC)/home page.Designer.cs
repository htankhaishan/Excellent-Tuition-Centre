namespace Excellent_Tuition_Centre__ETC_
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.test1 = new System.Windows.Forms.Button();
            this.lblRice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(353, 265);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(75, 23);
            this.test1.TabIndex = 0;
            this.test1.Text = "Click me";
            this.test1.UseVisualStyleBackColor = true;
            this.test1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRice
            // 
            this.lblRice.AutoSize = true;
            this.lblRice.Location = new System.Drawing.Point(167, 91);
            this.lblRice.Name = "lblRice";
            this.lblRice.Size = new System.Drawing.Size(78, 15);
            this.lblRice.TabIndex = 1;
            this.lblRice.Text = "Rice was here";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test student page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRice);
            this.Controls.Add(this.test1);
            this.Name = "main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button test1;
        private Label lblRice;
        private Button button1;
    }
}
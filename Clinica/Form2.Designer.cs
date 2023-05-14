namespace Clinica
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
            this.fm2button1 = new System.Windows.Forms.Button();
            this.fm2button2 = new System.Windows.Forms.Button();
            this.fm2textBox1 = new System.Windows.Forms.TextBox();
            this.fm2textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fm2button1
            // 
            this.fm2button1.Location = new System.Drawing.Point(377, 249);
            this.fm2button1.Name = "fm2button1";
            this.fm2button1.Size = new System.Drawing.Size(75, 23);
            this.fm2button1.TabIndex = 0;
            this.fm2button1.Text = "button1";
            this.fm2button1.UseVisualStyleBackColor = true;
            this.fm2button1.Click += new System.EventHandler(this.fm2button1_Click);
            // 
            // fm2button2
            // 
            this.fm2button2.Location = new System.Drawing.Point(243, 249);
            this.fm2button2.Name = "fm2button2";
            this.fm2button2.Size = new System.Drawing.Size(75, 23);
            this.fm2button2.TabIndex = 1;
            this.fm2button2.Text = "button2";
            this.fm2button2.UseVisualStyleBackColor = true;
            this.fm2button2.Click += new System.EventHandler(this.fm2button2_Click);
            // 
            // fm2textBox1
            // 
            this.fm2textBox1.Location = new System.Drawing.Point(279, 73);
            this.fm2textBox1.Name = "fm2textBox1";
            this.fm2textBox1.Size = new System.Drawing.Size(113, 20);
            this.fm2textBox1.TabIndex = 2;
            // 
            // fm2textBox2
            // 
            this.fm2textBox2.Location = new System.Drawing.Point(279, 129);
            this.fm2textBox2.Name = "fm2textBox2";
            this.fm2textBox2.Size = new System.Drawing.Size(113, 20);
            this.fm2textBox2.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fm2textBox2);
            this.Controls.Add(this.fm2textBox1);
            this.Controls.Add(this.fm2button2);
            this.Controls.Add(this.fm2button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fm2button1;
        private System.Windows.Forms.Button fm2button2;
        private System.Windows.Forms.TextBox fm2textBox1;
        private System.Windows.Forms.TextBox fm2textBox2;
    }
}
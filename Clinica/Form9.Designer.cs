namespace Clinica
{
    partial class Form9
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.PassDoctor = new System.Windows.Forms.TextBox();
            this.RutDoctor = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rut :";
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(329, 271);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 24);
            this.Volver.TabIndex = 15;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            // 
            // PassDoctor
            // 
            this.PassDoctor.Location = new System.Drawing.Point(329, 151);
            this.PassDoctor.Name = "PassDoctor";
            this.PassDoctor.Size = new System.Drawing.Size(100, 22);
            this.PassDoctor.TabIndex = 14;
            // 
            // RutDoctor
            // 
            this.RutDoctor.Location = new System.Drawing.Point(329, 110);
            this.RutDoctor.Name = "RutDoctor";
            this.RutDoctor.Size = new System.Drawing.Size(100, 22);
            this.RutDoctor.TabIndex = 13;
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(329, 216);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 26);
            this.Ingresar.TabIndex = 12;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.PassDoctor);
            this.Controls.Add(this.RutDoctor);
            this.Controls.Add(this.Ingresar);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.TextBox PassDoctor;
        private System.Windows.Forms.TextBox RutDoctor;
        private System.Windows.Forms.Button Ingresar;
    }
}
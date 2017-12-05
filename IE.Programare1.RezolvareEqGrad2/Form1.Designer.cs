namespace IE.Programare1.RezolvareEqGrad2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxTextBoxA = new System.Windows.Forms.TextBox();
            this.uxTextBoxB = new System.Windows.Forms.TextBox();
            this.uxTextBoxC = new System.Windows.Forms.TextBox();
            this.uxButtonRezolva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "c";
            // 
            // uxTextBoxA
            // 
            this.uxTextBoxA.Location = new System.Drawing.Point(89, 129);
            this.uxTextBoxA.Name = "uxTextBoxA";
            this.uxTextBoxA.Size = new System.Drawing.Size(100, 22);
            this.uxTextBoxA.TabIndex = 3;
            // 
            // uxTextBoxB
            // 
            this.uxTextBoxB.Location = new System.Drawing.Point(89, 164);
            this.uxTextBoxB.Name = "uxTextBoxB";
            this.uxTextBoxB.Size = new System.Drawing.Size(100, 22);
            this.uxTextBoxB.TabIndex = 4;
            // 
            // uxTextBoxC
            // 
            this.uxTextBoxC.Location = new System.Drawing.Point(89, 200);
            this.uxTextBoxC.Name = "uxTextBoxC";
            this.uxTextBoxC.Size = new System.Drawing.Size(100, 22);
            this.uxTextBoxC.TabIndex = 5;
            // 
            // uxButtonRezolva
            // 
            this.uxButtonRezolva.AutoSize = true;
            this.uxButtonRezolva.Location = new System.Drawing.Point(89, 248);
            this.uxButtonRezolva.Name = "uxButtonRezolva";
            this.uxButtonRezolva.Size = new System.Drawing.Size(75, 27);
            this.uxButtonRezolva.TabIndex = 6;
            this.uxButtonRezolva.Text = "Rezolva";
            this.uxButtonRezolva.UseVisualStyleBackColor = true;
            this.uxButtonRezolva.Click += new System.EventHandler(this.uxButtonRezolva_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(49, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ecuatia de gradul 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxButtonRezolva);
            this.Controls.Add(this.uxTextBoxC);
            this.Controls.Add(this.uxTextBoxB);
            this.Controls.Add(this.uxTextBoxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxTextBoxA;
        private System.Windows.Forms.TextBox uxTextBoxB;
        private System.Windows.Forms.TextBox uxTextBoxC;
        private System.Windows.Forms.Button uxButtonRezolva;
        private System.Windows.Forms.Label label4;
    }
}


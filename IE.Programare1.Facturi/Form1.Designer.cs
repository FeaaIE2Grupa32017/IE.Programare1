namespace IE.Programare1.Facturi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxTextBoxNumar = new System.Windows.Forms.TextBox();
            this.uxDateTimePickerDataFact = new System.Windows.Forms.DateTimePicker();
            this.uxListBoxFacturi = new System.Windows.Forms.ListBox();
            this.uxButtonAddFact = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1297, 704);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturi";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxNumar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uxDateTimePickerDataFact, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.uxListBoxFacturi, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.uxButtonAddFact, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1291, 321);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numar";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data";
            // 
            // uxTextBoxNumar
            // 
            this.uxTextBoxNumar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxNumar.Location = new System.Drawing.Point(390, 9);
            this.uxTextBoxNumar.Name = "uxTextBoxNumar";
            this.uxTextBoxNumar.Size = new System.Drawing.Size(898, 22);
            this.uxTextBoxNumar.TabIndex = 2;
            // 
            // uxDateTimePickerDataFact
            // 
            this.uxDateTimePickerDataFact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxDateTimePickerDataFact.Location = new System.Drawing.Point(390, 49);
            this.uxDateTimePickerDataFact.Name = "uxDateTimePickerDataFact";
            this.uxDateTimePickerDataFact.Size = new System.Drawing.Size(200, 22);
            this.uxDateTimePickerDataFact.TabIndex = 3;
            // 
            // uxListBoxFacturi
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.uxListBoxFacturi, 2);
            this.uxListBoxFacturi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxListBoxFacturi.FormattingEnabled = true;
            this.uxListBoxFacturi.ItemHeight = 16;
            this.uxListBoxFacturi.Location = new System.Drawing.Point(3, 123);
            this.uxListBoxFacturi.Name = "uxListBoxFacturi";
            this.uxListBoxFacturi.Size = new System.Drawing.Size(1285, 195);
            this.uxListBoxFacturi.TabIndex = 4;
            // 
            // uxButtonAddFact
            // 
            this.uxButtonAddFact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxButtonAddFact.AutoSize = true;
            this.uxButtonAddFact.Location = new System.Drawing.Point(390, 86);
            this.uxButtonAddFact.Name = "uxButtonAddFact";
            this.uxButtonAddFact.Size = new System.Drawing.Size(75, 27);
            this.uxButtonAddFact.TabIndex = 5;
            this.uxButtonAddFact.Text = "Adauga";
            this.uxButtonAddFact.UseVisualStyleBackColor = true;
            this.uxButtonAddFact.Click += new System.EventHandler(this.uxButtonAddFact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 704);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxTextBoxNumar;
        private System.Windows.Forms.DateTimePicker uxDateTimePickerDataFact;
        private System.Windows.Forms.ListBox uxListBoxFacturi;
        private System.Windows.Forms.Button uxButtonAddFact;
    }
}


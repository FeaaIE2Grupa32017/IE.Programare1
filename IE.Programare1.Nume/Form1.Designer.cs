namespace IE.Programare1.Nume
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
            this.uxTableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uxFlowLayoutPanelAdaugare = new System.Windows.Forms.FlowLayoutPanel();
            this.uxTextBoxNume = new System.Windows.Forms.TextBox();
            this.uxButtonAdauga = new System.Windows.Forms.Button();
            this.uxListBoxNume = new System.Windows.Forms.ListBox();
            this.uxFlowLayoutPanelOrdonare = new System.Windows.Forms.FlowLayoutPanel();
            this.uxCheckBoxDirectie = new System.Windows.Forms.CheckBox();
            this.uxButtonOrdoneaza = new System.Windows.Forms.Button();
            this.uxTableLayoutPanelMain.SuspendLayout();
            this.uxFlowLayoutPanelAdaugare.SuspendLayout();
            this.uxFlowLayoutPanelOrdonare.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxTableLayoutPanelMain
            // 
            this.uxTableLayoutPanelMain.ColumnCount = 1;
            this.uxTableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uxTableLayoutPanelMain.Controls.Add(this.label1, 0, 0);
            this.uxTableLayoutPanelMain.Controls.Add(this.uxFlowLayoutPanelAdaugare, 0, 1);
            this.uxTableLayoutPanelMain.Controls.Add(this.uxListBoxNume, 0, 2);
            this.uxTableLayoutPanelMain.Controls.Add(this.uxFlowLayoutPanelOrdonare, 0, 3);
            this.uxTableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.uxTableLayoutPanelMain.Name = "uxTableLayoutPanelMain";
            this.uxTableLayoutPanelMain.RowCount = 4;
            this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uxTableLayoutPanelMain.Size = new System.Drawing.Size(1053, 599);
            this.uxTableLayoutPanelMain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // uxFlowLayoutPanelAdaugare
            // 
            this.uxFlowLayoutPanelAdaugare.Controls.Add(this.uxTextBoxNume);
            this.uxFlowLayoutPanelAdaugare.Controls.Add(this.uxButtonAdauga);
            this.uxFlowLayoutPanelAdaugare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxFlowLayoutPanelAdaugare.Location = new System.Drawing.Point(3, 53);
            this.uxFlowLayoutPanelAdaugare.Name = "uxFlowLayoutPanelAdaugare";
            this.uxFlowLayoutPanelAdaugare.Size = new System.Drawing.Size(1047, 44);
            this.uxFlowLayoutPanelAdaugare.TabIndex = 4;
            // 
            // uxTextBoxNume
            // 
            this.uxTextBoxNume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxTextBoxNume.Location = new System.Drawing.Point(3, 5);
            this.uxTextBoxNume.Name = "uxTextBoxNume";
            this.uxTextBoxNume.Size = new System.Drawing.Size(600, 22);
            this.uxTextBoxNume.TabIndex = 0;
            this.uxTextBoxNume.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uxTextBoxNume_KeyUp);
            // 
            // uxButtonAdauga
            // 
            this.uxButtonAdauga.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxButtonAdauga.AutoSize = true;
            this.uxButtonAdauga.Location = new System.Drawing.Point(609, 3);
            this.uxButtonAdauga.Name = "uxButtonAdauga";
            this.uxButtonAdauga.Size = new System.Drawing.Size(75, 27);
            this.uxButtonAdauga.TabIndex = 1;
            this.uxButtonAdauga.Text = "Adauga";
            this.uxButtonAdauga.UseVisualStyleBackColor = true;
            this.uxButtonAdauga.Click += new System.EventHandler(this.uxButtonAdauga_Click);
            // 
            // uxListBoxNume
            // 
            this.uxListBoxNume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxListBoxNume.FormattingEnabled = true;
            this.uxListBoxNume.ItemHeight = 16;
            this.uxListBoxNume.Location = new System.Drawing.Point(3, 103);
            this.uxListBoxNume.Name = "uxListBoxNume";
            this.uxListBoxNume.Size = new System.Drawing.Size(1047, 393);
            this.uxListBoxNume.TabIndex = 5;
            // 
            // uxFlowLayoutPanelOrdonare
            // 
            this.uxFlowLayoutPanelOrdonare.Controls.Add(this.uxCheckBoxDirectie);
            this.uxFlowLayoutPanelOrdonare.Controls.Add(this.uxButtonOrdoneaza);
            this.uxFlowLayoutPanelOrdonare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxFlowLayoutPanelOrdonare.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uxFlowLayoutPanelOrdonare.Location = new System.Drawing.Point(3, 502);
            this.uxFlowLayoutPanelOrdonare.Name = "uxFlowLayoutPanelOrdonare";
            this.uxFlowLayoutPanelOrdonare.Size = new System.Drawing.Size(1047, 94);
            this.uxFlowLayoutPanelOrdonare.TabIndex = 6;
            // 
            // uxCheckBoxDirectie
            // 
            this.uxCheckBoxDirectie.AutoSize = true;
            this.uxCheckBoxDirectie.Location = new System.Drawing.Point(3, 3);
            this.uxCheckBoxDirectie.Name = "uxCheckBoxDirectie";
            this.uxCheckBoxDirectie.Size = new System.Drawing.Size(114, 21);
            this.uxCheckBoxDirectie.TabIndex = 0;
            this.uxCheckBoxDirectie.Text = "Descrescator";
            this.uxCheckBoxDirectie.UseVisualStyleBackColor = true;
            // 
            // uxButtonOrdoneaza
            // 
            this.uxButtonOrdoneaza.Location = new System.Drawing.Point(3, 30);
            this.uxButtonOrdoneaza.Name = "uxButtonOrdoneaza";
            this.uxButtonOrdoneaza.Size = new System.Drawing.Size(75, 23);
            this.uxButtonOrdoneaza.TabIndex = 1;
            this.uxButtonOrdoneaza.Text = "Ordoneaza";
            this.uxButtonOrdoneaza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 599);
            this.Controls.Add(this.uxTableLayoutPanelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.uxTableLayoutPanelMain.ResumeLayout(false);
            this.uxTableLayoutPanelMain.PerformLayout();
            this.uxFlowLayoutPanelAdaugare.ResumeLayout(false);
            this.uxFlowLayoutPanelAdaugare.PerformLayout();
            this.uxFlowLayoutPanelOrdonare.ResumeLayout(false);
            this.uxFlowLayoutPanelOrdonare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel uxTableLayoutPanelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel uxFlowLayoutPanelAdaugare;
        private System.Windows.Forms.TextBox uxTextBoxNume;
        private System.Windows.Forms.Button uxButtonAdauga;
        private System.Windows.Forms.ListBox uxListBoxNume;
        private System.Windows.Forms.FlowLayoutPanel uxFlowLayoutPanelOrdonare;
        private System.Windows.Forms.CheckBox uxCheckBoxDirectie;
        private System.Windows.Forms.Button uxButtonOrdoneaza;
    }
}


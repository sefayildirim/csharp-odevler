namespace Odev_4
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
            this.VizeNotu = new System.Windows.Forms.TextBox();
            this.FinalNotu = new System.Windows.Forms.TextBox();
            this.ProjeNotu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proje";
            // 
            // VizeNotu
            // 
            this.VizeNotu.Location = new System.Drawing.Point(64, 30);
            this.VizeNotu.Name = "VizeNotu";
            this.VizeNotu.Size = new System.Drawing.Size(100, 20);
            this.VizeNotu.TabIndex = 3;
            // 
            // FinalNotu
            // 
            this.FinalNotu.Location = new System.Drawing.Point(64, 80);
            this.FinalNotu.Name = "FinalNotu";
            this.FinalNotu.Size = new System.Drawing.Size(100, 20);
            this.FinalNotu.TabIndex = 4;
            // 
            // ProjeNotu
            // 
            this.ProjeNotu.Location = new System.Drawing.Point(64, 122);
            this.ProjeNotu.Name = "ProjeNotu";
            this.ProjeNotu.Size = new System.Drawing.Size(100, 20);
            this.ProjeNotu.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(239, 30);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(342, 173);
            this.listBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProjeNotu);
            this.Controls.Add(this.FinalNotu);
            this.Controls.Add(this.VizeNotu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VizeNotu;
        private System.Windows.Forms.TextBox FinalNotu;
        private System.Windows.Forms.TextBox ProjeNotu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox;
    }
}


namespace Odev_2
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.createInput = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VizeNotu = new System.Windows.Forms.TextBox();
            this.FinalNotu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Öğrenci Adı";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(23, 56);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(79, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Öğrenci Soyadı";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(23, 94);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(67, 13);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Öğrenci Yaşı";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 18);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 3;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(108, 56);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 20);
            this.surnameBox.TabIndex = 4;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(108, 94);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 5;
            // 
            // createInput
            // 
            this.createInput.Location = new System.Drawing.Point(26, 213);
            this.createInput.Name = "createInput";
            this.createInput.Size = new System.Drawing.Size(182, 23);
            this.createInput.TabIndex = 13;
            this.createInput.Text = "Hesapla";
            this.createInput.UseVisualStyleBackColor = true;
            this.createInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(314, 77);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(320, 173);
            this.listBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vize Notu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Final Notu";
            // 
            // VizeNotu
            // 
            this.VizeNotu.Location = new System.Drawing.Point(108, 133);
            this.VizeNotu.Name = "VizeNotu";
            this.VizeNotu.Size = new System.Drawing.Size(100, 20);
            this.VizeNotu.TabIndex = 19;
            // 
            // FinalNotu
            // 
            this.FinalNotu.Location = new System.Drawing.Point(108, 168);
            this.FinalNotu.Name = "FinalNotu";
            this.FinalNotu.Size = new System.Drawing.Size(100, 20);
            this.FinalNotu.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Odev_3.Properties.Resources.uni_min_logo;
            this.pictureBox1.Location = new System.Drawing.Point(412, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 48);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FinalNotu);
            this.Controls.Add(this.VizeNotu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.createInput);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Button createInput;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VizeNotu;
        private System.Windows.Forms.TextBox FinalNotu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


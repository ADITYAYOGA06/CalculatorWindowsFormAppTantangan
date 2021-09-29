
namespace CalculatorWindowsFormAppTantangan
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
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNilai1 = new System.Windows.Forms.TextBox();
            this.txtNilai2 = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.combo1.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.combo1.Location = new System.Drawing.Point(129, 25);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(140, 21);
            this.combo1.TabIndex = 0;
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai B";
            // 
            // txtNilai1
            // 
            this.txtNilai1.Location = new System.Drawing.Point(129, 59);
            this.txtNilai1.Name = "txtNilai1";
            this.txtNilai1.Size = new System.Drawing.Size(117, 20);
            this.txtNilai1.TabIndex = 3;
            // 
            // txtNilai2
            // 
            this.txtNilai2.Location = new System.Drawing.Point(129, 96);
            this.txtNilai2.Name = "txtNilai2";
            this.txtNilai2.Size = new System.Drawing.Size(117, 20);
            this.txtNilai2.TabIndex = 4;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(129, 168);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 5;
            this.btnHitung.Text = "Hitung Bos!";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(129, 132);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(140, 20);
            this.txtHasil.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtNilai2);
            this.Controls.Add(this.txtNilai1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNilai1;
        private System.Windows.Forms.TextBox txtNilai2;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Label label3;
    }
}


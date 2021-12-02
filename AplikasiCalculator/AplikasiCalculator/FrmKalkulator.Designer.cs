
namespace KalkulatorApp
{
	partial class FrmKalkulator
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
			this.cmbOperasi = new System.Windows.Forms.ComboBox();
			this.txtNilaiA = new System.Windows.Forms.TextBox();
			this.txtNilaiB = new System.Windows.Forms.TextBox();
			this.btnMenghitung = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Operasi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 47);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nilai A";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 84);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nilai B";
			// 
			// cmbOperasi
			// 
			this.cmbOperasi.FormattingEnabled = true;
			this.cmbOperasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
			this.cmbOperasi.Location = new System.Drawing.Point(75, 14);
			this.cmbOperasi.Margin = new System.Windows.Forms.Padding(2);
			this.cmbOperasi.Name = "cmbOperasi";
			this.cmbOperasi.Size = new System.Drawing.Size(136, 21);
			this.cmbOperasi.TabIndex = 3;
			// 
			// txtNilaiA
			// 
			this.txtNilaiA.Location = new System.Drawing.Point(75, 45);
			this.txtNilaiA.Margin = new System.Windows.Forms.Padding(2);
			this.txtNilaiA.Name = "txtNilaiA";
			this.txtNilaiA.Size = new System.Drawing.Size(136, 20);
			this.txtNilaiA.TabIndex = 4;
			// 
			// txtNilaiB
			// 
			this.txtNilaiB.Location = new System.Drawing.Point(75, 82);
			this.txtNilaiB.Margin = new System.Windows.Forms.Padding(2);
			this.txtNilaiB.Name = "txtNilaiB";
			this.txtNilaiB.Size = new System.Drawing.Size(136, 20);
			this.txtNilaiB.TabIndex = 5;
			// 
			// btnMenghitung
			// 
			this.btnMenghitung.Location = new System.Drawing.Point(105, 121);
			this.btnMenghitung.Margin = new System.Windows.Forms.Padding(2);
			this.btnMenghitung.Name = "btnMenghitung";
			this.btnMenghitung.Size = new System.Drawing.Size(70, 19);
			this.btnMenghitung.TabIndex = 6;
			this.btnMenghitung.Text = "Hitung";
			this.btnMenghitung.UseVisualStyleBackColor = true;
			this.btnMenghitung.Click += new System.EventHandler(this.btnProses_Click);
			// 
			// FrmKalkulator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 190);
			this.Controls.Add(this.btnMenghitung);
			this.Controls.Add(this.txtNilaiB);
			this.Controls.Add(this.txtNilaiA);
			this.Controls.Add(this.cmbOperasi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmKalkulator";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbOperasi;
		private System.Windows.Forms.TextBox txtNilaiA;
		private System.Windows.Forms.TextBox txtNilaiB;
		private System.Windows.Forms.Button btnMenghitung;
	}
}
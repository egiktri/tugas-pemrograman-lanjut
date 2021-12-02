
namespace KalkulatorApp
{
	partial class FrmHasilPerhitungan
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvwHasilPerhitungan = new System.Windows.Forms.ListView();
			this.btnHitung = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lvwHasilPerhitungan);
			this.groupBox1.Location = new System.Drawing.Point(13, 14);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(455, 227);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "[ Hasil ]";
			// 
			// lvwHasilPerhitungan
			// 
			this.lvwHasilPerhitungan.HideSelection = false;
			this.lvwHasilPerhitungan.Location = new System.Drawing.Point(8, 23);
			this.lvwHasilPerhitungan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lvwHasilPerhitungan.Name = "lvwHasilPerhitungan";
			this.lvwHasilPerhitungan.Size = new System.Drawing.Size(434, 193);
			this.lvwHasilPerhitungan.TabIndex = 0;
			this.lvwHasilPerhitungan.UseCompatibleStateImageBehavior = false;
			// 
			// btnHitung
			// 
			this.btnHitung.Location = new System.Drawing.Point(21, 255);
			this.btnHitung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnHitung.Name = "btnHitung";
			this.btnHitung.Size = new System.Drawing.Size(434, 26);
			this.btnHitung.TabIndex = 1;
			this.btnHitung.Text = "Hitung";
			this.btnHitung.UseVisualStyleBackColor = true;
			this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
			// 
			// FrmHasilPerhitungan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 292);
			this.Controls.Add(this.btnHitung);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmHasilPerhitungan";
			this.Text = "Hasil Perhitungan";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvwHasilPerhitungan;
		private System.Windows.Forms.Button btnHitung;
	}
}


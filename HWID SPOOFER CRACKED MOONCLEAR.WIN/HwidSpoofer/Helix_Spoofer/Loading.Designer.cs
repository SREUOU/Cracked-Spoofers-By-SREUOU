namespace Helix_Spoofer
{
	// Token: 0x02000002 RID: 2
	public partial class Loading : global::System.Windows.Forms.Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002210 File Offset: 0x00000410
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002248 File Offset: 0x00000448
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.guna2PictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.gunaProgressBar1 = new global::Guna.UI.WinForms.GunaProgressBar();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.drc = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.guna2PictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::HwidSpoofer.Properties.Resources.R_unscreen;
			this.guna2PictureBox1.ImageRotate = 0f;
			this.guna2PictureBox1.Location = new global::System.Drawing.Point(162, 68);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new global::System.Drawing.Size(288, 199);
			this.guna2PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.Click += new global::System.EventHandler(this.guna2PictureBox1_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(253, 227);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(115, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Welcome Guest,";
			this.gunaProgressBar1.BackColor = global::System.Drawing.Color.Black;
			this.gunaProgressBar1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.gunaProgressBar1.BorderColor = global::System.Drawing.Color.Black;
			this.gunaProgressBar1.ColorStyle = 0;
			this.gunaProgressBar1.IdleColor = global::System.Drawing.Color.Transparent;
			this.gunaProgressBar1.Location = new global::System.Drawing.Point(661, 35);
			this.gunaProgressBar1.Maximum = 140;
			this.gunaProgressBar1.Name = "gunaProgressBar1";
			this.gunaProgressBar1.ProgressMaxColor = global::System.Drawing.Color.Transparent;
			this.gunaProgressBar1.ProgressMinColor = global::System.Drawing.Color.FromArgb(100, 88, 255);
			this.gunaProgressBar1.Size = new global::System.Drawing.Size(137, 23);
			this.gunaProgressBar1.TabIndex = 3;
			this.timer1.Interval = 140;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.drc.BackColor = global::System.Drawing.Color.Transparent;
			this.drc.FlatAppearance.BorderSize = 0;
			this.drc.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.drc.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.drc.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.drc.Font = new global::System.Drawing.Font("Segoe UI", 11.25f);
			this.drc.ForeColor = global::System.Drawing.Color.White;
			this.drc.Location = new global::System.Drawing.Point(32, 250);
			this.drc.Name = "drc";
			this.drc.Size = new global::System.Drawing.Size(568, 31);
			this.drc.TabIndex = 5;
			this.drc.Text = "verifying application integrity, checking...";
			this.drc.UseVisualStyleBackColor = false;
			this.drc.Click += new global::System.EventHandler(this.drc_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::HwidSpoofer.Properties.Resources.R1;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(658, 430);
			base.Controls.Add(this.drc);
			base.Controls.Add(this.gunaProgressBar1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.guna2PictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "Loading";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HwidSpoofer";
			base.Load += new global::System.EventHandler(this.Loading_Load);
			((global::System.ComponentModel.ISupportInitialize)this.guna2PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000005 RID: 5
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000007 RID: 7
		private global::Guna.UI.WinForms.GunaProgressBar gunaProgressBar1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button drc;
	}
}

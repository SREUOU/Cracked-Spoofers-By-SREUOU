namespace Helix_Spoofer
{
	// Token: 0x02000009 RID: 9
	public partial class SpoofMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000065D0 File Offset: 0x000047D0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006608 File Offset: 0x00004808
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(209, 353);
			this.panel1.TabIndex = 0;
			this.guna2Button1.CheckedState.BorderColor = global::System.Drawing.Color.Aqua;
			this.guna2Button1.CheckedState.FillColor = global::System.Drawing.Color.SkyBlue;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.DisabledState.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(0, 46);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(209, 29);
			this.guna2Button1.TabIndex = 1;
			this.guna2Button1.Text = "EAC AND BE";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(59, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(72, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Builds :";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(4, 4, 4);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.button1.Location = new global::System.Drawing.Point(215, 301);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(328, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "SELECT BUILD";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(215, 9);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0, 17);
			this.label2.TabIndex = 2;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(215, 31);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(0, 17);
			this.label3.TabIndex = 3;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(215, 54);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(0, 17);
			this.label4.TabIndex = 4;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(215, 76);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(0, 17);
			this.label5.TabIndex = 5;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(215, 163);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(0, 17);
			this.label6.TabIndex = 6;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(215, 187);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(0, 17);
			this.label7.TabIndex = 7;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			base.ClientSize = new global::System.Drawing.Size(555, 345);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SpoofMain";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HwidSpoofer";
			base.Load += new global::System.EventHandler(this.SpoofMain_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003F RID: 63
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000041 RID: 65
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label7;
	}
}

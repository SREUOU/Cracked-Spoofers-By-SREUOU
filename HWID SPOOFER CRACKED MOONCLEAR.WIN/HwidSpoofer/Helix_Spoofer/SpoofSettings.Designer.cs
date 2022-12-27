namespace Helix_Spoofer
{
	// Token: 0x0200000A RID: 10
	public partial class SpoofSettings : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00007074 File Offset: 0x00005274
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000070AC File Offset: 0x000052AC
		private void InitializeComponent()
		{
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			base.SuspendLayout();
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.DisabledState.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(12, 56);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(306, 34);
			this.guna2Button1.TabIndex = 14;
			this.guna2Button1.Text = "SPOOF EAC";
			this.guna2Button1.TextOffset = new global::System.Drawing.Point(0, -2);
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2Button3.BorderThickness = 1;
			this.guna2Button3.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.DisabledState.Parent = this.guna2Button3;
			this.guna2Button3.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.Location = new global::System.Drawing.Point(12, 106);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new global::System.Drawing.Size(306, 34);
			this.guna2Button3.TabIndex = 16;
			this.guna2Button3.Text = "CLEAN TRACES";
			this.guna2Button3.TextOffset = new global::System.Drawing.Point(0, -2);
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			base.ClientSize = new global::System.Drawing.Size(330, 312);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.guna2Button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SpoofSettings";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HwidSpoofer";
			base.Load += new global::System.EventHandler(this.SpoofSettings_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400004A RID: 74
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400004B RID: 75
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x0400004C RID: 76
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;
	}
}

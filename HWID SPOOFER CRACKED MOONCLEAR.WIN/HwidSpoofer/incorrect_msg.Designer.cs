namespace HwidSpoofer
{
	// Token: 0x0200000E RID: 14
	public partial class incorrect_msg : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006A RID: 106 RVA: 0x000090EC File Offset: 0x000072EC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009124 File Offset: 0x00007324
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(61, 29);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(145, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "The username is incorrect.";
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.DisabledState.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.White;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.SkyBlue;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(-1, 76);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(285, 32);
			this.guna2Button1.TabIndex = 5;
			this.guna2Button1.Text = "OK";
			this.guna2Button1.TextOffset = new global::System.Drawing.Point(0, -2);
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			base.ClientSize = new global::System.Drawing.Size(280, 107);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "incorrect_msg";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HwidSpoofer";
			base.Load += new global::System.EventHandler(this.incorrect_msg_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005C RID: 92
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400005E RID: 94
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}

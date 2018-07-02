namespace Loader
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000C01C File Offset: 0x0000321C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000C280 File Offset: 0x00003480
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(10, 105);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(183, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Load";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(11, 50);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(59, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "CRYPT";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(11, 80);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(53, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "KEY";
			this.textBox1.Location = new global::System.Drawing.Point(76, 47);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(117, 20);
			this.textBox1.TabIndex = 4;
			this.textBox2.Font = new global::System.Drawing.Font("MS Outlook", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox2.Location = new global::System.Drawing.Point(76, 78);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(117, 19);
			this.textBox2.TabIndex = 5;
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(36, 9);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(69, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "SHAYTAN.NET";
			this.label3.Click += new global::System.EventHandler(this.label3_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ButtonHighlight;
			base.ClientSize = new global::System.Drawing.Size(205, 140);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Form2";
			base.ShowIcon = false;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000014 RID: 20
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label label3;
	}
}

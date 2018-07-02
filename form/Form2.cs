using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Loader
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000C000 File Offset: 0x00003200
		public Form2()
		{
			this.InitializeComponent();
			base.AcceptButton = this.button1;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000C01A File Offset: 0x0000321A
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000C224 File Offset: 0x00003424
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Length > 1 && this.textBox2.Text.Length > 1)
			{
				Form.ActiveForm.Visible = false;
				Imports.boot(this.textBox1.Text, this.textBox2.Text);
				return;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000C01A File Offset: 0x0000321A
		private void Form2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000C01A File Offset: 0x0000321A
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000C01A File Offset: 0x0000321A
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000C01A File Offset: 0x0000321A
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000C01A File Offset: 0x0000321A
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000C01A File Offset: 0x0000321A
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000C01A File Offset: 0x0000321A
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000C01A File Offset: 0x0000321A
		private void label3_Click_1(object sender, EventArgs e)
		{
		}
	}
}

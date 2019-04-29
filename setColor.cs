using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransBall
{
	public partial class setColor : Form
	{
		public setColor()
		{
			InitializeComponent();
		}

		private void setColor_Load(object sender, EventArgs e)
		{
			cbBoxBiPhai.Items.Add("Đỏ");
			cbBoxBiPhai.Items.Add("Cam");
			cbBoxBiPhai.Items.Add("Vàng");
			cbBoxBiPhai.Items.Add("Lục");
			cbBoxBiPhai.Items.Add("Xanh");
			cbBoxBiPhai.Items.Add("Chàm");
			cbBoxBiPhai.Items.Add("Tím");

			cbBoxBiTrai.Items.Add("Đỏ");
			cbBoxBiTrai.Items.Add("Cam");
			cbBoxBiTrai.Items.Add("Vàng");
			cbBoxBiTrai.Items.Add("Lục");
			cbBoxBiTrai.Items.Add("Xanh");
			cbBoxBiTrai.Items.Add("Chàm");
			cbBoxBiTrai.Items.Add("Tím");
		}
		public int biTrai;
		public int biPhai;


		private void button1_Click(object sender, EventArgs e)
		{
			biTrai = cbBoxBiTrai.SelectedIndex;
			biPhai = cbBoxBiPhai.SelectedIndex;
			this.Close();
		}
	}
}

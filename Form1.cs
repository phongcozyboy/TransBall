using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int nArr = 0;
        int disWidth1 = -15;
		int step = 1;
		int jump = 1;
		int ball;

		private int[] arr;
        private int[] arrBalls;
        private Button[] arrButton;

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (arrButton != null)
                for (int i = 0; i < nArr; i++)
                {
                    gbox.Controls.Remove(arrButton[i]);
                    disWidth1 = -15;
                }

            try
            {
                nArr = (2 * int.Parse(txtBi.Text.Trim())) + 1;
				ball = int.Parse(txtBi.Text.Trim());

				if (int.Parse(txtBi.Text.Trim()) < 1 || int.Parse(txtBi.Text.Trim()) > 5)
                {
                    MessageBox.Show("Vì số lượng không gian bị giới hạn nên bi tối đa là 4", "Thông báo");
                    txtBi.Clear();
                    txtBi.Focus();
                    return;
                }

            }
            catch
            {
                MessageBox.Show("hãy nhập 1 số nguyên !");
                txtBi.Clear();
                txtBi.Focus();
                return;
            }
            arr = new int[nArr];
            arrBalls = new int[nArr];
            arrButton = new Button[nArr];

            for (int i = 0; i < nArr; i++)
                arr[i] = arrBalls[i] = 0;

            for (int i = 0; i < nArr; i++)
            {
                if (i < (nArr / 2))
                {
                    arr[i] = 1;
                    arrBalls[i] = 2;
                }
                else if (i > (nArr / 2))
                {
                    arr[i] = 2;
                    arrBalls[i] = 1;
                }
            }

            int dis = (gbox.Width / 2) - int.Parse(txtBi.Text.Trim()) * 60;

            //khoi tao giao dien
            for (int i = 0; i < nArr; i++)
            {
                Button btn = new Button();
                btn.Width = btn.Height = 40;
                if(i < nArr / 2)
                {
                    btn.BackColor = Color.Green;
                    btn.Location = new Point(dis + disWidth1, (gbox.Height / 2) - 15);
                    gbox.Controls.Add(btn);
                }
                else if(i > nArr / 2)
                {
                    btn.BackColor = Color.Red;
                    btn.Location = new Point(dis + disWidth1, (gbox.Height / 2) - 15);
                    gbox.Controls.Add(btn);
                }
                else
                {
                    btn.Location = new Point(dis + disWidth1, (gbox.Height / 2) - 15);
                    gbox.Controls.Add(btn);
                }
                arrButton[i] = btn;
                disWidth1 += 60;
            }

			arrButton[nArr / 2].Visible = false;
        }

        void swapButton(ref Button b1, ref Button b2, ref int a, ref int b)
        {
			int posRoot = b1.Location.Y;
			while (b1.Location.Y > 40)
			{
				b1.Location = new Point(b1.Location.X, b1.Location.Y - 4);
				b2.Location = new Point(b2.Location.X, b2.Location.Y + 4);
				Application.DoEvents();
				Thread.Sleep(20);
			}

			if (b1.Location.X < b2.Location.X)
			{
				int posTemp = b2.Location.X;
				while (b1.Location.X != posTemp)
				{
					b1.Location = new Point(b1.Location.X + 4, b1.Location.Y);
					b2.Location = new Point(b2.Location.X - 4, b2.Location.Y);
					Application.DoEvents();
					Thread.Sleep(20);
				}
			}
			else if (b1.Location.X > b2.Location.X)
			{
				int posTemp = b2.Location.X;
				while (b1.Location.X != posTemp)
				{
					b1.Location = new Point(b1.Location.X - 4, b1.Location.Y);
					b2.Location = new Point(b2.Location.X + 4, b2.Location.Y);
					Application.DoEvents();
					Thread.Sleep(20);
				}
			}
			while (b1.Location.Y != posRoot)
			{
				b1.Location = new Point(b1.Location.X, b1.Location.Y + 4);
				b2.Location = new Point(b2.Location.X, b2.Location.Y - 4);
				Application.DoEvents();
				Thread.Sleep(20);
			}

			int tempInt = arr[a]; arr[a] = arr[b]; arr[b] = tempInt;
			Button tempButton = b1; b1 = b2; b2 = tempButton;
		}

		private void btnChay_Click(object sender, EventArgs e)
		{
			bool checkLeft = true;
			bool checkRight = false;

			while (true)
			{
				if (checkLeft)
				{
					int jumpTemp = 1;

					while (jumpTemp <= jump)
					{
						bool checkQuit = true;
						int posRoot = 0;
						int posMin;
						int min = int.MaxValue;

						while (arr[posRoot] != 0) posRoot++;
						posMin = posRoot;

						for (int i = 0; i < posRoot; i++)
							if (arr[i] == 1 && Math.Abs(posRoot - i) <= 2 && Math.Abs(posRoot - i) < min)
							{
								min = Math.Abs(posRoot - i);
								posMin = i;
								checkQuit = false;
							}

						if (checkQuit) break;

						swapButton(ref arrButton[posRoot], ref arrButton[posMin], ref posRoot, ref posMin);

						jumpTemp++;
						step++;
					}

					if (jump < ball)
						jump++;
				}

				if (checkRight)
				{
					int jumpTemp = 1;

					while (jumpTemp <= jump)
					{
						bool checkQuit = true;
						int posRoot = 0;
						int posMin;
						int min = int.MaxValue;

						while (arr[posRoot] != 0) posRoot++;

						posMin = posRoot;

						for (int i = nArr - 1; i > posRoot; i--)
							if (arr[i] == 2 && Math.Abs(posRoot - i) <= 2 && Math.Abs(posRoot - i) < min)
							{
								posMin = i;
								min = Math.Abs(posRoot - i);
								checkQuit = false;
							}

						if (checkQuit) break;

						swapButton(ref arrButton[posRoot], ref arrButton[posMin], ref posRoot, ref posMin);

						jumpTemp++;
						step++;
					}

					if (jump < ball)
						jump++;
				}

				if (checkLeft == true)
				{
					checkRight = true;
					checkLeft = false;
				}
				else if (checkRight == true)
				{
					checkLeft = true;
					checkRight = false;
				}

				// check win
				bool checkOut = true;
				for (int i = 0; i < nArr; i++)
					if (arrBalls[i] != arr[i])
						checkOut = false;

				if (checkOut)
					break;
			}

			if (MessageBox.Show("Hoàn Thành ! \nSố bước hoán vị giữa các bi là " + step.ToString() + "\nBạn có muốn chạy lại hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				for (int i = 0; i < nArr; i++)
					gbox.Controls.Remove(arrButton[i]);


				txtBi.Clear();
				txtBi.Focus();
				disWidth1 = -15;
				step = 1;
				jump = 1;
			}
		}

		private void btnDatLai_Click(object sender, EventArgs e)
		{
			txtBi.Clear();
			txtBi.Focus();

			for (int i = 0; i < nArr; i++)
				gbox.Controls.Remove(arrButton[i]);


			disWidth1 = -15;
			jump = 1;
			step = 1;
		}

		private void btnTaobiRandom_Click(object sender, EventArgs e)
		{
			int random_bi;
			Random rd = new Random();
			random_bi = rd.Next(1, 6);

			txtBi.Text = random_bi.ToString();
			btnXacNhan_Click(sender, e);
		}

		Color getColor(int indexColor)
		{

			if (indexColor == 0) return Color.Red;
			if (indexColor == 1) return Color.Orange;
			if (indexColor == 2) return Color.Yellow;
			if (indexColor == 3) return Color.Green;
			if (indexColor == 4) return Color.Blue;
			if (indexColor == 5) return Color.Indigo;
			if (indexColor == 6) return Color.Purple;

			return Color.White;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(nArr == 0)
			{
				MessageBox.Show("Xin vui lòng hãy khởi tạo bi trước khi chỉnh màu !", "Thông báo");
				txtBi.Focus();
				return;
			}

			setColor color = new setColor();
			color.ShowDialog();

			Color left = getColor(color.biTrai);
			Color right = getColor(color.biPhai);

			int dis = (gbox.Width / 2) - int.Parse(txtBi.Text.Trim()) * 60;

			//khoi tao giao dien
			for (int i = 0; i < nArr; i++)
			{
				if (i < nArr / 2)
					arrButton[i].BackColor = left;
				else if (i > nArr / 2)
					arrButton[i].BackColor = right;
			}
		}
	}
}
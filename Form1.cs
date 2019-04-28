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
                if(int.Parse(txtBi.Text.Trim()) < 1 || int.Parse(txtBi.Text.Trim()) > 5)
                {
                    MessageBox.Show("số bi có thể từ 1 đến 5 bi");
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
                    btn.Location = new Point(dis + disWidth1, gbox.Height / 2);
                    gbox.Controls.Add(btn);
                }
                else if(i > nArr / 2)
                {
                    btn.BackColor = Color.Red;
                    btn.Location = new Point(dis + disWidth1, gbox.Height / 2);
                    gbox.Controls.Add(btn);
                }
                else
                {
                    btn.Location = new Point(dis + disWidth1, gbox.Height / 2);
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
			while (b1.Location.Y > 70)
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
			int step = 0;
			int start = 0;
			int end = nArr - 1;

			while (true)
			{
				bool checkLeft = false;
				bool checkRight = false;
				int plusStep = step;
				int posRoot = 0;
				int min = int.MaxValue;
				int posMin;

				while (arr[posRoot] != 0) posRoot++;

				posMin = posRoot;
				step++;

				if (step % 2 != 0)
				{
					for (int i = start; i < posRoot; i++)
					{
						if (arr[i] == 1 && (posRoot - i) < min && (posRoot - i) <= 2)
						{
							min = posRoot - i;
							posMin = i;
							checkLeft = true;
						}
					}

					if (!checkLeft && arr[posRoot + 2] == 1)
						posMin = posRoot + 2;
				}
				else
				{
					for (int i = end; i > posRoot; i--)
					{
						if (arr[i] == 2 && Math.Abs(posRoot - i) < min && Math.Abs(posRoot - i) <= 2)
						{
							min = Math.Abs(posRoot - i);
							posMin = i;
							checkRight = true;
						}
					}

					if (!checkRight && arr[posMin - 2] == 2)
						posMin = posRoot - 2;
				}

				if (posMin == posRoot && step % 2 != 0)
				{
					posMin = posRoot - 1;
					plusStep++;
				}
				else if (posMin == posRoot && step % 2 == 0)
				{
					posMin = posRoot + 1;
					plusStep++;
				}

				swapButton(ref arrButton[posRoot], ref arrButton[posMin], ref posRoot, ref posMin);


				lbBuoc.Text = step.ToString();

				if (arrBalls[start] == arr[start]) start++;

				if (arrBalls[end] == arr[end]) end--;

				bool checkOut = true;
				for (int i = 0; i < nArr; i++)
					if (arrBalls[i] != arr[i])
						checkOut = false;

				if (checkOut)
					break;

				step = plusStep;
				step++;
			}

			MessageBox.Show("Hoàn thành !");
		}
	}
}
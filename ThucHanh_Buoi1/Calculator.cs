using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh_Buoi1
{
    public partial class Calculator : Form
    {
        string soThu1 = "";
        string soThu2 = "";
        string dau = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void thayĐổiMàuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control ctrl in this.tableLayoutPanel1.Controls)
                    {
                        if (ctrl is Button)
                        {
                            ctrl.ForeColor = colorDialog.Color;
                        }
                    }
                }
            }
        }

        private void thayĐổiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control ctrl in this.tableLayoutPanel1.Controls)
                    {
                        if (ctrl is Button)
                        {
                            ctrl.Font = fontDialog.Font;
                        }
                    }
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Font = fontDialog.Font;
                        }
                    }
                }
            }
        }

        private void button_calculator(object sender, EventArgs e)
        {
            double so1, so2;
            try
            {
                so1 = Convert.ToDouble(soThu1);
                so2 = Convert.ToDouble(soThu2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập bị lỗi!!!" + soThu1.ToString() + " - " + soThu2.ToString());
                textBox_bieuThuc.Text = "";
                soThu1 = "";
                soThu2 = "";
                dau = "";
                return;
            }
            double ketQua = 0;
            switch (dau)
            {
                case "+": ketQua = so1 + so2; break;
                case "-": ketQua = so1 - so2; break;
                case "*": ketQua = so1 * so2; break;
                case "/": ketQua = so1 / so2; break;
            }
            textBox_ketQua.Text = ketQua.ToString();
        }

        private void button_numberClick(object sender, EventArgs e)
        {
            Button buttonCLick = sender as Button;
            if (buttonCLick != null)
            {
                textBox_bieuThuc.Text = soThu1 + " " + dau + " " + soThu2;
                if (dau.Length == 0) soThu1 += buttonCLick.Text;
                else soThu2 += buttonCLick.Text;
            }
        }

        private void button_dauClick(object sender, EventArgs e)
        {
            Button buttonCLick = sender as Button;
            if (buttonCLick != null)
            {
                if (dau.Length == 0)
                {
                    textBox_bieuThuc.Text += buttonCLick.Text;
                    dau = buttonCLick.Text;
                }
                else
                {
                    soThu1 = textBox_ketQua.Text;
                }
            }
        }
    }
}

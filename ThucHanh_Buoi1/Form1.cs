using System;
using System.Windows.Forms;

namespace ThucHanh_Buoi1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }
        private void ToolStripMenuItem_doiMau(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem == null) return;

            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            if (owner == null || owner.SourceControl == null) return;

            Control clickedControl = owner.SourceControl;

            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    clickedControl.ForeColor = colorDialog.Color;
                }
            }
        }
        private void ToolStripMenuItem_doiFont(object sender, EventArgs e)
        {
            //Lấy menu item được chọn
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem == null) return;

            ////Lấy menu được chọn chứa menu item được chọn
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            if (owner == null || owner.SourceControl == null) return;

            ////Lấy control chứa menu đó ( chính là label được chọn)
            Control clickedControl = owner.SourceControl;

            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    clickedControl.Font = fontDialog.Font;
                }
            }
        }
        private void button_tinh_Click(object sender, EventArgs e)
        {
            int a, b, c;
            try
            {
                a = Convert.ToInt32(textBox_soA.Text);
                b = Convert.ToInt32(textBox_soB.Text);
                c = Convert.ToInt32(textBox_soC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi định dạng số a, b, c");
                textBox_soA.Text = "";
                textBox_soB.Text = "";
                textBox_soC.Text = "";
                return;
            }
            double x1, x2;
            double delta = b*b - 4*a*c;
            if (delta > 0)
            {
                x1 = (-b - Math.Pow(delta, 0.5)) / 2;
                x2 = (-b + Math.Pow(delta, 0.5)) / 2;
                label_x1.Text = "X1: " + Convert.ToString(x1);
                label_x2.Text = "X2: " + Convert.ToString(x2);
            }
            else if (delta == 0)
            {
                x1 = -b / 2;
                x2 = -b / 2;
                label_x1.Text = "X1: " + Convert.ToString(x1);
                label_x2.Text = "X2: " + Convert.ToString(x2);
            }
            else
            {
                MessageBox.Show("Lỗi nhập số a, b, c");
            }
        }
    }
}

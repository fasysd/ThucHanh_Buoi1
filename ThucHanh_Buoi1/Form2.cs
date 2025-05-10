using System;
using System.Windows.Forms;

namespace ThucHanh_Buoi1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            if (menu == null || menu.SourceControl == null) return;

            Control clickedControl = menu.SourceControl;

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

            //Mở Dialog chọn font
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    clickedControl.Font = fontDialog.Font;
                }
            }
        }

        private void button_xacNhan_Click( object sender, EventArgs e)
        {
            string a, b;
            string nghichA = "";
            string nghichB = "";

            a = textBox_a.Text;
            b = textBox_b.Text;
            if( a.Length * b.Length == 0)
            {
                MessageBox.Show("Hãy nhập đủ a và b!!!");
                return;
            }

            label_soLanLap.Text = (a.Length > b.Length)
                ? "Số lần xuất hiện chuỗi b trong chuỗi a: " + CountNonOverlapping(a, b).ToString()
                : "Số lần xuất hiện chuỗi a trong chuỗi b: " + CountNonOverlapping(b, a).ToString();

            for (int i = 0; i < a.Length; i++)
            {
                nghichA += a[a.Length - i - 1];
            }
            for (int i = 0; i < b.Length; i++)
            {
                nghichB += b[b.Length - i - 1];
            }
            label_nghichDaoA.Text = "Chuỗi nghịch đảo của a: " + nghichA;
            label_nghichDaoB.Text = "Chuỗi nghịch đảo của b: " + nghichB;
        }
        private int CountNonOverlapping(string text, string pattern)
        {
            int count = 0;
            int i = 0;

            while (i <= text.Length - pattern.Length)
            {
                if (text.Substring(i, pattern.Length) == pattern)
                {
                    count++;
                    i += pattern.Length;
                }
                else
                {
                    i++;
                }
            }

            return count;
        }
    }
}

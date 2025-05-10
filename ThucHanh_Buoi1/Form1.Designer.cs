namespace ThucHanh_Buoi1
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_soA = new System.Windows.Forms.TextBox();
            this.textBox_soB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_soC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_x1 = new System.Windows.Forms.Label();
            this.label_x2 = new System.Windows.Forms.Label();
            this.button_tinh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // textBox_soA
            // 
            this.textBox_soA.Location = new System.Drawing.Point(137, 32);
            this.textBox_soA.Name = "textBox_soA";
            this.textBox_soA.Size = new System.Drawing.Size(100, 22);
            this.textBox_soA.TabIndex = 1;
            // 
            // textBox_soB
            // 
            this.textBox_soB.Location = new System.Drawing.Point(365, 32);
            this.textBox_soB.Name = "textBox_soB";
            this.textBox_soB.Size = new System.Drawing.Size(100, 22);
            this.textBox_soB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số b:";
            // 
            // textBox_soC
            // 
            this.textBox_soC.Location = new System.Drawing.Point(602, 32);
            this.textBox_soC.Name = "textBox_soC";
            this.textBox_soC.Size = new System.Drawing.Size(100, 22);
            this.textBox_soC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số c:";
            // 
            // label_x1
            // 
            this.label_x1.AutoSize = true;
            this.label_x1.Location = new System.Drawing.Point(261, 93);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(28, 16);
            this.label_x1.TabIndex = 6;
            this.label_x1.Text = "X1: ";
            // 
            // label_x2
            // 
            this.label_x2.AutoSize = true;
            this.label_x2.Location = new System.Drawing.Point(261, 120);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(28, 16);
            this.label_x2.TabIndex = 7;
            this.label_x2.Text = "X2: ";
            // 
            // button_tinh
            // 
            this.button_tinh.Location = new System.Drawing.Point(442, 153);
            this.button_tinh.Name = "button_tinh";
            this.button_tinh.Size = new System.Drawing.Size(75, 23);
            this.button_tinh.TabIndex = 8;
            this.button_tinh.Text = "Tính";
            this.button_tinh.UseVisualStyleBackColor = true;
            this.button_tinh.Click += new System.EventHandler(this.button_tinh_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem,
            this.đổiFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu";
            this.đổiMàuToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_doiMau);
            // 
            // đổiFontToolStripMenuItem
            // 
            this.đổiFontToolStripMenuItem.Name = "đổiFontToolStripMenuItem";
            this.đổiFontToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.đổiFontToolStripMenuItem.Text = "Đổi font";
            this.đổiFontToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_doiFont);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 190);
            this.Controls.Add(this.button_tinh);
            this.Controls.Add(this.label_x2);
            this.Controls.Add(this.label_x1);
            this.Controls.Add(this.textBox_soC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_soB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_soA);
            this.Controls.Add(this.label1);
            this.Name = "Bai5";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_soA;
        private System.Windows.Forms.TextBox textBox_soB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_soC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_x1;
        private System.Windows.Forms.Label label_x2;
        private System.Windows.Forms.Button button_tinh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiFontToolStripMenuItem;
    }
}


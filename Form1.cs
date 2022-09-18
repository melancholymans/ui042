using System;
using System.Windows.Forms;

namespace ui042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// Enterキーで押された
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OKボタンがクリックされました");
        }

        /// ESCキーで押された
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("キャンセルボタンがクリックされました");
        }
    }
}

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

        /// <summary>
        /// Enterキーで押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OKボタンがクリックされました");
        }

        /// <summary>
        /// ESCキーで押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("キャンセルボタンがクリックされました");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(this.ReSized);
            WebBrowser.Navigate("https://www.google.co.jp");
        }

        private void Load_Click(object sender, EventArgs e)
        {
            WebBrowser.Navigate(URL.Text);
        }

        private void ReSized(object sender, EventArgs e)
        {
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            WebBrowser.Size = new Size(width, height - 30);
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(1200, 830);
        }
    }
}

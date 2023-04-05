using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.AllowWebBrowserDrop = false;
        }
        class Preglednik
        {
            string url;
            public bool AllowWebBrowserDrop { get; set; }

            public string Url { get => url; set => url = value; }
        }
        class NewTab: Preglednik
        {
            
        }
        List<Preglednik> lista = new List<Preglednik>();
        List<NewTab> tabs = new List<NewTab>();
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //tab
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //bookmark
            try
            {
                Preglednik bm = new Preglednik();
                lista.Add(bm);
            }
            catch{
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Preglednik bm in lista)
            {
                ispis_bm.AppendText(bm.ToString());
            }
        }

        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Preglednik bm in lista)
            {
                ispis_bm.AppendText(bm.ToString());
            }
        }

        private void tabsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

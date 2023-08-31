using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCardLink
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save knop URl
            Properties.Settings.Default.URL =  txturlchanger.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // wijzig knop URL
            Console.WriteLine(Properties.Settings.Default.URL) ;
            
        }

        private void form2_Load(object sender, EventArgs e)
        {
            // textbox voor URL
            txturlchanger.Text = Properties.Settings.Default.URL;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // exit knop URL
            new Main().Show();
            this.Close();
        }
    }
}

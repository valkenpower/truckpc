using System;
using System.Windows.Forms;


namespace BCardLink
{
    public partial class wijzig_url : Form
    {
        public wijzig_url()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save knop URl
            Properties.Settings.Default.URL = txturlchanger.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Sucess we sluiten deze scherm");
            this.Close();
        }
        private void form2_Load(object sender, EventArgs e)
        {
            // textbox voor URL
            txturlchanger.Text = Properties.Settings.Default.URL;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // exit knop URL
            this.Close();
        }
    }
}

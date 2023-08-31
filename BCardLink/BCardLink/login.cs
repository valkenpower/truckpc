using System;
using System.Windows.Forms;


namespace BCardLink
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TopMost = true;
        }
        // login knop
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusername.Text == "maalin" && txtpassword.Text == "123")
            {
                new wijzig_url().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Probeer opnieuw");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }
        }
        // exit knop
        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}

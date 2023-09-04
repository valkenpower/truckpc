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
            
        }
        // login knop
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusername.Text == "Admin" && txtpassword.Text == "Valk132")
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

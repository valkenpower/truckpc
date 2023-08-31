using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCardLink;


namespace BCardLink
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TopMost = true;
        }
        // login knop
        private void button1_Click(object sender, EventArgs e)
        { 
                
            if (txtusername.Text=="maalin" && txtpassword.Text=="123")
            {
                new form2().Show();
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

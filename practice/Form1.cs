using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace practice
{
    public partial class Form1 : Form
    {
        public string email = "sabaawan665@gmail.com", password = "12345";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == email && password == txtPass.Text)
            {
               Dashboard dashboard= new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workARM
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Login = textBox1.Text;
            PresenterRegistration.Login = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Password = textBox2.Text;
            PresenterRegistration.Password = textBox2.Text;
        }

    }
}

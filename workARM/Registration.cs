using System;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

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
            var PresenterRegistration = new PresenterRegistration();
            string Login = this.Login.Text;
            PresenterRegistration.Login = this.Login.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var PresenterRegistration = new PresenterRegistration();
            string Password = this.Password.Text;

            PresenterRegistration.Password = this.Password.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PresenterRegistration = new PresenterRegistration();

            string Login = this.Login.Text;
            PresenterRegistration.Login = this.Login.Text;
            string Password = this.Password.Text;
            PresenterRegistration.Password = this.Password.Text;

            string filePath = "Users2.json";
            var MainLogicRegistration = new MainLogicRegistration();

            MainLogicRegistration.AddUserToJson(filePath, Login, Password);

            JasonFile.SaveRegister();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var PresenterRegistration = new PresenterRegistration();
            MessageBox.Show(PresenterRegistration.Password);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}

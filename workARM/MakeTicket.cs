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
    public partial class MakeTicket : Form
    {
        public MakeTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создана успешно", "Заявка");
            this.Close();
            mainForm1 mainForm1 = new mainForm1();
            mainForm1.Show();
        }

        private void MakeTicket_Load(object sender, EventArgs e)
        {

        }
    }
}

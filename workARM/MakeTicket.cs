using Microsoft.VisualBasic.Logging;
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
         

           var MakeTicketLogic = new MakeTicketLogic();
            string Name = this.Name.Text;
            MakeTicketLogic.Name = this.Name.Text;
            string LastName = this.LastName.Text;
            MakeTicketLogic.LastName = this.LastName.Text;
            string PhoneNumber = this.PhoneNumber.Text;
            MakeTicketLogic.PhoneNumber = this.PhoneNumber.Text;
            string Post = this.Post.Text;
            MakeTicketLogic.Post = this.Post.Text;
            string Model = this.Model.Text;
            MakeTicketLogic.Model = this.Model.Text;
            string Breaking = this.Breaking.Text;
            MakeTicketLogic.Breaking = this.Breaking.Text;

            //AddTicketToJson
            string filePath = "Tickets.json";

           
            var TicketRepository = new TicketRepository();

            TicketRepository.AddTicketToJson(filePath, Name, LastName, PhoneNumber, Post, Model, Breaking);

            JasonFile.SaveRegister();
            TicketRepository.GetTicketsFromJson(filePath);

            mainForm1 mainForm1 = new mainForm1();
            mainForm1.Show();
            this.Close();
        }

        private void MakeTicket_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm1 mainForm1 = new mainForm1();
            mainForm1.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace workARM
{
    public partial class mainForm1 : Form
    {
        public mainForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MakeTicket MakeTicket = new MakeTicket();
            MakeTicket.Show();
        }

        private void mainForm1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
        private void UpdateList()
        {
            List<MakeTicketLogic> tickets = TicketRepository.GetTicketsFromJson("tickets.json");
            listView1.Items.Clear();
            foreach (var ticket in tickets)
            {
                //listView1.Items.Add(ticket.Name.ToString);
                ListViewItem Item = new ListViewItem(ticket.Name);

                //listView1.Items[lineIndex].SubItems.Add(ticket.Name.ToString());
                Item.SubItems.Add(ticket.LastName.ToString());
                Item.SubItems.Add(ticket.PhoneNumber.ToString());
                Item.SubItems.Add(ticket.Post.ToString());
                Item.SubItems.Add(ticket.Model.ToString());
                Item.SubItems.Add(ticket.Breaking.ToString());

                listView1.Items.Add(Item);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems();
        }
        private void DeleteSelectedItems()
        {
            List<MakeTicketLogic> tickets = TicketRepository.GetTicketsFromJson("tickets.json");
            // Проверяем, есть ли выбранные элементы в ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Получаем индексы выбранных элементов в обратном порядке
                List<int> indexesToRemove = new List<int>();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    indexesToRemove.Add(item.Index);
                }
                indexesToRemove.Reverse(); // Обратный порядок для правильного удаления элементов

                // Удаляем выбранные элементы из списка Vive
                foreach (int index in indexesToRemove)
                {
                    tickets.RemoveAt(index);
                }

                // Удаляем выбранные элементы из ListView
                foreach (int index in indexesToRemove)
                {
                    listView1.Items.RemoveAt(index);
                }
            }
        }
    }
}

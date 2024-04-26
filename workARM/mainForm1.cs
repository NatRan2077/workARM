using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
                
                ListViewItem Item = new ListViewItem(ticket.Name);

               
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
            //RemoveTicketFromJson();
        }
        private void DeleteSelectedItems()
        {
            string filePath = "tickets.json";
            List<MakeTicketLogic> tickets = TicketRepository.GetTicketsFromJson("tickets.json");
            
            if (listView1.SelectedItems.Count > 0)
            {
               
                List<int> indexesToRemove = new List<int>();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    indexesToRemove.Add(item.Index);
                }
                indexesToRemove.Reverse(); 

                
                foreach (int index in indexesToRemove)
                {
                    tickets.RemoveAt(index);
                }

               
                foreach (int index in indexesToRemove)
                {
                    listView1.Items.RemoveAt(index);
                }
            }
        }
            //private void RemoveTicketFromJson(string filePath, int index)
            //{
            //    try
            //    {
            //        // Проверяем существование файла
            //        if (!File.Exists(filePath))
            //        {
            //            Console.WriteLine("Файл не найден");
            //            return;
            //        }

            //        // Считываем содержимое файла и десериализуем его в список заявок
            //        string jsonContent = File.ReadAllText(filePath);
            //        List<MakeTicketLogic> tickets = JsonConvert.DeserializeObject<List<MakeTicketLogic>>(jsonContent);

            //        // Удаляем заявку с указанным индексом из списка
            //        if (index >= 0 && index < tickets.Count)
            //        {
            //            tickets.RemoveAt(index);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Индекс выходит за границы списка");
            //            return;
            //        }

            //        // Записываем обновленные данные в файл
            //        string updatedJsonData = JsonConvert.SerializeObject(tickets);
            //        File.WriteAllText(filePath, updatedJsonData);

            //        Console.WriteLine("Заявка удалена успешно из JSON файла");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Произошла ошибка при удалении заявки из JSON файла: " + ex.Message);
            //    }
            //}
        
    }

}
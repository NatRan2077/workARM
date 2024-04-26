using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace workARM
{
    public class TicketRepository
    {
        public void AddTicketToJson(string filePath, string name, string lastname,string phoneNumber, string post, string Model, string breaking)
        {
            try
            {
                List<MakeTicketLogic> ticket;

                // Проверяем существование файла
                if (File.Exists(filePath))
                {
                    // Если файл существует, считываем его содержимое
                    string jsonContent = File.ReadAllText(filePath);
                    ticket = JsonConvert.DeserializeObject<List<MakeTicketLogic>>(jsonContent);
                }
                else
                {
                    // Если файл не существует, создаем новый список пользователей
                    ticket = new List<MakeTicketLogic>();
                }

                // Добавляем нового пользователя в список
                ticket.Add(new MakeTicketLogic { Name = name, LastName = lastname, PhoneNumber = phoneNumber,Post = post,Model = Model,Breaking = breaking });

                // Записываем обновленные данные в файл
                string jsonData = JsonConvert.SerializeObject(ticket);
                File.WriteAllText(filePath, jsonData);

                MessageBox.Show("Заявка создана успешно");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        public static List<MakeTicketLogic> GetTicketsFromJson(string filePath)
        {
            try
            {
                // Проверяем существование файла
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Файл не найден");
                    return new List<MakeTicketLogic>();
                }

                // Считываем содержимое файла и десериализуем его в список заявок
                string jsonContent = File.ReadAllText(filePath);
                List<MakeTicketLogic> tickets = JsonConvert.DeserializeObject<List<MakeTicketLogic>>(jsonContent);

                return tickets;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                return new List<MakeTicketLogic>();
            }
        }
    }  
}    
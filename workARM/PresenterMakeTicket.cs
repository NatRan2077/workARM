using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workARM
{
    public class PresenterMakeTicket
    {
        private IMakeTicketLogic _ticketMaker = new MakeTicketLogic();
        public void ReadList(string filePath)
        {
            try
            {
                // Проверяем существование файла
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Файл не найден.");
                    return;
                }

                // Открываем файл и считываем его содержимое
                string jsonContent = File.ReadAllText(filePath);

                // Разбираем JSON содержимое
                JObject jsonData = JObject.Parse(jsonContent);

                // Получаем данные из файла
                _ticketMaker.Name = jsonData["Name"]?.ToString();
                _ticketMaker.LastName = jsonData["LastName"]?.ToString();
                _ticketMaker.PhoneNumber = jsonData["PhoneNumber"]?.ToString();
                _ticketMaker.Post = jsonData["Post"]?.ToString();
                _ticketMaker.Model = jsonData["Model"]?.ToString();
                _ticketMaker.Breaking = jsonData["Breaking"]?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }

        }


    }
}

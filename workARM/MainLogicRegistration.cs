using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace workARM
{
    public class MainLogicRegistration
    {
       
        public void CheckCredentials(string filePath, string Login, string Password)
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
                string fileLogin = jsonData["Login"]?.ToString();
                string filePassword = jsonData["Password"]?.ToString();


                // Проверяем совпадение данных
                if (Login == fileLogin && Password == filePassword)
                {
                    mainForm1 mainForm = new mainForm1();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Не верный пароль или логин");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        public void AddUserToJson(string filePath, string login, string password)
        {
            try
            {
                JObject jsonData;

                // Проверяем существование файла
                if (File.Exists(filePath))
                {
                    // Если файл существует, считываем его содержимое
                    string jsonContent = File.ReadAllText(filePath);
                    jsonData = JObject.Parse(jsonContent);

                    // Проверяем, существует ли уже такой логин
                    if (jsonData[login] != null)
                    {
                        MessageBox.Show("Такой логин уже существует");
                        return;
                    }
                }
                else
                {
                    // Если файл не существует, создаем новый объект JSON
                    jsonData = new JObject();
                }

                // Добавляем логин и пароль в JSON объект
                jsonData["Login"] = login;
                jsonData["Password"] = password;



                // Записываем обновленные данные в файл
                File.WriteAllText(filePath, jsonData.ToString());

                MessageBox.Show("Регистрация успешна");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
                
            }
        }
    }
}
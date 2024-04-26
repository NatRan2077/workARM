using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace workARM
{
    public class MainLogicRegistration
    {
        public static bool CheckCredentials(string filePath, string login, string password)
        {
            try
            {
                // Проверяем существование файла
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Файл не найден");
                    return false;
                }

                // Считываем содержимое файла и десериализуем его в список пользователей
                string jsonContent = File.ReadAllText(filePath);
                List<PresenterRegistration> users = JsonConvert.DeserializeObject<List<PresenterRegistration>>(jsonContent);

                // Проверяем наличие пользователя с заданным логином и паролем
                if (users.Exists(u => u.Login == login && u.Password == password))
                {
                    mainForm1 mainForm = new mainForm1();
                    mainForm.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Не верный пароль или логин");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
                return false;
            }
        }
  
        public static void AddUserToJson(string filePath, string login, string password)
        {
            try
            {
                List<PresenterRegistration> users;

                // Проверяем существование файла
                if (File.Exists(filePath))
                {
                    // Если файл существует, считываем его содержимое
                    string jsonContent = File.ReadAllText(filePath);
                    users = JsonConvert.DeserializeObject<List<PresenterRegistration>>(jsonContent);

                    // Проверяем, существует ли уже такой логин
                    if (users.Exists(u => u.Login == login && login != null))
                    {
                        MessageBox.Show("Такой логин уже существует");
                        return;
                    }
                }
                else
                {
                    // Если файл не существует, создаем новый список пользователей
                    users = new List<PresenterRegistration>();
                }

                // Добавляем нового пользователя в список
                users.Add(new PresenterRegistration { Login = login, Password = password });

                // Записываем обновленные данные в файл
                string jsonData = JsonConvert.SerializeObject(users);
                File.WriteAllText(filePath, jsonData);

                MessageBox.Show("Регистрация успешна");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
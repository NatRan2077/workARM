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
                
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Файл не найден");
                    return false;
                }

                
                string jsonContent = File.ReadAllText(filePath);
                List<PresenterRegistration> users = JsonConvert.DeserializeObject<List<PresenterRegistration>>(jsonContent);

                if (users.Exists(u => u.Login == login && u.Password == password && u.Login.Length != 0 && u.Password.Length != 0))
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

                
                if (File.Exists(filePath))
                {
                 
                    string jsonContent = File.ReadAllText(filePath);
                    users = JsonConvert.DeserializeObject<List<PresenterRegistration>>(jsonContent);

                    
                    if (users.Exists(u => u.Login == login && u.Login.Length == 0))
                    {
                        MessageBox.Show("Ошибка");
                       
                    }
                }
                else
                {
                  
                    users = new List<PresenterRegistration>();
                }

               
                users.Add(new PresenterRegistration { Login = login, Password = password });

                
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
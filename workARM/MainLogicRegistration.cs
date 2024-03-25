using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace workARM
{
     public class MainLogicRegistration   
    {
        public void Register(string Login, string Password)
        {
            if (!File.Exists("User.json"))
            {
                File.Create("User.json").Close();
            }
            string jasonData = File.ReadAllText("User.json");

            List<PresenterRegistration> user = JsonConvert.DeserializeObject<List<PresenterRegistration>>(jasonData) ?? new List<PresenterRegistration>();

            if (user.Exists(u => u.Login == Login)) 
            {
                //exeption логин уже есть
                MessageBox.Show("Такой логин уже существует");
                return;
            }
            PresenterRegistration newUser = new PresenterRegistration { Login = Login, Password = Password };
            user.Add(newUser);

            string updatejsonData = JsonConvert.SerializeObject(user, Formatting.Indented);
            File.WriteAllText("User.Json", updatejsonData);

            MessageBox.Show("Вы успешно зарегистрировались");
        }


    }
}

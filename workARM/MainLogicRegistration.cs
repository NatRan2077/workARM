using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace workARM
{
    internal class MainLogicRegistration : PresenterRegistration
    {
        static void Register(string login, string password)
        {
            if (!File.Exists("User.json"))
            {
                File.Create("User.json").Close();
            }
            string jasonData = File.ReadAllText("User.json");

            List<PresenterRegistration> user = JsonConvert.DeserializeObject<List<PresenterRegistration>>(jasonData) ?? new List<PresenterRegistration>();

            if (user.Exists(u => u.Login == login)) 
            {
                //exeption логин уже есть
                return;
            }
            PresenterRegistration newUser = new PresenterRegistration { Login = login, Password = password };
            user.Add(newUser);

            string updatejsonData = JsonConvert.SerializeObject(user, Formatting.Indented);
            File.WriteAllText("User.Json", updatejsonData);
        }
    }
}

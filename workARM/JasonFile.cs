//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace workARM
{
    public static class JasonFile 
    {
        public static void SaveRegister()
        {
            var PresenterRegistration = new PresenterRegistration();

            string objectSerialized = JsonSerializer.Serialize(PresenterRegistration);
            File.WriteAllText("Register.json", objectSerialized);

        }

    }
}

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
    public class JasonFile
    {
        public void SaveRegister()
        {
            var PresenterRegistration = new PresenterRegistration();

            string objectSerialized = JsonSerializer.Serialize(PresenterRegistration);
            File.WriteAllText("Register.json", objectSerialized);

        }

    }
}

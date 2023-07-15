using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SwatchBoutique
{
    public class USER
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int BankCard { get; set; }


        public static List<USER> LoadUsers()
        {
            string usersJson = File.ReadAllText("Data/DataOfRegisteredUsers.json");
            return JsonSerializer.Deserialize<List<USER>>(usersJson);
            
        }

        public void SaveToJson(List<USER> u)
        {
            string usersJson = JsonSerializer.Serialize(u);
            File.WriteAllText("Data/DataOfRegisteredUsers.json", usersJson);
        }

        public static USER Loading()
        {
            string usersJson = File.ReadAllText("Data/SignedAccaount.json");
            return JsonSerializer.Deserialize<USER>(usersJson);

        }

        public void Saving(USER u)
        {
            string usersJson = JsonSerializer.Serialize(u);
            File.WriteAllText("Data/SignedAccaount.json", usersJson);
        }



    }
}

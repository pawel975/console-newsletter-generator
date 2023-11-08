using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_newsletter_generator
{
    public class Services
    {
        static private readonly string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Data\user-data.json");
        static private List<User> FetchUsersFromJson()
        {
            string jsonData = File.ReadAllText(jsonPath);
            return JsonConvert.DeserializeObject<List<User>>(jsonData);
        }

        static private void UpdateUsersJson(List<User> users)
        {
            var serializedUsers = JsonConvert.SerializeObject(users);
            File.WriteAllText(serializedUsers, jsonPath);
        }

        static public List<User> users = FetchUsersFromJson();

        static public User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        static public User GetUserByName(string name)
        {
            return users.FirstOrDefault(u => u.Name == name);
        }

        static public List<User> GetAllUsers()
        {
            return users;
        }

        static public void AddUser(User user)
        {
            users.Add(user);
            UpdateUsersJson(users);
            // TODO: Test if .json updates
        }

        static public void RemoveUser(User user)
        {
            users.Remove(user);
            UpdateUsersJson(users);
            // TODO: Test if .json updates
        }


    }
}


using console_newsletter_generator;
using Newtonsoft.Json;

namespace ConsoleNewsletterGenerator
{
    class Program
    {
        static List<User> FetchUsersFromJson()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            string jsonPath = Path.Combine(currentDirectory, @"..\..\..\Data\user-data.json");
            string jsonData = File.ReadAllText(jsonPath);
            return JsonConvert.DeserializeObject<List<User>>(jsonData);
        }
        static void Main(string[] args)
        {
            List<User> users = FetchUsersFromJson();
            
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}
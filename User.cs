using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNewsletterGenerator
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Discount { get; set; }
        public DateTime MemeberSinceDate { get; set; }

        public User(int id, string name, string email, int discount)
        {
            Id = id;
            Name = name;
            Email = email;
            Discount = discount;
            MemeberSinceDate = DateTime.Now;
        }
    }
}

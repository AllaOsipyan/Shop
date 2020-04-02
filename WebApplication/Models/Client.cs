using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WebApplication.Models
{
    public class Client : IdentityUser
    {
        public int id { get; set; }
        public string userName { get ; set; }
        public string password { get; set; }
        public string email { get; set; }
        public static List<Client> users = new List<Client>();

        public Client(string userName, string password, string email)
        {
            this.id = users.Count;
            this.userName = userName;
            this.password = password;
            this.email = email;
        }

        public Client(){}
        
        public static Client getUserByLogin(string login)
        {
            
            foreach (var el in users)
            {
                if (el.userName.Equals(login))
                {
                    return el;
                }

            }

            return null;
        }

    }
    
    
}
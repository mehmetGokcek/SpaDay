using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Data
{
    public class UserData
    {
        static private List<User> user = new List<User>();

        // GetAll
        public static IEnumerable<User> GetAll()
        {
            return user;
        }

        // Add
        public static void Add(User newUser)
        {
            user.Add(newUser);
        }

        // Remove
  /*      public static void Remove(int id)
        {
            Events.Remove(id);
        }*/

        // GetById
 /*       public static Event GetById(int id)
        {
            return Events[id];
        }*/

       /* public static void Edit(int eventId, string name, string description)
        {
            foreach (Event item in GetAll())
            {
                if (item.Id == eventId)
                {
                    item.Name = name;
                    item.Description = description;
                }
            }
        }*/
    }
}
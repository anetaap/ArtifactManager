using System;
using System.Linq;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.DataBase.Context
{
    public class MyDbContextFunctions
    {
        public static bool UserExist(string username)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    var user = db.Users
                        .Single(u => u.Username == username);
                    if (user != null) return true;
                }
                catch (Exception e)
                {

                }
                return false;  
            }
        }
        public static bool EmailExist(string email)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    var user = db.Users
                        .Single(u => u.Email == email);
                    if (user != null) return true;
                }
                catch (Exception)
                {

                }
                return false;  
            }
        }

        public static string GetPassword(string username)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);

                return user.Password;
            }
        }

        public static void AddUser(string username, string name, string lastname, string email, string password)
        {
            int roleid = 1;

            using (MyDbContext db = new MyDbContext())
            {
                db.Users.Add(new User()
                {
                    Username = username,
                    Name = name,
                    Lastname = lastname,
                    Email = email,
                    Password = password,
                    RoleId = roleid
                });
                db.SaveChanges();
            }
        }
        
        // TODO create function that adds new role
        // TODO create function that collects all information about user
        // TODO create function that updates user password
        // TODO create function that updates user information 
        // TODO implement function that delete user from database and all related with it information
    }
}
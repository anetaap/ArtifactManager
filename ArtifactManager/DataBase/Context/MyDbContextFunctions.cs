using System;
using System.Linq;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.DataBase.Context
{
    public class MyDbContextFunctions
    {
        // function checks if user exist in database
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
        
        // function checks if e-mail address exists in database
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
        // function checks if e-mail address exists in database
        public static string EmailOfUser(string email)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    var user = db.Users
                        .Single(u => u.Email == email);
                    return user.Username;
                }
                catch (Exception)
                {

                }
                return null;  
            }
        }

        // function gets password of user from database
        public static string GetPassword(string username)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);

                return user.Password;
            }
        }
        
        //functions gets all the information about user from daatabase
        public static string[] GetInformation(string username)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);

                string[] information = {user.Name, user.Lastname, user.Username, user.Email};
                return information;
            }
        }

        //function adds new user to database
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
        
        // function updates password in database
        public static void ChangePassword(string username, string password)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);

                user.Password = password;
                db.SaveChanges();
            }
        }
        
        // function that checks if user is a admin
        public static bool IsAdmin(string username)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);

                if (user.Role.RoleName == "Admin") return true;
                return false;
            }
        }
        
        //function that removes user from database
        public static void RemoveUser(string username)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);

                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        // function that changes information about user in database
        public static void ChangeInformation(string username, string name, string lastname, string email)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);
                
                user.Name = name;
                user.Lastname = lastname;
                user.Email = email;
                
                db.SaveChanges();
            }
        }

        // TODO create function that adds new role
        // TODO create function that adds new category
        // TODO implement function that delete user from database and all related with it information
    }
}
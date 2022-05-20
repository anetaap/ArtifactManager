using System;
using System.Collections.Generic;
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
                catch (Exception)
                {
                    return false; 
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
                    return false; 
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
                    return null; 
                }
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
        
        // function that returns all the users categories
        public static List<Category> GetUserCategories(string username)
        {
            List<Category> categories;
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);

                int id = user.UserId;
                
                try
                {
                    categories = db.Categories
                        .Where(category => category.UserId == id).ToList();
                    return categories;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
        
        // function that adds new Category 
        public static void AddCategory(string categoryName, int userId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Categories.Add(new Category()
                {
                    UserId = userId,
                    CategoryName = categoryName
                });
                db.SaveChanges();
            }
        }
        
        // function that adds Attribute to Category
        public static void AddCategoryAttribute(string name, string type, int categoryId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.CategoryAttributes.Add(new CategoryAttribute()
                {
                    CategoryAttributeName = name,
                    CategoryAttributeType = type,
                    CategoryId = categoryId
                });
                db.SaveChanges();
            }
        }
        
        // function that adds new Element
        public static void AddElement(string elementName, int categoryId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Elements.Add(new Element()
                {
                    CategoryId = categoryId,
                    ElementName = elementName
                });
                db.SaveChanges();
            }
        }
        
        //function that adds new Attribute to element
        public static void AddElementAttribute(string name, string type, int elementId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.ElementAttributes.Add(new ElementAttribute()
                {
                    ElementAttributeName = name,
                    ElementAttributeType = type,
                    ElementId = elementId
                });
                db.SaveChanges();
            }
        }

        // TODO function that returns attribute type for category and element 
        // TODO create function that adds new role
        // TODO implement function that delete user from database and all related with it information
    }
}
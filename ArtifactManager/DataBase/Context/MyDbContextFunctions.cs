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
        // function that returns user
        public static User GetUser(int userId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.UserId == userId);

                return user;
            }
        }
        
        // function that returns all users
        public static List<User> GetAllUsers()
        {
            using (MyDbContext db = new MyDbContext())
            {
                var users = db.Users.ToList();

                return users;
            }
        }
        
        // returns user id 
        public static int GetUserId(string username)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.Username == username);

                return user.UserId;
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
        
        //functions gets all the information about user from database
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
        
        // function that returns all categories
        public static List<Category> GetAllCategories()
        {
            List<Category> categories;
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    categories = db.Categories.ToList();
                    return categories;
                }
                catch (Exception )
                {
                    return null;
                }
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
                        .Where(category => category.UserId == id || category.UserId == 0).ToList();
                    return categories;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
        
        // function that adds Category 
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
        // function that returns categoryId
        public static int GetCategoryId(string categoryName, string id)
        {
            int userId = int.Parse(id);
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    var category = db.Categories
                        .Single(cat => cat.UserId == userId && cat.CategoryName == categoryName);
                    return category.CategoryId;
                }
                catch (Exception )
                {
                    return -1;
                }
            }
        }
        
        // function that returns category attributes
        public static List<CategoryAttribute> GetCategoryAttributes(int categoryId)
        {
            List<CategoryAttribute> categoryAttributes;
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    categoryAttributes = db.CategoryAttributes
                        .Where(cat => cat.CategoryId == categoryId).ToList();
                    return categoryAttributes;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
        
        // function that adds Attribute to Category
        public static void AddCategoryAttribute(string[] data)
        {
            int categoryId = GetCategoryId(data[2], data[3]);
            if (categoryId != -1)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.CategoryAttributes.Add(new CategoryAttribute()
                    {
                        CategoryAttributeName = data[0],
                        CategoryAttributeType = data[1],
                        CategoryId = categoryId
                    });
                    db.SaveChanges();
                }
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
        
        // function that returns id of Element
        public static int GetElementId(string elementName, int categoryId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var element = db.Elements
                    .Single(e => e.ElementName == elementName && e.CategoryId == categoryId);

                return element.ElementId;
            }
        }
        
        //function that adds Attribute to element
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
        
        // function that returns Element Attribute type
        public static string ElementAttributeType(int elementAttributeId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var attribute = db.ElementAttributes
                    .Single(a => a.ElementAttributeId == elementAttributeId);

                return attribute.ElementAttributeType;
            }
        }
        
        // function that returns all Elements from given categories 
        public static List<Element> GetCategoryElements(int categoryId)
        {
            List<Element> elements;
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    elements = db.Elements
                        .Where(element => element.CategoryId == categoryId).ToList();
                    return elements;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        } 
        
        // function that returns user categories
        public static List<UserCategory> GetUserCategories(int userId)
        {
            List<UserCategory> userCategories;
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    userCategories = db.UserCategories
                        .Where(cat => cat.UserId == userId).ToList();
                    return userCategories;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
        
        // function that returns all users categories 
        public static List<UserCategory> GetAllUserCategories()
        {
            List<UserCategory> userCategories;
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    userCategories = db.UserCategories.ToList();
                    return userCategories;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }

        // function that returns all the artifacts for given category
        public static List<Artifact> GetCategoryArtifacts(int categoryId)
        {
            List<Artifact> artifacts;
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    artifacts = db.Artifacts
                        .Where(artifact => artifact.UserCategoryId == categoryId).ToList();
                    return artifacts;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }

        // function that returns all the artifact element parameters
        public static List<UserArtifactAttribute> GetAllArtifactAttributes()
        {
            List<UserArtifactAttribute> artifactAttributes;
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    artifactAttributes = db.UserArtifactAttributes.ToList();
                    return artifactAttributes;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
        
         // function that returns all category parameters
        public static List<UserCategoryAttribute> GetUserCategoryAttributes(int categoryId)
        {
            List<UserCategoryAttribute> categoryAttributes;
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    categoryAttributes = db.UserCategoryAttributes
                        .Where(artifact => artifact.UserCategoryId == categoryId).ToList();
                    return categoryAttributes;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
        
        // function that adds artifact
        public static int AddArtifact(string name, int userCategoryId, int elementId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Artifacts.Add(new Artifact()
                {
                    ArtifactName = name,
                    UserCategoryId = userCategoryId,
                    ElementId = elementId
                });
                db.SaveChanges();

                var newArtifact = db.Artifacts
                    .Single(a => a.ArtifactName == name && a.UserCategoryId == userCategoryId 
                                                       && a.ElementId == elementId);
                return newArtifact.ArtifactId;
            }
        }
        
        // function that updates artifact
        public static void UpdateArtifact(int artifactId, string name, int categoryId, int elementId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var artifact = db.Artifacts
                    .Single(a => a.ArtifactId == artifactId);

                artifact.ArtifactName = name;
                artifact.UserCategoryId = categoryId;
                artifact.ElementId = elementId;
                
                db.SaveChanges();
            }
        }
        
        // function that updates artifact category parameters
        public static void UpdateUserCategoryAttribute(int userCategoryAttributeId, string value, int attributeId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var artifactCategory = db.UserCategoryAttributes
                    .Single(a => a.UserCategoryAttributeId == userCategoryAttributeId);
        
                artifactCategory.CategoryAttributeValue = value;
                artifactCategory.CategoryAttributeId = attributeId;
        
                db.SaveChanges();
            }
        }
        
        //function that updates artifact parameters
        public static void UpdateArtifactAttributes(int artifactAttributeId, string value)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var artifactElement = db.UserArtifactAttributes
                    .Single(a => a.UserArtifactAttributeId == artifactAttributeId);
        
                artifactElement.ElementAttributeValue = value;

                db.SaveChanges();
            }
        }
        
        // function that removes artifact
        public static void RemoveArtifact(int artifactId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var artifact = db.Artifacts
                    .Single(a => a.ArtifactId == artifactId);

                db.Artifacts.Remove(artifact);
                db.SaveChanges();
            }
        }
        
        // function that gets all the artifacts 
        public static List<Artifact> GetAllArtifactsDesc()
        {
            List<Artifact> artifacts;
            using (MyDbContext db = new MyDbContext())
            {
                artifacts = db.Artifacts
                    .OrderByDescending(a => a.ArtifactId).ToList();
                return artifacts;
            }
        }
        
        // function that gets all user the artifacts 
        public static List<Artifact> GetUserArtifactsDesc(int userId)
        {
            List<Artifact> artifacts;
            using (MyDbContext db = new MyDbContext())
            {
                artifacts = db.Artifacts
                    .Where(art=> art.UserCategory.UserId == userId)
                    .OrderByDescending(a => a.ArtifactId).ToList();
                return artifacts;
            }
        }
        
        // function that add artifact attributes
        public static void AddArtifactAttribute(int artifactId, int elementAttributeId, string value)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.UserArtifactAttributes.Add(new UserArtifactAttribute()
                {
                    ArtifactId = artifactId,
                    ElementAttributeValue = value,
                    ElementAttributeId = elementAttributeId
                });
                db.SaveChanges();
            }
        }
        
        // function that returns element attributes
        public static List<ElementAttribute> GetAllElementAttributes()
        {
            List<ElementAttribute> elementAttributes;
            using (MyDbContext db = new MyDbContext())
            {
                elementAttributes = db.ElementAttributes.ToList();

                return elementAttributes;
            }
        }
        
        // function that adds user category
        public static int AddUserCategory(int categoryId, string categoryName, int userId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.UserCategories.Add(new UserCategory()
                {
                    CategoryId = categoryId,
                    CategoryName = categoryName,
                    UserId = userId
                });
                db.SaveChanges();

                var newUserCategory = db.UserCategories
                    .Single(c => c.CategoryId == categoryId && c.CategoryName == categoryName
                                                            && c.UserId == userId);
                return newUserCategory.UserCategoryId;
            }
        }

        // function that adds user category attribute
        public static void AddUserCategoryAttribute(int categoryAttributeId, int userCategoryId, string value)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.UserCategoryAttributes.Add(new UserCategoryAttribute()
                {
                    CategoryAttributeId = categoryAttributeId,
                    CategoryAttributeValue = value,
                    UserCategoryId = userCategoryId
                });
                db.SaveChanges();
            }
        }
        
        // public function that gets all categories which name is "Postać"
        public static List<Artifact> GetAllCharacters(int userId)
        {
            List<Artifact> artifacts;
            using (MyDbContext db = new MyDbContext())
            {
                artifacts = db.Artifacts
                    .Where(art=> art.UserCategory.UserId == userId)
                    .OrderByDescending(a => a.ArtifactId).ToList();
                return artifacts;
            }
        }
        
        // function that returns user role name
        public static string GetUserRoleName(int userId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.UserId == userId);
                return user.Role.RoleName;
            } 
        }
        // function update role
        public static void ChangeRole(int userId)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users
                    .Single(u => u.UserId == userId);

                if (user.RoleId == 1) user.RoleId = 2;
                else user.RoleId = 1;
                db.SaveChanges();
            }
        }

        // function that gets all characters 
        public static Dictionary<string, string> GetAllCharacters()
        {
            Dictionary<string, string> charactersPower = new Dictionary<string, string>();
            List<UserCategory> category;
            List<Artifact> characters;
            List<UserArtifactAttribute> charactersAttribute;
            using (MyDbContext db = new MyDbContext())
            {
                category = db.UserCategories
                    .Where(c => c.CategoryId == 2).ToList();

                foreach (var cat in category)
                {
                    characters = db.Artifacts
                        .Where(a => a.UserCategoryId == cat.UserCategoryId).ToList();
                    foreach (var character in characters)
                    {
                        charactersAttribute = db.UserArtifactAttributes
                            .Where(a => a.ArtifactId == character.ArtifactId).ToList();
                        foreach (var attribute in charactersAttribute)
                        {
                            charactersPower[character.ArtifactName] = attribute.ElementAttributeValue;
                        }
                    }
                }
                return charactersPower;
            }
        }
        
        // function that gets all characters 
        public static Dictionary<string, string> GetAllUserCharacters(int userId)
        {
            Dictionary<string, string> charactersPower = new Dictionary<string, string>();
            List<UserCategory> category;
            List<Artifact> characters;
            List<UserArtifactAttribute> charactersAttribute;
            using (MyDbContext db = new MyDbContext())
            {
                category = db.UserCategories
                    .Where(c => c.CategoryId == 2 && c.UserId == userId).ToList();

                foreach (var cat in category)
                {
                    characters = db.Artifacts
                        .Where(a => a.UserCategoryId == cat.UserCategoryId).ToList();
                    foreach (var character in characters)
                    {
                        charactersAttribute = db.UserArtifactAttributes
                            .Where(a => a.ArtifactId == character.ArtifactId).ToList();
                        foreach (var attribute in charactersAttribute)
                        {
                            charactersPower[character.ArtifactName] = attribute.ElementAttributeValue;
                        }
                    }
                }
                return charactersPower;
            }
        }
    }
}
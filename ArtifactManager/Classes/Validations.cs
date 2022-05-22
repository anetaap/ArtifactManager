using System;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using ArtifactManager.DataBase.Context;
using System.Security.Cryptography;

namespace ArtifactManager.Classes
{
    public class Validations
    {
        private string _username;
        private string _password;
        private int _userId;
        public string Username { get => _username; }
        public string Password { get => _password; }
        public int UserId { get => _userId; }

        public string PasswordHash(string password)
        {
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string passwordhash = BitConverter.ToString(hashBytes).Replace("-",String.Empty);

                return passwordhash;
            }
        }
        public bool PasswordValidation(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password)
                                                          && hasMinimum8Chars.IsMatch(password);

            return isValidated;
        }

        public bool PasswordMatchValidation(string password)
        {
            string passwordHash = PasswordHash(password);
            if (_password == passwordHash) return true;
            return false;
        }

        public bool PasswordsMatchValidation(string password1, string password2)
        {
            if (password1 == password2) return true;
            return false;
        }
        
        public bool UsernameValidation(string username)
        {
            if (MyDbContextFunctions.UserExist(username)) return true;
            return false;
        }
        
        public bool EmailValidation(String email)
        {
            if (email == "") return false;
            try
            {
                MailAddress emailaddress = new MailAddress(email);

                if (MyDbContextFunctions.EmailExist(email)) return false;
                
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool EmailChangeValidation(String email)
        {
            if (email == "") return false;
            try
            {
                MailAddress emailaddress = new MailAddress(email);

                if (MyDbContextFunctions.EmailOfUser(email) == _username) return true;
            }
            catch (FormatException)
            {
                return false;
            }

            return false;
        }
        

        public bool CompletenessValidation(string[] information)
        {
            foreach (string inf in information)
            {
                if (inf == "") return false;
            }
            return true;
        }

        public bool AdminValidation(string username)
        {
            if (MyDbContextFunctions.IsAdmin(username)) return true;
            return false;
        }

        public void ChangePassword(string password)
        {
            _password = password;
            MyDbContextFunctions.ChangePassword(_username, _password);
        }

        public bool TypeIntParse(string value)
        {
            try
            {
                int i = int.Parse(value);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public void ChangeInformation(string name, string lastname, string email)
        {
            MyDbContextFunctions.ChangeInformation(_username, name, lastname, email);
        }

        public void RemoveUser(string username)
        {
            MyDbContextFunctions.RemoveUser(username);
            Logout();
        }
        
        public void Login(string username)
        {
            _username = username;
            _password = MyDbContextFunctions.GetPassword(_username);
            _userId = MyDbContextFunctions.GetUserId(_username);
        }
        public void Logout()
        {
            _username = "";
            _password = "";
        }
    }
}
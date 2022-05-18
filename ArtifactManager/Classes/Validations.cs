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

        public bool PasswordMatchValidation(String password)
        {
            password = PasswordHash(password);
            if (_password == password) return true;
            return false;
        }

        public bool PasswordMatchValidation(String password1, String password2)
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

        public bool CompletenessValidation(string[] information)
        {
            foreach (string inf in information)
            {
                if (inf == "") return false;
            }
            return true;
        }
        
        public void Login(string username)
        {
            _username = username;
            _password = MyDbContextFunctions.GetPassword(_username);
        }
        public void Logout()
        {
            _username = "";
            _password = "";
        }
    }
}
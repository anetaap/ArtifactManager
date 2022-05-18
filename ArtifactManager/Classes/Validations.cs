using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ArtifactManager.Classes
{
    public class Validations
    {
        private String _username;
        private String _password;
        public Validations()
        {
        }

        public bool PasswordValidation(String password)
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
            if (_password == password) return true;
            return false;
        }

        public bool PasswordMatchValidation(String password1, String password2)
        {
            if (password1 == password2) return true;
            return false;
        }

        // TODO implement function (checks if user with that username exists)
        public bool UsernameValidation(String username)
        {
            return true;
        }
        
        public bool EmailValidation(String email)
        {
            try
            {
                MailAddress emailaddress = new MailAddress(email);
                
                // TODO implement function that checks if there is no user with the same e-mail address 
                
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        
        // TODO implement Login function that collects information about logged user 
        public void Login(int id)
        {
            
        }
        public void Logout()
        {
            _username = null;
            _password = null;
        }
    }
}
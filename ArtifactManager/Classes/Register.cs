using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ArtifactManager.Classes
{
    public class Register
    {
        public bool PasswordValidation(String password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password)
                                                          && hasMinimum8Chars.IsMatch(password);

            return isValidated;
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
    }
}
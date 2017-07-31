using System;
using System.Text.RegularExpressions;
using TODO.Models.Enums;
using TODO.Utils.GlobalConstants;

namespace TODO.Utils.Validator
{
    public class Validator
    {
        #region Methods
        public static void CheckUserName(string input)
        {
            Regex rgx = new Regex(Constants.RegexNamePattern);

            if (!rgx.IsMatch(input))
            {
                throw new ArgumentException($"{input} is not a valid name. Use only letters, numbers and underscore.");
            }
        }
        public static void CannotBeNull(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }
        }
        public static void CheckNameLength(string input, int min)
        {
            if (input.Length < min)
            {
                throw new ArgumentException($"Name cannot be less than {min} characters");
            }
        }
        public static void CheckPasswordStrength(string password)
        {
            int score = 0;

            
            if (password.Length > 8)
            {
                score++;
            }

            if (password.Length > 12)
            {
                score++;
            }

            // Make the regex expression check only ascii - 0-9
            if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
            {
                score++;
            }

            //Check for containing both lower and upper case
            if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success
                && Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
            {
                score++;
            }

            if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
            {
                score++;
            }
            
            switch ((PasswordStrength)score)
            {
                case PasswordStrength.Blank:
                case PasswordStrength.VeryWeak:
                case PasswordStrength.Weak:
                    {
                        throw new ArgumentException($"{(PasswordStrength)score} password is not allowed, please try again.");
                        
                    }
                case PasswordStrength.Medium:
                case PasswordStrength.Strong:
                case PasswordStrength.VeryStrong:
                    // Password deemed strong enough, allow user to use this password
                    break;
            }

        }
        
        #endregion
    }
}

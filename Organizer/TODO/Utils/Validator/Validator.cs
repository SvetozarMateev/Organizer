using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TODO.Utils.GlobalConstants;

namespace TODO.Utils.Validator
{
    public class Validator
    {
        #region Methods
        public static void CheckUserName (string input)
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
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TODO.Utils.GlobalConstants
{
    public class Constants
    {
        #region Constants
        //Regex patterns
        // A regex to check if a string contains only letters, numbers and underscore

        public const string RegexNamePattern = @"^[a-zA-Z0-9_]+$";

        public const int MinUserLength = 3;
        #endregion


    }
}

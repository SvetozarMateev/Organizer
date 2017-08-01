using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    public static class Loader
    {
        public static List<string> LoadUsernamesAndPasswords()
        {
            List<string> allUsers = new List<string>();
            using (StreamReader reader = new StreamReader("DatabaseOfUsernames.txt"))
            {
                allUsers = reader.ReadToEnd()
                    .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            return allUsers;
        }
    }
}

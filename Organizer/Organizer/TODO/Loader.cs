using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Contracts;
using TODO.Models;
using TODO.Utils.GlobalConstants;

namespace TODO
{
    public static class Loader
    {
        public static List<string> LoadUsernamesAndPasswords()
        {
            List<string> allUsers = new List<string>();
            using (StreamReader reader = new StreamReader(Constants.PathToDatabase+"/DatabaseOfUsernames.txt"))
            {
                allUsers = reader.ReadToEnd()
                    .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            return allUsers;
        }
        public static IUser LoadUser(string username, string password)
        {

            using (StreamReader reader = new StreamReader($"{Constants.PathToDatabase}/{username}_UserDatabase.txt"))
            {
                reader.ReadLine();
                List<INotebook> currNotebooks = new List<INotebook>();
                while (true)
                {
                    string attrLine = reader.ReadLine();
                    if (attrLine == "---***---")
                        break;
                    currNotebooks.Add(LoadNotebook(attrLine));                 
                }
                return new User(username, password, currNotebooks);
            }
        }
        public static INotebook LoadNotebook(string entryParameters)
        {
            string[] refinedParameteres = entryParameters.Split(new string[] { ":::" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] notebookParams = refinedParameteres[0].Split(' ').ToArray();
            string[] noteParams = refinedParameteres[1].Split(new string[] { ",,," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<INote> currNotes = new List<INote>();
            for (int i = 0; i < noteParams.Length; i++)
            {
                currNotes.Add(LoadNote(noteParams[i]));
            }

            bool refinednotebookParam = notebookParams[1] == "True";
            return new Notebook(notebookParams[0], refinednotebookParam, currNotes);
        }

        private static INote LoadNote(string noteParams)
        {
           
            string[] refinedNoteParams = noteParams.Split(' ');

            bool refinednoteParam = refinedNoteParams[1] == "True";

            var dt = DateTime.ParseExact(refinedNoteParams[2], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var content = string.Join(" ",refinedNoteParams.Skip(3));
            return new Note(refinedNoteParams[0], content, refinednoteParam, dt);
        }
    }
}

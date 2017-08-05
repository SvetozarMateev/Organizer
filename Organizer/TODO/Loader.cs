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

                List<ITask> currTasks = new List<ITask>();
                while (true)
                {
                    string attrLine = reader.ReadLine();
                    if (attrLine == "___***___")
                        break;
                    currTasks.Add(LoadTask(attrLine));
                }

                List<ILongTermTask> currLongTermTasks = new List<ILongTermTask>();
                while (true)
                {
                    string attrLine = reader.ReadLine();
                    if (attrLine == "---***---")
                        break;
                    currLongTermTasks.Add(LoadLongTermTask(attrLine));
                }
                return new User(username, password, currNotebooks,currTasks,currLongTermTasks);
            }
        }

        public static INotebook LoadNotebook(string entryParameters)
        {
            string[] refinedParameteres = entryParameters
                .Split(new string[] { ":::" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] notebookParams = refinedParameteres[0]
                .Split(' ')
                .ToArray();

            var noteParams = new List<string>();
            if (refinedParameteres.Length > 1)
            {
                 noteParams = refinedParameteres[1]
                .Split(new string[] { ",,," }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            
            List<INote> currNotes = new List<INote>();
            for (int i = 0; i < noteParams.Count; i++)
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
        private static ISubTask LoadSubTask(string subTaskParametersString)
        {

            string[] subTaskParameters = subTaskParametersString.Split(new string[] { ":::" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string title = subTaskParameters[0];

            Priority priority;
            Enum.TryParse(subTaskParameters[1], out priority);

            //TODO implement when reminder is not null
            DateTime dtStart = DateTime.ParseExact(subTaskParameters[3], Constants.Formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            DateTime dtDueDate= DateTime.ParseExact(subTaskParameters[4], Constants.Formats, CultureInfo.InvariantCulture, DateTimeStyles.None);

            double importancePercent = double.Parse(subTaskParameters[5]);
            string description = subTaskParameters[6];

            return new SubTask(title, priority, description, dtDueDate, importancePercent, dtStart);
        }
        private static ITask LoadTask(string taskParameteresString)
        {
            string[] taskParameters = taskParameteresString.Split(new string[] { ":::"}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string title = taskParameters[0];
            Priority priority;
            Enum.TryParse(taskParameters[1], out priority);
            //TODO implement when reminder is not null
            DateTime dt = DateTime.ParseExact(taskParameters[3], Constants.Formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            string description = taskParameters[4];
            return new Task(title, priority, description);
        }
        private static ILongTermTask LoadLongTermTask(string longTermTaskParametersString)
        {
            string[] longTermTaskParameters = longTermTaskParametersString.Split(new string[] { ":::" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            string title = longTermTaskParameters[0];

            Priority priority = (Priority)Enum.Parse(typeof(Priority),longTermTaskParameters[1]);

            List<ISubTask> currSubtasks;
            if (longTermTaskParameters[2] == "None")
            {
                currSubtasks = new List<ISubTask>();
            }
            else
            {
             currSubtasks= longTermTaskParameters[2].Split(',').Select(x => LoadSubTask(x)).ToList();
            }
            DateTime dtStart = DateTime.ParseExact(longTermTaskParameters[3], Constants.Formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            //TODO implement when reminder is not null

            DateTime dtEnd = DateTime.ParseExact(longTermTaskParameters[5].Trim(), Constants.Formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            string description = longTermTaskParameters[6];
                      
            return new LongTermTask(title, priority,dtEnd,description,dtStart,currSubtasks);
        }
    }
}

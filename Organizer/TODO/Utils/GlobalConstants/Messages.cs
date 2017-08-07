using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Engine;

namespace TODO.Utils.GlobalConstants
{
    public static class Messages
    {
        public static string NotebookCreated(string notebookName)
        {
            return $"Notebook \"{notebookName}\" added successfully !";
        }

        public static string NoteCreated(string title)
        {
            return $"Note {title} added successfully !";
        }

        public static string LongTermTaskCreated(string title)
        {
            return $"Long term task {title} has been added";
        }

        public static string SubTaskCreated(string title)
        {
            return $"Sub task {title} added to {EngineMaikaTI.currentLongTermTask.Title}";
        }

        public static string TaskCreated(string title)
        {
            return $"Added tast {title} successfully !";
        }

        public static string NotebookSwitched(string newNotebookName)
        {
            return $"Successfully switched to {newNotebookName} notebook";
        }

        public static string WrongNotebookName()
        {
            return $"You don't have a notebook with this name";
        }
    }
}

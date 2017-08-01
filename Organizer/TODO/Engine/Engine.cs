using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Commands;
using TODO.Contracts;
using TODO.Factories;

namespace TODO.Engine
{
    public class EngineMaikaTI : IEngine
    {
        private readonly IOrganizerFactory factory = new OrganizerFactory();
        public static IUser loggedUser;
        public static INotebook currentNotebook;

        public void Start()
        {
            while (true)
            {
                try
                {
                    List<string> commands = this.ReadCommands();

                    if (commands[0].Equals("exit"))
                    {
                        break;
                    }
                    if (string.IsNullOrEmpty(commands?[0])) // checks if its null or if the first element is nullOrEmpty
                    {
                        continue;
                    }

                    this.ProcessCommands(commands);
                    if (loggedUser != null)
                    {
                        Saver.CreateUserFile(loggedUser);
                    }
                    //this.PrintReports(commandResult);
                }
                catch (Exception ex)
                {
                    Writer.WriteLine(ex.Message);
                }
            }
        }

        private void ProcessCommands(List<string> commands)
        {
            string commandType = commands[0];
            ICommand command;
            string commandResult = "";

            switch (commandType)
            {
                case "register":
                case "registeruser":
                    if (loggedUser != null)
                    {
                        throw new ArgumentException("There is already a logged user");
                    }
                    command = new RegisterCommand(commands);
                    commandResult = command.Execute;
                    break;
                case "login":
                case "log":
                    if (loggedUser != null)
                    {
                        throw new ArgumentException("There is already a logged user");
                    }
                    command = new LoginCommand(commands);
                    commandResult = command.Execute;
                    break;
                case "logout":
                    if (loggedUser == null)
                    {
                        throw new ArgumentException("You aren't logged !");
                    }
                    command = new LogOutCommand(commands);
                    commandResult = command.Execute;
                    break;
                case "addnotebook":
                    if (loggedUser == null)
                    {
                        throw new ArgumentException("You must be logged to add notebooks");
                    }
                    command = new AddNotebookCommand(commands);
                    commandResult = command.Execute;
                    break;
                case "addnote":
                    if (loggedUser == null)
                    {
                        throw new ArgumentException("You must be logged to add notes");
                    }
                    if (loggedUser.Notebooks.Count == 0)
                    {
                        throw new ArgumentException("You must create a notebook first");
                    }
                    command = new AddNoteCommand(commands);
                    commandResult = command.Execute;
                    break;
                case "switchnotebook":
                    command = new SwitchNotebookCommand(commands);
                    commandResult = command.Execute;
                    break;
                default:
                    break;
            }
            Console.WriteLine(commandResult);
        }

        private List<string> ReadCommands()
        {
            List<string> commands = Console.ReadLine()
                .Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToList();

            bool isUserCreatable = loggedUser == null && commands[0] != "login" && commands[0] != "register";

            if (isUserCreatable)
            {
                Writer.NoUserLogged();
                ReadCommands();
            }
            return commands;
        }
    }
}

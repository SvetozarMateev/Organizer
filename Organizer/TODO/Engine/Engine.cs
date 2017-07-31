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
        public static  IUser loggedUser;

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
                    if (commands == null && string.IsNullOrEmpty(commands[0]))
                    {
                        continue;
                    }

                    this.ProcessCommands(commands);
                    Saver.CreateUserFile(loggedUser);
                    //this.PrintReports(commandResult);
                }
                catch (Exception ex )
                {
                    Console.WriteLine(ex.Message);
                    //Writer.Write(ex.Message);
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
                    commandResult = command.Execute();
                    break;
                case "login":
                case "log":
                    if (loggedUser != null)
                    {
                        throw new ArgumentException("There is already a logged user");
                    }
                    command = new LoginCommand(commands);
                    commandResult = command.Execute();
                    break;

                default:
                    break;
            }
            Console.WriteLine(commandResult);
        }

        private List<string> ReadCommands()
        {
            List<string> commands = Console.ReadLine().ToLower().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            bool isUserCreatable = loggedUser == null && commands[0] != "login" && commands[0] != "register";  
            if (isUserCreatable)
            {
                Writer.NoUserLogged();
                ReadCommands();
            }

            //var currentLine = Console.ReadLine();

            //while (!string.IsNullOrEmpty(currentLine))
            //{
            //    var currentCommand = new Command(currentLine);
            //    commands.Add(currentCommand);

            //    currentLine = Console.ReadLine();
            //}
            return commands;
        }
    }
}

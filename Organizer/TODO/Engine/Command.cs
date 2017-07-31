using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Utils.Validator;

namespace TODO.Engine
{
    public class Command : ICommand
    {
        private string name;
        private List<string> parameters;

        public Command(string input)
        {
            this.Parameters = new List<string>();
            this.TranslateInput(input);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CannotBeNullOrEmpty(value);
               
                this.name = value;
            }
        }

        public List<string> Parameters
        {
            get
            {
                return this.parameters;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of strings cannot be null.");
                }

                this.parameters = value;
            }
        }

        private void TranslateInput(string input)
        {
            string[] inputParams = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            return new List<string>(inputParams.ToList());
        }
    }
}

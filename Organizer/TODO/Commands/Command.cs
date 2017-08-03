﻿using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Factories;
using TODO.Utils.Validator;

namespace TODO.Engine
{
    public abstract class Command : ICommand
    {
        protected List<string> parameters;
        protected OrganizerFactory factory;
        public Command(List<string> parameters)
        {
            this.Parameters = parameters;
            this.factory = new OrganizerFactory();
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

        public abstract string Execute { get; }
    }
}

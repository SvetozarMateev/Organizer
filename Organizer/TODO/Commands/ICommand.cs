using System;
using System.Collections.Generic;
namespace TODO.Engine
{
    interface ICommand
    {
        List<string> Parameters { get; }

        string Execute { get; }
    }
}

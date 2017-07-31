using System;
using System.Collections.Generic;
namespace TODO.Engine
{
    interface ICommand
    {
        string Name { get; }

        List<string> Parameters { get; }
    }
}

using System;
using static HelpDesk.Functions;

namespace HelpDesk.Modules
{
    public static class Documents
    {
        public static void DocumentsMenu()
        {
            Console.Clear();
            UIManager.DisplayLogo("Info");
            FunctionUnavailable();
            Pause();
        }
    }
}
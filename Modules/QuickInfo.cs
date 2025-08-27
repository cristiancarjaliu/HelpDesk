using System;
using static HelpDesk.Functions;

namespace HelpDesk.Modules
{
    public static class QuickInfo
    {
        public static void QuickInfoMenu()
        {
            Console.Clear();
            UIManager.DisplayLogo("Info");
            FunctionUnavailable();
            Pause();
        }
    }
}
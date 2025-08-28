using System;
using HelpDesk.Modules;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using HelpDesk;
using System.Reflection.Metadata;
class Program
{
    static void Main()
    {
        UIManager.DisplayLogo("HelpDesk");
        UIManager.DisplayMenu("HelpDesk");
    }
}
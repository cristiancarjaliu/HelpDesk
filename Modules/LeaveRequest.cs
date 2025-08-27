using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelpDesk.Functions;

namespace HelpDesk.Modules
{
    public static class LeaveRequest
    {
        public static void CreateLeaveRequest()
        {
            UIManager.DisplayLogo("HelpDesk");

            Info("Introdu datele necesare pentru generearea cererii de invoire.");

            string fullName = ReadText("\nIntroduceti numele complet:");
            if (fullName == InputDefaults.EscapeString) return;

            DateTime leaveDate = ReadDate("\nIntroduceti data invoirii:");
            if (leaveDate == InputDefaults.EscapeDate) return;

            string startTime = ReadTime("\nIntroduceti ora de inceput:");
            if (startTime == InputDefaults.EscapeTime) return;

            string endTime = ReadTime("\nIntroduceti ora de sfarsit:");
            if (endTime == InputDefaults.EscapeTime) return;

            Console.Clear();
            UIManager.DisplayLogo("HelpDesk");
            Info("Cererea de invoire a fost generata:\n\n");
            CenteredText("DOMNULE DIRECTOR,");

            Console.WriteLine($"\n       Subsemnatul {fullName}, angajat al SC SOFTEH PLUS SRL, va rog sa imi aprobati cererea de invoire");
            Console.WriteLine($"       in data de {leaveDate:dd.MM.yyyy} de la ora {startTime} pana la ora {endTime}.");
            Console.WriteLine("\n\n                   Va multumesc!\n");

            CenteredText($"{fullName}                                                        {leaveDate:dd.MM.yyyy}");
            Console.WriteLine("\n\n");
            Pause();
        }
    }
}

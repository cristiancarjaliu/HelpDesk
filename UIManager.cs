using HelpDesk.Modules;
using HelpDesk.Modules.SqlMenus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    public static class UIManager
    {
        private static readonly Dictionary<string, string[]> LogosDictionary = new Dictionary<string, string[]>
        {
            { "HelpDesk", new string[]
                {
                    "██   ██  ███████  ██       ██████      ██████    ███████  ███████  ██   ██",
                    "██   ██  ██       ██       ██   ██     ██   ██   ██       ██       ██  ██ ",
                    "███████  █████    ██       ██████      ██    ██  █████    ███████  █████  ",
                    "██   ██  ██       ██       ██          ██   ██   ██            ██  ██  ██ ",
                    "██   ██  ███████  ███████  ██          ██████    ███████  ███████  ██   ██"
                }
            },
            { "Info", new string[]
                {
                    "██████  ██   ██  ██████   ██████ ",
                    "  ██    ███  ██  ██      ██    ██",
                    "  ██    ██ █ ██  █████   ██    ██",
                    "  ██    ██  ███  ██      ██    ██",
                    "██████  ██   ██  ██       ██████ "
                }
            },
            { "SQL", new string[]
                {
                    "███████   ██████   ██             ██████  ██       ██   ██  ███████",
                    "██       ██    ██  ██             ██   ██ ██       ██   ██  ██     ",
                    "███████  ██    ██  ██       ████  ██████  ██       ██   ██  ███████",
                    "     ██  ██ ▀▀ ██  ██             ██      ██       ██   ██       ██",
                    "███████   ██████   ███████        ██      ███████  ███████  ███████"
                }
            },
            { "SqlSearch", new string[]
                {
                    "███████   ██████   ██             ██████  ██       ██   ██  ███████",
                    "██       ██    ██  ██             ██   ██ ██       ██   ██  ██     ",
                    "███████  ██    ██  ██       ████  ██████  ██       ██   ██  ███████",
                    "     ██  ██ ▀▀ ██  ██             ██      ██       ██   ██       ██",
                    "███████   ██████   ███████        ██      ███████  ███████  ███████"
                }
            },
            { "SqlChange", new string[]
                {
                    "███████   ██████   ██             ██████  ██       ██   ██  ███████",
                    "██       ██    ██  ██             ██   ██ ██       ██   ██  ██     ",
                    "███████  ██    ██  ██       ████  ██████  ██       ██   ██  ███████",
                    "     ██  ██ ▀▀ ██  ██             ██      ██       ██   ██       ██",
                    "███████   ██████   ███████        ██      ███████  ███████  ███████"
                }
            },
            { "Apps", new string[]
                {
                    " █████   ██████   ██████   ███████",
                    "██   ██  ██   ██  ██   ██  ██     ",
                    "███████  ██████   ██████   ███████",
                    "██   ██  ██       ██            ██",
                    "██   ██  ██       ██       ███████"
                }
            },
            { "Drivers", new string[]
                {
                    "██████   ██████   ██████  ██   ██  ███████  ██████   ███████",
                    "██   ██  ██   ██    ██    ██   ██  ██       ██   ██  ██     ",
                    "██   ██  ██████     ██    ██   ██  █████    ██████   ███████",
                    "██   ██  ██   ██    ██     ██ ██   ██       ██   ██       ██",
                    "██████   ██   ██  ██████    ███    ███████  ██   ██  ███████"
                }
            },

            { "Scanner", new string[]
                {
                    "██████   ██████   ██████  ██   ██  ███████  ██████   ███████",
                    "██   ██  ██   ██    ██    ██   ██  ██       ██   ██  ██     ",
                    "██   ██  ██████     ██    ██   ██  █████    ██████   ███████",
                    "██   ██  ██   ██    ██     ██ ██   ██       ██   ██       ██",
                    "██████   ██   ██  ██████    ███    ███████  ██   ██  ███████"
                }
            },

            { "Token", new string[]
                {
                    "██████   ██████   ██████  ██   ██  ███████  ██████   ███████",
                    "██   ██  ██   ██    ██    ██   ██  ██       ██   ██  ██     ",
                    "██   ██  ██████     ██    ██   ██  █████    ██████   ███████",
                    "██   ██  ██   ██    ██     ██ ██   ██       ██   ██       ██",
                    "██████   ██   ██  ██████    ███    ███████  ██   ██  ███████"
                }
            },

            { "OSMR", new string[]
                {
                    " ██████   ███████  ██     ██  ██████ ",
                    "██    ██  ██       ███   ███  ██   ██",
                    "██    ██  ███████  ██ █ █ ██  ██████ ",
                    "██    ██       ██  ██  █  ██  ██   ██",
                    " ██████   ███████  ██     ██  ██   ██"
                }
            }
        };


        private static readonly Dictionary<string, string[]> MenuOptionsDictionary = new Dictionary<string, string[]>
        {
            { "HelpDesk", new string[] { "Informatii", "Baze de date", "Aplicatii", "Drivere", "Documente", "Cerere invoire", "Gestionare OSMR" } },
            { "SQL", new string[] { "Cautare/Selectare", "Inchidere/Deschidere", "Schimbare/Modificare" } },
            { "SqlSearch", new string[] { "Cautare bon fiscal", "Cautare reteta", "Cautare document", "Cautare partener", "Cautare persoana", "Cautare colectie", "Cautare utilizator"} },
            { "SqlChange", new string[] { "Schimbare1", "Schimbare2", "Schimbare3", "Schimbare4", "Schimbare5", "Schimbare6" } },
            { "Apps", new string[] { "PlusERP", "SMFS", "Netfarm", "Sybase", "PS2", "Anydesk" } },
            { "Drivers", new string[] { "Scanner", "Cititor carduri", "POS Bancar","Certificate digitale" } },
            { "OSMR", new string[] { "Conectare portal", "Generare certificat", "Restare parola SMS", "Alerte OSMR", "Proceduri OSMR" } },
            { "Scanner", new string[] { "Zebra", "Motorola", "Intermec", "Honeywell", "Coduri universale"} },
            { "Token", new string[] { "Token certSIGN", "Token CertDigital", "Token Alfasign" } }
        };


        public static void DisplayLogo(string logoKey)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            int consoleWidth = Console.WindowWidth;
            int longestLine = LogosDictionary[logoKey].Max(line => line.Length);

            foreach (string line in LogosDictionary[logoKey])
            {
                int padding = (consoleWidth - longestLine) / 2;
                Console.WriteLine(new string(' ', padding) + line);
            }

            Console.ResetColor();
            Console.WriteLine("\n");
        }

        public static void DisplayMenu(string menuKey, string warningMessage = "")
        {
            string[] options = MenuOptionsDictionary[menuKey];
            int index = 0;

            while (true)
            {
                Console.Clear();
                DisplayLogo(menuKey);

                Console.WriteLine("\n█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == index)
                    {
                        Console.WriteLine($"█ >> {options[i],-21}█");
                    }
                    else
                    {
                        Console.WriteLine($"█   {options[i],-22}█");
                    }
                }
                Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

                if (!string.IsNullOrEmpty(warningMessage))
                {
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    int longestWarningLine = warningMessage.Split('\n').Max(line => line.Length);
                    int consoleWidth = Console.WindowWidth;

                    foreach (string line in warningMessage.Split('\n'))
                    {
                        int padding = (consoleWidth - longestWarningLine) / 2;
                        Console.WriteLine(new string(' ', Math.Max(0, padding)) + line);
                    }
                    Console.ResetColor();
                }

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 5);

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                {
                    index = (index == 0) ? options.Length - 1 : index - 1;
                }

                if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                {
                    index = (index == options.Length - 1) ? 0 : index + 1;
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    ExecuteOption(menuKey, index);
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    if (menuKey == "HelpDesk")
                    {
                        if (ConfirmExit()) Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        return;
                    }
                }
            }
        }

        static bool ConfirmExit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nVrei sa inchizi programul? (da/nu)");
            Console.ResetColor();
            Console.Write("> ");
            string raspuns = Console.ReadLine()!.Trim().ToLower();

            if (raspuns == "da") return true;
            if (raspuns == "nu") return false;

            Console.WriteLine("\nInput invalid! Te rog sa scrii 'DA' sau 'NU'.");
            Thread.Sleep(1500);
            return false;
        }


        private static void ExecuteOption(string menuKey, int index) // Se executa optiunea, in functie de meniul ales
        {
            Console.Clear();

                string selectedOption = MenuOptionsDictionary[menuKey][index];

            switch (menuKey)
            {
                case "HelpDesk": ExecuteMainMenuOption(index); break;
                case "Info": ExecuteInfoOption(index); break;
                case "SQL": ExecuteSqlOption(index); break;
                case "SqlSearch": ExecuteSqlSearchOption(index); break;
                case "SqlChange": ExecuteSqlChangeOption(index); break;
                case "Apps": ExecuteAppsOption(index); break;
                case "Drivers":ExecuteDriversOption(index); break;
                case "Scanner": ExecuteScannerOption(index); break;
                case "Token": ExecuteTokenOption(index); break;
                case "OSMR": ExecuteOsmrOption(index); break;
                default: throw new ArgumentException($"Invalid menu key: {menuKey}");
            }
        }
        public static void ExecuteMainMenuOption (int index)
        {
            switch (index)
            {
                case 0: QuickInfo.QuickInfoMenu(); break;
                case 1: SQL.SqlMenu(); break;  
                case 2: Apps.AppsMenu(); break;
                case 3: Drivers.DriversMenu(); break;
                case 4: Documents.DocumentsMenu(); break;
                case 5: LeaveRequest.CreateLeaveRequest(); break;
                case 6: OSMR.OsmrMenu(); break;
            }
        }

        private static void ExecuteInfoOption(int index)
        {
            Console.Clear();
            DisplayLogo("Info");
            QuickInfo.QuickInfoMenu();
        }
        private static void ExecuteSqlOption(int index)
        {
            Console.Clear();
            DisplayLogo("SQL");
            switch (index)
            {
                case 0: SqlSearch.SqlSearchMenu(); break;
                case 1: SqlChange.SqlChangeMenu(); break;
                case 2: /*SchimbareModificare();*/ break;
            }
        }

        private static void ExecuteSqlSearchOption(int index)
        {
            Console.Clear();
            DisplayLogo("SqlSearch");
            switch (index)
            {
                case 0: SqlSearch.SearchFiscalReceipt(); break;
                case 1: SqlSearch.SearchPrescription(); break;
                case 2: SqlSearch.SearchDocument(); break;
                case 3: SqlSearch.SearchPartner(); break;
                case 4: SqlSearch.SearchPerson(); break;
                case 5: SqlSearch.SearchCollection(); break;
                case 6: SqlSearch.SearchUser(); break;
            }
        }

        private static void ExecuteSqlChangeOption(int index)
        {
            DisplayLogo("SqlChange");
            switch (index)
            {
                case 0: break;
            }
        }

        private static void ExecuteAppsOption(int index)
        {
            Console.Clear();
            DisplayLogo("Apps");
            switch (index)
            {
                case 0: Apps.DownloadPlusERP(); break;
                case 1: Apps.DownloadSMFS(); break;
                case 2: Apps.DownloadNetfarm(); break;
                case 3: Apps.DownloadSybase(); break;
                case 4: Apps.DownloadPS2(); break;
                case 5: Apps.DownloadAnydesk(); break;
            }
        }

        private static void ExecuteDriversOption(int index)
        {
            Console.Clear();
            // DisplayLogo("Drivers");
            switch (index)
            {
                case 0: Drivers.ScannerDriver(); break;
                case 1: Drivers.CardReaderDriver(); break;
                case 2: Drivers.POSDriver(); break;
                case 3: Drivers.TokenDriver(); break;
            } 
        }

        private static void ExecuteScannerOption(int index) { 
            Console.Clear();
            // DisplayLogo("Drivers");
            switch (index) 
            {
                case 0: Drivers.ScannerZebra(); break;
                case 1: Drivers.ScannerMotorola(); break;
                case 2: Drivers.ScannerIntermec(); break;
                case 3: Drivers.ScannerHoneywell(); break;
                case 4: Drivers.UniversalCodes(); break;

            }
        }

        private static void ExecuteTokenOption(int index)
        {
            Console.Clear();
            switch (index)
            {
                case 0: Drivers.certSIGN(); break;
                case 1: Drivers.CertDigital(); break;
                case 2: Drivers.Alfasign(); break;
            }
        }

        private static void ExecuteOsmrOption(int index)
        {
            Console.Clear();
            DisplayLogo("OSMR");
            switch (index)
            {
                case 0: OSMR.OsmrConnection(); break;
                case 1: OSMR.OsmrCreateCertificate(); break;
                case 2: OSMR.OsmrPasswordReset(); break;
                case 3: OSMR.OsmrAlerts(); break;
                case 4: OSMR.OsmrProcedures(); break;       
            }
        }


    }
}
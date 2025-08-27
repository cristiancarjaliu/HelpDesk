using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelpDesk
{
    public class Functions
    {
        public static void Colored(string text, string type = "default", bool newLine = true)
        {
            var colors = new Dictionary<string, ConsoleColor>(StringComparer.OrdinalIgnoreCase)
            {
        { "link", ConsoleColor.Magenta },
        { "info", ConsoleColor.DarkYellow },
        { "warning", ConsoleColor.DarkRed },
        { "SQL", ConsoleColor.Magenta },
        { "SQLFirstProd", ConsoleColor.Magenta },
        { "SQLSecondProd", ConsoleColor.DarkMagenta },
        { "SQLDemo", ConsoleColor.DarkCyan },
        { "default", ConsoleColor.Gray }
            };

            ConsoleColor culoare = colors.ContainsKey(type) ? colors[type] : ConsoleColor.Gray;

            Console.ForegroundColor = culoare;
            if (newLine)
                Console.WriteLine(text);
            else
                Console.Write(text);
            Console.ResetColor();
        }

        public static void Hint()
        {
            Colored("\nHint!", "info");
        }
        public static void Info(string text)
        {
            Colored("\n" + text, "info");
        }

        public static void Warning(string text)
        {
            Colored("\n" + text, "warning");
        }

        public static void SQL(string text)
        {
            Colored(text, "SQL");
        }


        public static class InputDefaults
        {
            public const long EscapeNumber = -1;
            public const string EscapeString = "";
            public static readonly DateTime EscapeDate = default;
            public const string EscapeTime = "";
        }

        public static long ReadNumber(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} ");
                string input = "";

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Escape) return InputDefaults.EscapeNumber;

                    if (char.IsDigit(key.KeyChar))
                    {
                        Console.Write(key.KeyChar);
                        input += key.KeyChar;
                    }
                    else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input[..^1];
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter) break;
                }

                Console.WriteLine();

                if (long.TryParse(input, out long number))
                    return number;

                Warning("Numar invalid! Te rog introdu un numar valid!");
            }
        }


        public static DateTime ReadDate(string message)
        {
            while (true)
            {
                Console.Write($"{message} ");
                string input = "";

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Escape) return InputDefaults.EscapeDate;

                    if (char.IsDigit(key.KeyChar) || key.KeyChar == '.')
                    {
                        Console.Write(key.KeyChar);
                        input += key.KeyChar;
                    }
                    else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input[..^1];
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter) break;
                }

                Console.WriteLine();

                if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                {
                    return date;
                }

                Warning("Data invalida! Te rog sa introduci o data valida in format DD.MM.YYYY.");
            }
        }



        public static string ReadTime(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} ");
                string input = "";

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Escape) return InputDefaults.EscapeTime;

                    if (char.IsDigit(key.KeyChar) || key.KeyChar == ':')
                    {
                        Console.Write(key.KeyChar);
                        input += key.KeyChar;
                    }
                    else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input[..^1];
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter) break;
                }

                Console.WriteLine();

                if (TimeSpan.TryParseExact(input, "hh\\:mm", null, out _))
                    return input;

                Warning("Ora invalida! Te rog sa introduci un format corect (HH:mm).");
            }
        }


        public static string ReadText(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} ");
                string input = "";

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Escape) return InputDefaults.EscapeString;

                    if (char.IsLetter(key.KeyChar) || key.KeyChar == ' ')
                    {
                        Console.Write(key.KeyChar);
                        input += key.KeyChar;
                    }
                    else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input[..^1];
                        Console.Write("\b \b"); 
                    }
                    else if (key.Key == ConsoleKey.Enter) break;
                }

                input = input.Trim();
                Console.WriteLine();

                if (!string.IsNullOrEmpty(input)) return input;

                Warning("Text invalid! Te rog introdu doar litere.");
            }
        }


        public static string ReadInput(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} ");
                string input = "";

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Escape) return InputDefaults.EscapeString;

                    if (!char.IsControl(key.KeyChar))
                    {
                        Console.Write(key.KeyChar);
                        input += key.KeyChar;
                    }
                    else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input[..^1];
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter) break;
                }

                input = input.Trim();
                Console.WriteLine();

                if (!string.IsNullOrEmpty(input)) return input;

                Warning("Text invalid! Te rog sa introduci un text valid.");
            }
        }




        public static void CenteredText(string text)
        {
            int consoleWidth = Console.WindowWidth;
            int padding = (consoleWidth - text.Length) / 2;

            Console.WriteLine(new string(' ', Math.Max(0, padding)) + text);
        }


        public static void Pause()
        {
            Console.Write("\nApasa orice tasta pentru a continua...");
            Console.ReadKey();
            Console.Write("\n");
        }

        public static void Download(string title, string link)
        {
            Console.WriteLine($"\n{title} - link descarcare: ");
            Colored(link, "link");
        }

        public static void FunctionUnavailable()
        {
            Colored("\nFunctie indisponibila momentan.", "warning");
        }

    }
}

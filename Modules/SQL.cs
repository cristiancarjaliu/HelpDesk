using System;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using static HelpDesk.Functions;

namespace HelpDesk.Modules
{
    public static class SQL
    {
        public static void SqlMenu()
        {
            Console.Clear();
            string warningMessage = " Inainte de a rula codurile generate de program, asigura-te de corectitudinea datelor! \n"
                          + " Programul poate genera coduri eronate! Codurile sunt exclusiv pentru aplicatia PlusERP!";
            UIManager.DisplayMenu("SQL", warningMessage);
        }  

        public static void SQLCredentials()
        {
            Info("Pentru a te conecta la bazele de date, foloseste informatiile de mai jos.");

            // First Prod Credentials
            Colored("\nProductie Principala", "SQLFirstProd");

            Console.Write("Server name: ");
            Colored("sqlpluserpprod.database.windows.net", "SQLFirstProd");
            Console.Write("Login: ");

            Colored("usersuport", "SQLFirstProd");

            Console.Write("Password: ");
            Colored("us3rsup0rt!", "SQLFirstProd");

            // Second Prod Credentials
            Colored("\nProductie Secundara", "SQLSecondProd");

            Console.Write("Server name: ");
            Colored("51.103.53.42", "SQLSecondProd");
            Console.Write("Login: ");
            Colored("usersuport", "SQLSecondProd");
            Console.Write("Password: ");
            Colored("us3rsup0rt!", "SQLSecondProd");

            // Demo Credentials  
            Colored("\nDemo", "SQLDemo");

            Console.Write("Server name: ");
            Colored("srvsql2017new", "SQLDemo");
            Console.Write("Login: ");
            Colored("usersuport", "SQLDemo");
            Console.Write("Password: ");
            Colored("usersuport", "SQLDemo");


            Info("\nAtentie!\nNu uita sa bifezi casutele 'Trust server certificate' & 'Remember password'");

            Pause();
        }
        
    }
}
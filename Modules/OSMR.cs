using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelpDesk.Functions;

namespace HelpDesk.Modules
{
    public static class OSMR
    {
        public static void OsmrMenu()
        {
            Console.Clear();
            UIManager.DisplayMenu("OSMR");
        }

        public static void OsmrConnection() // Conectare portal OSMR
        {
            Console.WriteLine("\nPentru conectarea in portalul OSMR, trebuie accesat link-ul:");
            Colored("https://portal-prod-ro.nmvs.eu/NMVS_PORTAL", "link");

            Console.WriteLine("\nPentru descarcarea unui certificat OSMR, trebuie accesat link-ul:");
            Colored("https://portal-pki-prod-ro.nmvs.eu/NMVS_PORTAL_PKI", "link");

            Pause();
        }
        public static void OsmrCreateCertificate() // Creare mail pentru generare certificat
        {
            Colored("\nPentru generarea unui nou certificat de OSMR, trebuie trimis mail la adresa:", "info");
            Colored("suport.cont.snvm@osmr.ro", "link");
            Colored("\nIntrodu datele necesare pentru generarea mailului.", "info");

            string gln = ReadInput("\nIntroduceti GLN:"); if (string.IsNullOrEmpty(gln)) return;
            string luf = ReadInput("Introduceti LUF:").ToUpper(); if (string.IsNullOrEmpty(luf)) return;
            string companyName = ReadInput("Introduceti numele societatii:").ToUpper(); if (string.IsNullOrEmpty(companyName)) return;
            string cui = ReadInput("Introduceti CUI-ul:"); if (string.IsNullOrEmpty(cui)) return;

            Console.Clear();
            UIManager.DisplayLogo("OSMR");
            Colored("\nEmailul a fost generat:\n", "info");
            Console.WriteLine("Buna ziua,");
            Console.WriteLine($"Va rog sa ne ajutati cu generarea unui nou certificat de OSMR pentru {gln}/{luf},");
            Console.WriteLine($"{companyName}, CUI - {cui}. Mediu de lucru PROD.");
            Console.WriteLine($"\nMultumim!\n{companyName}");
            Pause();

        }

        public static void OsmrPasswordReset() // Creare mail pentru resetarea parolei
        {
            Console.WriteLine("\nPentru resetarea parolei OSMR, trebuie trimis mail la adresa:");
            Colored("suport.cont.snvm@osmr.ro", "link");
            Colored("\nIntrodu datele necesare pentru generarea mailului.", "info");

            string gln = ReadInput("\nIntroduceti GLN:"); if (string.IsNullOrEmpty(gln)) return;
            string luf = ReadInput("Introduceti LUF:").ToUpper(); if (string.IsNullOrEmpty(luf)) return;
            string companyName = ReadInput("Introduceti numele societatii:").ToUpper(); if (string.IsNullOrEmpty(companyName)) return;
            string cui = ReadInput("Introduceti CUI-ul:"); if (string.IsNullOrEmpty(cui)) return;

            Console.Clear();
            UIManager.DisplayLogo("OSMR");
            Console.WriteLine("\nEmailul a fost generat:\n");
            Console.WriteLine("Buna ziua,");
            Console.WriteLine($"Va rog sa ne ajutati cu resetarea parolei prin SMS pentru {gln}/{luf},");
            Console.WriteLine($"{companyName} - CUI {cui}. Mediu de lucru PROD.");
            Console.WriteLine("Am incercat resetarea parolei prin mail, doar ca nu avem acces in portal, deoarece certificatul a expirat.");
            Console.WriteLine($"\nMultumim!\n{companyName}");

            Pause();
        }

        public static void OsmrAlerts() // Creare raspunsuri pentru alerte osmr
        {
            FunctionUnavailable();
            Pause();

        }

        public static void OsmrProcedures() // Diferite proceduri OSMR
        {
           FunctionUnavailable();
           Pause();
        }
        



    }
}

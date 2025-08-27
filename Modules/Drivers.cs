using System;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using static HelpDesk.Functions;

namespace HelpDesk.Modules
{
    public static class Drivers
    {
        public static void DriversMenu()
        {
            Console.Clear();
            // UIManager.DisplayLogo("Drivers");
            UIManager.DisplayMenu("Drivers");
        }

        public static void CardReaderDriver()
        {
            UIManager.DisplayLogo("Drivers");
            Info("Pentru functionarea cititorului de carduri Omnikey, trebuie instalat urmatorul driver:");
            Download("HID Omnikey Global Driver", "https://drive.google.com/file/d/1c9GGHFPeP6rdvGSVPvW5B-0_FUhph2SV/view?usp=sharing");
            Info("Pentru modelul Omnikey 3821, este necesar instalarea aplicatiei CardMan!");
            Download("CardMan", "https://drive.google.com/file/d/1ORzSaU39nPFGUCRSuOHjGzzP_dZGYu-R/view?usp=sharing");
            Pause();
        }

        public static void ScannerDriver() 
        {
            UIManager.DisplayMenu("Scanner");
        }

        public static void ScannerZebra() // Zebra
        {
            UIManager.DisplayLogo("Drivers");
            Info("Pentru functionarea scannerului Zebra, trebuie instalate urmatoarele:");
            Download("Zebra CDC Driver", "https://drive.google.com/file/d/1WzJ3NYX4WCkkipnS5cvxKZUgsg3bpk9r/view?usp=sharing");
            Download("Symbol COM Port Emulation", "https://drive.google.com/file/d/11UuKyfQB3QntvgVvOEt3NfaGE9koyywE/view?usp=sharing");
            ResetareZebraMotorola(); Pause();
        }

        public static void ScannerMotorola() // Motorola
        {
            UIManager.DisplayLogo("Drivers");
            Info("Pentru functionarea scannerului Motorola, trebuie instalate urmatoarele:");
            Download("Motorola CDC Driver", "https://drive.google.com/file/d/1DV8UXct2ydsrlnjh5hQNXuCO4HT36FgY/view?usp=sharing");
            Download("Symbol COM Port Emulation", "https://drive.google.com/file/d/11UuKyfQB3QntvgVvOEt3NfaGE9koyywE/view?usp=sharing");
            ResetareZebraMotorola(); Pause();
        }

        public static void ScannerIntermec()
        {
            UIManager.DisplayLogo("Drivers");
            Info("Daca Scannerul Intermec nu functioneaza fara driver, trebuie instalata si configurata aplicatia EasySet.");
            Download("EasySet", "https://drive.google.com/file/d/1TvxqxEL3rhHOINU7P3SGXJx29YqcXpha/view?usp=sharing");
            Pause();
        }

        public static void ScannerHoneywell()
        {
            UIManager.DisplayLogo("Drivers");
            Info("Pentru functionarea scannerului Honeywell, trebuie instalate urmatoarele:");
            Download("Zebra CDC Driver", "https://drive.google.com/file/d/1WzJ3NYX4WCkkipnS5cvxKZUgsg3bpk9r/view?usp=sharing");
            Download("Symbol COM Port Emulation", "https://drive.google.com/file/d/11UuKyfQB3QntvgVvOEt3NfaGE9koyywE/view?usp=sharing");
            Info("Pentru resetarea scannerului sau mutarea din keyboard in COM, scanati urmatoarele coduri:");
            Download("Resetare scanner", "https://drive.google.com/file/d/1GEFJs-1s058cb5xxXjMCTLjit2zfocnH/view?usp=sharing");
            Download("USB Serial Port Emulation", "https://drive.google.com/file/d/1o-Fj9HmE-RK-AQI3FuEy95mu15qZu7jj/view?usp=sharing");
            Pause();
        }

        public static void UniversalCodes()
        {
            UIManager.DisplayLogo("Drivers");
            Info("Codurile de mai jos, se pot folosi pe toate scannerele.");
            Download("Scanare automata", "https://drive.google.com/file/d/1AkHzFxEKaolqbvobk1dGMaajpLRbvoc0/view?usp=sharing");
            Download("Inversare fundal negru", "https://drive.google.com/file/d/1f5EoMLut1St7KnmioddjJTxbWziWJCrD/view?usp=sharing");
            Pause();
        }

        // Drivere generale scanner

        private static void ResetareZebraMotorola()
        {
            Info("Pentru resetarea scannerului sau mutarea din keyboard in COM, scanati urmatoarele coduri:");
            Download("Resetare scanner", "https://drive.google.com/file/d/1xkuh768vxcDyBI09PluXiQgLH0V65XTP/view?usp=sharing");
            Download("COM Port Emulation", "https://drive.google.com/file/d/1u_kONi-MVemiq_CmSlF7ySXyyE7lIz-s/view?usp=sharing");
        }


        // POS Bancar
        public static void POSDriver()
        {
            UIManager.DisplayLogo("Drivers");
            Info("Daca POS-ul bancar nu functioneaza fara driver, trebuie instalat urmatorul driver:");
            Download("Ingenico USB Driver", "https://drive.google.com/file/d/14NqYHZrPAOCMd5GKbPRMMSCz1IjhvOTq/view?usp=sharing");
            Pause();
        }

        // Certificate digitale
        public static void TokenDriver()
        {
            UIManager.DisplayMenu("Token");
        }

        public static void certSIGN()
        {
            UIManager.DisplayLogo("Drivers");
            Info("Pentru intalarea certificatelor emise de certSIGN, trebuie instalate urmatoarele:");
            Download("Driver certSIGN", "https://drive.google.com/file/d/1qeCw-hf2sSDOc572oDVd_l9f4MdhUlzS/view?usp=sharing");
            Download("Lant de incredere certSIGN", "https://drive.google.com/file/d/1s4aa8WelyoHgq7giEVdsuefa8fWXAu3K/view?usp=sharing");
            Colored("\nLantul de incredere trebuie salvat in Trusted Root Certification Authorities!", "warning");
            Pause();

        }

        public static void CertDigital()
        {
            UIManager.DisplayLogo("Drivers");
            Info("Pentru intalarea certificatelor emise de CertDigital, trebuie instalate urmatoarele:");
            Download("Driver CertDigital", "https://drive.google.com/file/d/1C74N7KEv428getrOw0qyr6iIzXRp6xwD/view?usp=sharing");
            Download("Lant de incredere CertDigital", "https://drive.google.com/file/d/1T04z3ZwWCay4ZsGTlF0cIEZ2HwFxMWqW/view?usp=sharing");
            Pause();
        }

        public static void Alfasign()
        {
            UIManager.DisplayLogo("Drivers");
            Info("Pentru intalarea certificatelor emise de Alfasign, trebuie instalate urmatoarele:");
            Download("Driver Alfasign", "https://drive.google.com/file/d/1-N1nF8oNiXf02ia2Xqv7X8PVsChcYya3/view?usp=sharing");
            Download("Lant de incredere Alfasign", "https://drive.google.com/file/d/1FQZiBUG-drzJ6oxbvONwauE8ViofEATg/view?usp=sharing");
            Pause();
        }


        

    }
}
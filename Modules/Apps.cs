using System;
using static HelpDesk.Functions;

namespace HelpDesk.Modules
{
    public static class Apps
    {
        public static void AppsMenu()
        {
            Console.Clear();
            UIManager.DisplayLogo("Apps");
            UIManager.DisplayMenu("Apps");

        }

        public static void DownloadPlusERP()
        {
            Download("PlusERP", "http://www.softeh.ro/users/PlusERP/");
            Download("Access Database Engine 2010", "https://drive.google.com/file/d/1pYr2OpNQFNo59X3Ozrcu_ByCY-pD3UpB/view?usp=sharings");
            Download("TLS Fix (Windows 7)", "https://drive.google.com/file/d/11OmK6FJOyZlHCSc23Tyg73Cu6Z5S8140/view?usp=sharing");
            Pause();
        }

        public static void DownloadSMFS()
        {
            Download("SMFS", "http://www.softeh.ro/users/PlusERP/");
            Console.WriteLine("\nDupa instalare, ruleaza CMD ca administrator si foloseste urmatorul cod:");
            Colored("netsh http add urlacl url=http://+:9011/ user=\\Everyone", "info");
            Pause();
        }

        public static void DownloadNetfarm()
        {
            Download("Netfarm", "https://drive.google.com/file/d/1be4MBqhEpN3n6pn65MiHwEs7I16eptye/view?usp=sharing");
            Download("Licente Netfarm", "https://drive.google.com/file/d/1LzYivBarNAvenxjniIgAkke1EBFh5kR6/view?usp=sharing");
            Pause();
        }

        public static void DownloadSybase()
        {
            Download("Sybase", "https://drive.google.com/file/d/17Y92_9exugaiJLWxSnmW7uMEBpF11ykS/view?usp=sharing");
            Download("Sybase DLC", "https://drive.google.com/file/d/17Y92_9exugaiJLWxSnmW7uMEBpF11ykS/view?usp=sharing");
            Pause();
        }

        public static void DownloadPS2()
        {
            Download("PS2", "https://drive.google.com/file/d/1zbFaBZNA_H-sPX24yaPFodHYRjr16T7w/view?usp=sharing");
            Download("PS2 (2.0.4.8)", "https://drive.google.com/file/d/1Iy0fyQ0J9bEy_Mt3H9R8zM8ljLrUkBKa/view?usp=sharing");
            Download("Lista 444", "https://drive.google.com/file/d/1zHuxPVLTZ2SRWUYP6QLhSZXYawnfemOc/view?usp=sharing");
            Pause();
        }

        public static void DownloadAnydesk()
        {
            Download("Anydesk", "https://drive.google.com/file/d/1Mii15H8IVnVwW_pINMsca2QPxcODq4Fb/view?usp=sharing");
            Pause();
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Modules.SqlServices
{
    public class ChangeOperationDate
    {
        public static void SchimbareDataBon()
        {
            Console.WriteLine("\nInainte de schimba data unui bon, asiguta-te ca a fost scos pe casa de marcat!");

            long DocNumberBon;
            while (true)
            {
                Console.Write("\nIntrodu numarul documentului (al bonului) - exemplu: 31221160614\nNumarul documentului = ");
                if (long.TryParse(Console.ReadLine()!.Trim(), out DocNumberBon)) break;
                Console.WriteLine("\nNumar invalid! Te rog introdu un numar valid! (vezi exemplu)");
            }

            double ValoareBon;
            while (true)
            {
                Console.Write("\nIntrodu valoarea bonului - exemplu: 27.35\nValoarea bonului = ");
                if (double.TryParse(Console.ReadLine()!.Trim(), out ValoareBon)) break;
                Console.WriteLine("\nValoare invalida! Te rog introdu o valoare valida! (vezi exemplu)");
            }


            Console.WriteLine("\nPentru a vizualiza bonul, foloseste urmatorul cod:\n");
            Console.WriteLine("select * from dbo.Operation where DocNumber = '" + DocNumberBon + "'");

            int IdBon;
            while (true)
            {
                Console.Write("\nIntrodu ID-ul bonului: ");
                if (int.TryParse(Console.ReadLine()!.Trim(), out IdBon)) break;
                Console.WriteLine("\nID invalid! Te rog introdu un ID valid!");
            }

            int IdCollectionBon;
            while (true)
            {
                Console.Write("\nIntrodu ID-ul colectiei asociate bonului: ");
                if (int.TryParse(Console.ReadLine()!.Trim(), out IdCollectionBon)) break;
                Console.WriteLine("\nID invalid! Te rog introdu un ID valid!");
            }

            Console.WriteLine("\nIntrodu datele necesare pentru schimbarea datei.");

            int ZiBon;
            while (true)
            {
                Console.Write("Zi: ");
                if (int.TryParse(Console.ReadLine()!.Trim(), out ZiBon) && ZiBon > 0 && ZiBon <= 31) break;
                Console.WriteLine("\nZi invalida! Te rog introdu o zi valida!");
            }

            int LunaBon;
            while (true)
            {
                Console.Write("Luna: ");
                if (int.TryParse(Console.ReadLine()!.Trim(), out LunaBon) && LunaBon > 0 && LunaBon <= 12) break;
                Console.WriteLine("\nLuna invalida! Te rog introdu o data valida!");
            }

            int AnBon;
            while (true)
            {
                Console.Write("An: ");
                if (int.TryParse(Console.ReadLine()!.Trim(), out AnBon)) break;
                Console.WriteLine("\nAn invalid! Te rog introdu un an valid!");
            }

            string ZiFormata = ZiBon.ToString("D2");
            string LunaFormata = LunaBon.ToString("D2");

            Console.WriteLine("\nPentru a schimba data bonului cu data dorita, foloseste urmatoarele coduri:\n");
            Console.WriteLine("update dbo.Operation set OperationDate = '" + AnBon + "-" + LunaFormata + "-" + ZiFormata + " 00:00:00.0000000' where id = '" + IdBon + "'");
            Console.WriteLine("update dbo.Operation set DocDate = '" + AnBon + "-" + LunaFormata + "-" + ZiFormata + " 00:00:00.0000000' where id = '" + IdBon + "'");
            Console.WriteLine("update dbo.Operation set SystemDate = '" + AnBon + "-" + LunaFormata + "-" + ZiFormata + " 00:00:00.0000000' where id = '" + IdBon + "'");
            Console.WriteLine("update dbo.Operation set ModifiedDate = '" + AnBon + "-" + LunaFormata + "-" + ZiFormata + " 00:00:00.0000000' where id = '" + IdBon + "'");

            Console.WriteLine("\nDupa schimbarea datei bonului, trebuie schimbata si data incasarii acestuia.");
            Console.Write("Apasa orice tasta pentru a continua...");
            Console.ReadKey();

            Console.WriteLine("\n\nPentru a vizualiza incasarea asociata bonului, foloseste urmatorul cod:\n");
            Console.WriteLine("select * from Payment where PaymentValue = '" + ValoareBon + "' and CollectionId = '" + IdCollectionBon + "' order by id desc");

            int IdIncasareBon;
            while (true)
            {
                Console.Write("\nIntrodu ID-ul incasarii asociate bonului: ");
                if (int.TryParse(Console.ReadLine()!.Trim(), out IdIncasareBon)) break;
                Console.WriteLine("\nID invalid! Te rog introdu un an valid!");
            }

            Console.WriteLine("\nPentru a modifica data incasarii asociate bonului, foloseste urmatoarele coduri:\n");
            Console.WriteLine("update Payment set DocDate = '" + AnBon + "-" + LunaFormata + "-" + ZiFormata + " 00:00:00.0000000' where id = '" + IdIncasareBon + "'");
            Console.WriteLine("update Payment set ModifiedDate = '" + AnBon + "-" + LunaFormata + "-" + ZiFormata + " 00:00:00.0000000' where id = '" + IdIncasareBon + "'");

            Console.WriteLine("\nAtat data bonului, cat si a incasarii asociate acestuia, au fost modificate cu data de " + ZiFormata + "." + LunaFormata + "." + AnBon + ".");
            Console.Write("Apasa orice tasta pentru a continua...");
            Console.ReadKey();
            Console.Write("\n");
        }
    }
}

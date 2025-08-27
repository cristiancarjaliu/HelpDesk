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


    static void SchimbareDataDoc()
    {
        Console.WriteLine("\n in curand");
    }

    static void SchimbareDataBon()
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

    static void InchideNT()
    {
        long DocNTnumber;
        while (true)
        {
            Console.Write("Introdu numarul documentului (al notei de transfer): ");
            if (long.TryParse(Console.ReadLine()!.Trim(), out DocNTnumber)) break;
            Console.WriteLine("\nNumar invalid! Te rog introdu un numar valid!");
        }
        Console.WriteLine("\nPentru a vizualiza nota de transfer, foloseste codul urmator:");
        Console.WriteLine("\nselect  Id, ImportFromOperationId, ImportOperationId, OperationDate, DocDate from dbo.Operation where DocNumber = '" + DocNTnumber + "' order by id desc");
        Console.WriteLine("\nIdentifica cu atentie cele doua documente!");


        Console.WriteLine("\nselect ImportFromOperationId, ImportOperationId, * from dbo.Operation where DocNumber = '" + DocNTnumber + "'");

        Console.WriteLine("\nIdentifica cu atentie cele doua documente!");


        int ImportFromOperationIdNT;
        while (true)
        {
            Console.Write("\nIntrodu ImportFromOperationId: ");
            if (int.TryParse(Console.ReadLine()!.Trim(), out ImportFromOperationIdNT)) break;
            Console.WriteLine("\nID invalid! Te rog introdu un an valid!");
        }

        int ImportOperationIdNT;
        while (true)
        {
            Console.Write("\nIntrodu ImportOperationId: ");
            if (int.TryParse(Console.ReadLine()!.Trim(), out ImportOperationIdNT)) break;
            Console.WriteLine("\nID invalid! Te rog introdu un an valid!");
        }

        Console.WriteLine("\nPentru a inchide nota de transfer in ambele locatii, foloseste codurile:");

        Console.WriteLine("\nUPDATE dbo.Operation set ImportFromOperationID = 'NULL' where id = '" + ImportFromOperationIdNT + "'");
        Console.WriteLine("UPDATE dbo.Operation set ImportOperationId = 'NULL' where id = '" + ImportOperationIdNT + "'");

        Console.WriteLine("\nUPDATE dbo.Operation SET IsClosed = '1' WHERE id = '" + ImportFromOperationIdNT);
        Console.WriteLine("UPDATE dbo.Operation SET IsClosed = '1' WHERE id = '" + ImportOperationIdNT);

        Console.WriteLine("\nUPDATE dbo.Operation SET ImportFromOperationID = '" + ImportFromOperationIdNT + "' WHERE id = '" + ImportOperationIdNT + "'");
        Console.WriteLine("UPDATE dbo.Operation SET ImportOperationId = '" + ImportOperationIdNT + "' WHERE id = '" + ImportFromOperationIdNT + "'");

    }


    static void Main()
    {
        UIManager.DisplayLogo("HelpDesk");
        UIManager.DisplayMenu("HelpDesk");
    }
}
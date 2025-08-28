using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Modules.SqlServices
{
    public class CloseTransferNote
    {
        public static void InchideNT()
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
    }
}

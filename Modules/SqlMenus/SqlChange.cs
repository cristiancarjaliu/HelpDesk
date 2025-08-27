using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelpDesk.Functions;


namespace HelpDesk.Modules.SqlMenus
{
    public static class SqlChange
    {
        public static void SqlChangeMenu()
        {
            Console.Clear();
            string warningMessage = " Inainte de a rula codurile generate de program, asigura-te de corectitudinea datelor! \n"
                          + " Programul poate genera coduri eronate! Codurile sunt exclusiv pentru aplicatia PlusERP!";
            UIManager.DisplayMenu("SqlChange", warningMessage);

        }

    }
}

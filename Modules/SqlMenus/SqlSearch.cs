using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static HelpDesk.Functions;

namespace HelpDesk.Modules
{
    public static class SqlSearch
    {

        public static void SqlSearchMenu() 
        { 
            Console.Clear();
            string warningMessage = " Inainte de a rula codurile generate de program, asigura-te de corectitudinea datelor! \n"
                          + " Programul poate genera coduri eronate! Codurile sunt exclusiv pentru aplicatia PlusERP!";
            UIManager.DisplayMenu("SqlSearch", warningMessage);
        }

        public static void SearchFiscalReceipt()
        {
            Info("Pentru a gasi un bon avem nevoie de numarul documentului si data acestuia - Exemplu: '31967860614' & '01.01.2025'");

            long nrDocBonCautare = ReadNumber("Introdu numarul documentului:");
            if (nrDocBonCautare == InputDefaults.EscapeNumber) return;

            DateTime dataBon = ReadDate("Introdu data bonului:");
            if (dataBon == InputDefaults.EscapeDate) return;

            Info("\nPentru a cauta bonul, foloseste urmatorul cod: ");
            SQL($"SELECT * FROM dbo.Operation WHERE DocNumber = '{nrDocBonCautare}' AND DocDate = '{dataBon:yyyy-MM-dd}'");

            Pause();
        }



        public static void SearchPrescription()
        {
            Info("Pentru a gasi o reteta avem nevoie de seria si numarul acesteia - Exemplu: 'NOTMBA' & '4358'");

            string SerieRetetaCautata = ReadText("Introdu seria retetei: ").ToUpper();
            if (SerieRetetaCautata == InputDefaults.EscapeString) return;

            long NumarRetetaCautata = ReadNumber("Introdu numarul retetei: ");
            if (NumarRetetaCautata == InputDefaults.EscapeNumber) return;

            Info("\nPentru a cauta reteta, foloseste urmatorul cod:");
            SQL("SELECT * FROM pharmacy.Prescription WHERE No = '" + NumarRetetaCautata + "' AND Series = '" + SerieRetetaCautata + "'");

            Pause();
        }

        public static void SearchDocument()
        {
            Info("Pentru a gasi un document avem nevoie de numarul si data acestuia - Exemplu - '31221160614' & '01.01.2025'");
            long nrDocumentCautat = ReadNumber("Introdu numarul documentului: ");
            if (nrDocumentCautat == InputDefaults.EscapeNumber) return;

            DateTime dataDoc = ReadDate("Introdu data documentului: ");
            if (dataDoc == InputDefaults.EscapeDate) return;

            Info("\nPentru a cauta bonul, foloseste urmatorul cod: ");
            SQL($"SELECT * FROM dbo.Operation WHERE DocNumber = '{nrDocumentCautat}' AND DocDate = '{dataDoc:yyyy-MM-dd}'");

            Pause();
        }

        public static void SearchPartner()
        {
            Info("Pentru a cauta un partener, introdu numele acestuia - Exemplu: 'Alliance'");
            string PartenerCautat = ReadInput("Introdu numele partenerului: ");
            if (PartenerCautat == InputDefaults.EscapeString) return;

            Info("Pentru a cauta partenerul, foloseste urmatorul cod:");
            SQL("SELECT * FROM dbo.Partner WHERE Name LIKE '%" + PartenerCautat + "%'");

            Hint();
            Info("Pentru a vedea toti partenerii poti folosi codul:");
            SQL("SELECT * FROM dbo.Partner");

            Pause();
        }

        public static void SearchPerson()
        {
            Info("Pentru a cauta o persoana, introdu numele acesteia - Exemplu: 'Razvan'");
            string PersoanaCautata = ReadInput("Introdu numele persoanei: ");
            if (PersoanaCautata == InputDefaults.EscapeString) return;

            Info("Pentru a cauta persoana, foloseste urmatorul cod:");
            SQL("SELECT * FROM dbo.Person WHERE Name LIKE '%" + PersoanaCautata + "%'");

            Hint();
            Info("Pentru a vedea toate persoanele poti folosi codul:");
            SQL("SELECT * FROM dbo.Person");

            Pause();
        }

        public static void SearchCollection()
        {
            Info("Pentru a cauta o colectie, introdu numele acesteia - Exemplu: 'Chiajna'");

            string ColectieCautata = ReadInput("Introdu un filtru pentru colectie: ");
            if (ColectieCautata == InputDefaults.EscapeString) return;

            Info("Pentru a cauta colectia, foloseste urmatorul cod:");
            SQL("SELECT * FROM dbo.Collection WHERE Name LIKE '%" + ColectieCautata + "%'");

            Hint();
            Info("Pentru a vedea toate colectiile poti folosi codul:");
            SQL("SELECT * FROM dbo.Collection");

            Pause();
        }

        public static void SearchUser()
        {
            Info("Pentru a cauta un utilizator, introdu numele acestuia - Exemplu: 'Anca Maria'");

            string UtilizatorCautat = ReadInput("Introdu numele utilizatorului:");
            if (UtilizatorCautat == InputDefaults.EscapeString) return;

            Info("Pentru a cauta utilizatorul, foloseste urmatorul cod:");
            SQL($"SELECT * FROM dbo.AppUser WHERE Name LIKE '%" + UtilizatorCautat + "%'");

            Hint();
            Info("Pentru a vedea toti utilizatorii poti folosi codul:");
            SQL("SELECT * FROM dbo.AppUser");

            Pause();

        }
    }
}
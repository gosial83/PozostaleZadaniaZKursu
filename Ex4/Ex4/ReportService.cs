using Ex4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;

namespace Ex4
{
    public class ReportService
	{
		// Metoda tworząca raport sprzedaży produktów
		// Opis argumentów:
		// saleDateEnd: Koniec daty sprzedaży. Raport dotyczy spredaży produktów od tej daty do 7 dni wstecz
		// productsWithSalesCount: Dane prduktu gdzie Tuple<Product, int> to Prdukt oraz liczba sprzedanych egzemplarzy
        public string CreateProductsReport(
            DateTime saleDateEnd,
            List<ProductSaleSummary>  productsWithSalesCount)
        {
            // Zadanie 1
            // **********
            // Należy zaimplementować tą metodę:
            // Metoda ta tworzy plik TXT z danymi odnośnie ilości sprzedanych produktów od zadanej daty do 7 dni wstecz.
            // Metoda jako wynik operacji zwraca ścieżkę do utworzonego pliku. 
            // Plik powinien zostać zapisany w miejscu uruchomienia programu w podfolderze /Reports
            // Przykład:
            // D:\projects\Ex4\bin\Debug\net5.0\Reports\feafef6a-4309-45fd-848a-03856dbac656.txt
            // gdzie "D:\projects\Ex4\bin\Debug\net5.0"
            // to folder, z którego progam się uruchamia po wciśnięciu np. F5
            // a feafef6a-4309-45fd-848a-03856dbac656 to wygenerowana unikalna nazwa pliku (GUID)

            // Przykładowa zawartość pliku to:
            // Data sprzedaży od {saleDateEnd - 7 dni} do {saleDateEnd}
            // Sprzedane produkty to:
            // Produkt {nazwa produktu}, cena {cena produktu} - sprzedanych: {ilośc sprzedanych produktów}
            //
            // (Przykład wygenerowanego raportu jest w folderze ReportsExample)

            // Zadanie 2
            // **********
            // Może tą metodę da się napisac lepiej/inaczej? - zaproponuj coś :)
            // Podpowiedź: 
            // - List<Tuple<Product, int> ? a może coś innego ?
            // - Sposób tworzenia ścieżki pliku (poniżej) .... chyba można lepiej

            var saleDateStart = saleDateEnd.AddDays(-7).ToShortDateString();
            var shortSaleDateEnd = saleDateEnd.ToShortDateString();

            string fileNameDateFrom = saleDateStart.Replace('.', '_');
            string fileNameDateTo = shortSaleDateEnd.Replace('.', '_');

            if (!Directory.Exists("Reports"))
                Directory.CreateDirectory("Reports");

            var filePath = $"Reports/Sale_report_from_{fileNameDateFrom}_to_{fileNameDateTo}.txt";

            StreamWriter sw = File.CreateText(filePath);

            sw.WriteLine($"Data sprzedaży od {saleDateStart} do {shortSaleDateEnd} ");
            sw.WriteLine("Sprzedane produkty to:");

            foreach (var row in productsWithSalesCount)
            {
                sw.WriteLine($"Produkt {row.Product.Name}, cena {row.Product.Price} - sprzedanych {row.QuantitySold} ");
            }
            sw.Close();
            return filePath;
        }
    }
}

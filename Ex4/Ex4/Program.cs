using Ex4.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dane testowe
            var sellDateEnd = DateTime.Now;
            var productsSalesData = new List< ProductSaleSummary>
            {
                (new ProductSaleSummary(new Product("Browar", 5), 100)),
                new ProductSaleSummary(new Product("Whisky", 100), 10),
                new ProductSaleSummary(new Product("Rum", 30), 7),
                new ProductSaleSummary(new Product("Wódka", 23), 203),
                new ProductSaleSummary(new Product("Brandy", 43), 16),
                new ProductSaleSummary(new Product("Piwo bezalkoholowe", 2), 0)
            };

            // Tworzymy raport
            var reportService = new ReportService();

            var reportFilepath = reportService.CreateProductsReport(sellDateEnd, productsSalesData);

            //Sprawdzamy czy jest OK ;)

            var fileInfo = new FileInfo(reportFilepath);

            Console.WriteLine($"Plik został stworzony? - {fileInfo.Exists}");

            if (fileInfo.Exists)
            {
                Console.WriteLine($"Długość pliku w bajtach: - {fileInfo.Length}");

                if (fileInfo.Length == 0)
                {
                    Console.WriteLine("Plik pusty - coś nie tak ;)");
                }

                using (var streamReader = fileInfo.OpenText())
                {
                    var reportData = streamReader.ReadToEnd();

                    Console.Write(reportData);
                }
            }
            else
            {
                Console.WriteLine("Coś poszło nie tak");
            }

            Console.ReadKey();
        }
    }
}

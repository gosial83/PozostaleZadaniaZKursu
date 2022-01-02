using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5
{
    public class Homework
    {
        //TODO: Do każdej z metod dodaj wypisywanie wyniku na konsolę w czytelny i przejrzysty sposób ;)
        public void E1()
        {
            // Każdy z wyrazow „weź” w cudzysłów

            string[] words = new[] { "ala", "ma", "kota" };

            Console.WriteLine("Result of exercise: 1 ");
            words.ToList().ForEach(n => Console.Write($"\"{n}\" "));
            Console.WriteLine();
        }

        public void E2()
        {
            // Znajdź takie słowa które zaczynają się na A i kończą na A. Wielkość liter nie ma znacznia.
            // 
            string[] words = new[] { "Ala", "ma", "kota", "beata", "ameba", "Amanda", "Albert" };

            Console.WriteLine("\nResult of exercise: 2");
            words.Where(w => w.ToString().ToUpper().StartsWith("A"))
                .Where(w => w.ToString().ToUpper().EndsWith("A")).ToList()
                .ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            //Wynik: Ala ameba Amanda
        }

        public void E3()
        {
            // Połącz liczby tak aby w rezultacie dały jeden string „0, 1, 2, 3, 4, 5” // zera nie ma w kolekcji celowo, .Aggregate np.? hint hint*
            
            int[] numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nResult of exercise: 3");
            Console.WriteLine(numbers.Aggregate("0", (current, next) => current + ", " + next));
        }

        public void E4()
        {
            // Policz sumę liczb w tablicy (uwaga liczby są typu string)

            string[] numbersAsStrings = new[] { "1", "2", "3", "4" };
            var sum = numbersAsStrings.Select(n => int.Parse(n)).Sum();
            var type = sum.GetType();

            Console.WriteLine("\nResult of exercise: 4");
            Console.WriteLine($"{sum} : {type.Name.Substring(0, 3).ToLower()}");
            //WyniK:  10 : int
        }

        public void E5()
        {
            string votes = "Yes,No,Yes,Yes,Yes,No,No,Yes,Yes,No";
            var voltesSplited = votes.Split(',');
            var votesDiff = voltesSplited.Count(e => e == "Yes") - voltesSplited.Count(e => e == "No");

            Console.WriteLine("\nResult of exercise: 5");
            Console.WriteLine($"o {votesDiff} głosy");
            //o ile więcej było głosów na 'tak' ?

            // Wynik: o 2 głosy.
        }

        public void E6()
        {
            // Sprawdź czy WSZYSTKIE napisy w tablicy mają długość 5 - jeśli tak wyświetl "tak", jeśli nie wyświetl "nie" (chodzi tutaj o metodę LINQ używaną do warunkowania ;))
            // Uwaga! NIE możesz użyć zaprzeczenia w ifie! (czyli "!", np. !warunek).

            var ids = new[] { "zxcsd", "wetyr", "ajlhf", "otire", "eoibx", "xcbvs", "xsjkwq", "xcjff", "5444r" };

            Console.WriteLine("\nResult of exercise: 6");
            if (ids.All(i=>i.Length==5)) // Ten if/warunek jest do zmiany, nic więcej nie trzeba zmieniać
            {
                Console.WriteLine("tak");
            }
            else
            {
                Console.WriteLine("nie");
            }
        }
    }
}

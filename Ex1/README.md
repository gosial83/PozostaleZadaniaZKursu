# Zad 1. podstawy C#

Utwórz nowy projekt typu Console i napisz następujące instrukcje w kodzie C#, pamiętając o dobrych regułach ich nazywania:
1. Utwórz 3 zmienne w programie - `traveled` (liczba przejechanych kilometrów) , `usedFuel` (zużyte paliwo, w litrach), `averageConsumption` (średnie spalanie).
2. Wartości `traveled` i `usedFuel` powinny być podawane przez użytkownika do konsoli (hint: Console.ReadLine).
3. Utwórz oddzielną metodę `CalculateAvarageConsumption` zwracającą średnie spalanie. 
4. Przypisz wartość zwracaną z powyższej metody do `averageConsumption` i wyświetl wynik w konsoli z odpowiednim dopiskiem (np. średnie spalanie to: X).
5. (opcjonalnie) Program powinien działać w kółko i umożliwić podanie danych i wykonanie obliczeń nieskończoną ilość razy, do momentu aż użytkownik nie kliknie klawisza X (hint: Console.ReadKey) (możesz założyć, że klawisz może zostać wciśnięty dopiero po podaniu obu cyfr i wyświetleniu wyniku, nie w trakcie podawania wartości).
6. (opcjonalnie) Walidacja - użytkownik powinien zostać poinformowany kiedy poda nieprawidłowe wartości (np. litery zamiast cyfr) i program powinien tę sytuację obsłużyć (czytaj nie wysypać się tylko pozwolić podać liczbę ponownie)

Powodzenia :)

# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwecji `nrzadania_ImięNazwisko` (np: `1_PatrykSzwermer`)

Jako że to początek przygody z GIT'em przejdźmy razem przez wszystkie kroki które musisz wykonać.

## :construction_worker: 
1. Przejdź w konsoli do miejsca gdzie chcesz mieć repozytorium.
2. Sklonuj repozytorium wykonując: `git clone https://github.com/infoshareacademy/jcsz1-homeworks.git`
3. Stwóż brancha o dobrej nazwie, np: `1_PatrykSzwermer` poprzez 
```
git checkout -b 1_PatrykSzwermer
```
lub z wykorzystaniem ulubionego GIT GUI.

4. Upewnij się że poprawnie zalożyleś/aś brancha. 
```
git status
```

Tekst w konsoli powinien głosić `On branch 1_PatrykSzwermer` (w moim przypadku)

5. Wykonaj zadanie i commituj wyniki. Aby wykonać commit, najprościej:
```
git add -A
git commit -m "this is my commit message"
```
5. Wyślij zmiany na github'a poprzez push 
```
git push
```
6. Twoje zmiany oraz branch powinny znajdować się na github'ie, upewnij się tutaj: https://github.com/infoshareacademy/jcsz2-homeworks/branches
7. Chcesz dodać kolejne zmiany? commit i push ... i tak aż do zakończenia :smiley_cat:
7. W razie potrzeby - łapcie mnie na slacku

---

# :clock3: Termin
## 24.09.2021, godz 24:00 

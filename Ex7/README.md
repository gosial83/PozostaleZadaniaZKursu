
# Zad 7. SQL

Utwórz **pojedynczy** plik scripts.sql zawierający następujące skrypty:
1. Utworzenie tabeli Student z następującymi właściwościami:
- Id
- Name (max 100 znaków, wymagane)
- PESEL (11 znaków, wymagane, unikalne)
- Gender (wiemy, że zawsze będzie to 1 znak, ustaw ograniczenie, że musi to być albo "M" albo "F", wymagane)
- Class (2 znaki, wymagane)
- NumberOfAbsences (liczba, domyślna wartość 0)
- Comment (opcjonalne pole tekstowe na max 255 znaków)
- Birthday (data, wymagana)
2. Utworzenie tabeli Class z następującymi właściwościami:
-  Id
- Name (max 5 znaków, wymagane)
- RoomNumber (cyfra, max 999, wymagana)
- Description (max 255 znaków, opcjonalne)
3. Utworzenie tabeli "StudentClass" łączącej w relacji wiele do wielu studenta i klasę (zakładamy, że uczeń może być w wielu klasach, American style)
4. Dodanie przykładowych danych do bazy (najlepiej minimum po 5 wpisów, takich, żeby poniższe zapytania coś zwracały).
5. Zapytanie wyświetlające wszystkich studentów których ilość nieobecności jest większa niż 24
6. Zapytanie wyświetlające studentów zapisanych do klasy 3C
7. (dodatkowo) Zapytanie wyświetlające klasy przypisane do pokoju 123, z minimum 3 studentami o liczbie nieobecności większej niż 10.

# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwencji `nrzadania_ImięNazwisko` (np: `7_PatrykSzwermer`)

Powodzenia :)

---

# :clock3: Termin
## 20.11.2021, 15:00 

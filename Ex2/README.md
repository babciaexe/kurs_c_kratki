
# Zad 2. podstawy C# - Timer

Napisz program "Timer" (Minutnik? :P ), którego zadaniem będzie odegranie kilku dźwięków informujących, że zadany czas minął. Tym razem macie już utworzony projekt i plik Program.cs, więc proszę abyście ich użyli i nie tworzyli nowych plików projektu (poza plikami z kodem oczywiście, jeśli będziecie chcieli/potrzebowali).

Polecenia i wskazówki:

1. Do odegrania dźwięku (melodii) użyjemy metody:
`Console.Beep(cześtotliwość, czas odtwarzania).`
Do zrobienia pauzy między poszczególnymi dźwiękami użyjmy:
` Thread.Sleep(liczbaMilisekund)`  np.: Thread.Sleep(500) => pół sekundy, Thread.Sleep(3000) => 3 sekundy.
2. Program powinien posiadać predefiniowaną **listę możliwych czasów odliczania**. Np: minuta, 10 sekund, 30 sekund, 1 minuta, 5 minut (i dowolne inne wartości które wg Was mogą być użyteczne). Spróbujcie użyć kolekcji `Dictionary<>` - najlepszy sposób użycia spróbujcie wymyślić sami :)
Przykład użycia znajdziecie np. tutaj: https://www.tutorialsteacher.com/csharp/csharp-dictionary
4. Po uruchomieniu program powinien poinformować, że użytkownik może wystartować timer i ma wybrać czas. Opcje do wyboru powinny być wyświetlone na podstawie wyżej wspomnianej listy.

Przykładowy output:
*"Witaj w aplikacji [Timer]*
 Wybierz czas: 
 1. 30 sekund
  2. 3 minuty 
  3. 10 minut 
  4. Inna wartość
 
   ESC: zakończ program"

4. Po wybraniu opcji 4, aplikacja powinna spytać użytkownika o inną wartość a następnie jej użyć.
5. Użytkownik powinien zobaczyć na ekranie informację, że timer wystartował.
6. Co sekundę użytkownik powinien widzieć czas pozostały do końca odliczania w postaci:

00:04
00:03
00:02
00:01

Czas minął! (I tutaj wyłącza się alarm/melodia)

(Każda wartość z czasem pozostałym wyświetla się w nowej linii – opcjonalnie możecie spróbować zrobić, aby czas nadpisywał się bez dodawania nowej linii)

7. Po zakończeniu odgrywania melodii powinniśmy zobaczyć pytanie: "Czy chcesz uruchomić kolejny timer?" Jeżeli użytkownik wybierze "Tak" wyświetlimy początkowe menu. W przeciwnym razie aplikacja powinna się zakończyć.

Powodzenia :)

# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwecji `nrzadania_ImięNazwisko` (np: `2_PatrykSzwermer`)

Jako że to początek przygody z GIT'em przejdźmy razem przez wszystkie kroki które musisz wykonać.

## :construction_worker: 
1. Przejdź w konsoli do miejsca gdzie chcesz mieć repozytorium.
2. Przejdź na branch master `git checkout master` i zpulluj jego obecny stan. `git pull`
3. Stwóż brancha o dobrej nazwie na podstawie mastera, np: `2_PatrykSzwermer` poprzez 
```
git checkout -b 2_PatrykSzwermer
```
lub z wykorzystaniem ulubionego GIT GUI.

4. Upewnij się że poprawnie zalożyleś/aś brancha. 
```
git status
```

Tekst w konsoli powinien głosić `On branch 2_PatrykSzwermer` (w moim przypadku)

5. Wykonaj zadanie i commituj wyniki. Aby wykonać commit, najprościej:
```
git add -A
git commit -m "this is my commit message"
```
5. Wyślij zmiany na github'a poprzez push 
```
git push
```
6. Twoje zmiany oraz branch powinny znajdować się na github'ie, upewnij się tutaj: https://github.com/infoshareacademy/jcszr4-homeworks/branches
7. Chcesz dodać kolejne zmiany? commit i push ... i tak aż do zakończenia :smiley_cat:
8. Tworzymy PR bazując na naszym branchu.

---

# :clock3: Termin
## 4.10.2021, 24:00 

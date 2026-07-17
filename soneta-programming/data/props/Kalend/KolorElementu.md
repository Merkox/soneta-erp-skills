# Pola i właściwości klasy biznesowej: `Soneta.Kalend.KolorElementu`
Nazwa tabeli: `KoloryElementow`
Tytuł: Kolory elementów
Opis: Element szczegółowy źródła koloru (IŹródłoKoloruElementu). Konfiguracja kolorystyki wyświetlania elementów kalendarza (stref, dni, nieobecności) — określa kolor tła i czcionki dla danego typu elementu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Zrodlo` → `IŹródłoKoloruElementu`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BackColor | `int` | bazodanowe | Kolor tła |  |
| ForeColor | `int` | bazodanowe | Kolor czcionki |  |
| Typ | `Soneta.Kalend.TypKoloruElementu` | bazodanowe, enum |  |  |
| Zrodlo | `Soneta.Kalend.IŹródłoKoloruElementu` | bazodanowe, guided-parent, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IŹródłoKoloruElementu` | `DefinicjaDnia`, `DefinicjaNieobecnosci`, `DefinicjaStrefy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypKoloruElementu (`Soneta.Kalend.TypKoloruElementu`)
- `DefinicjaDnia` = 1
- `Nieobecność` = 2
- `DefinicjaStrefy` = 3
- `UrlopPlanowy` = 1001
- `UrlopNaŻądanie` = 1002
- `ZwolnienieLekarskie` = 2001
- `ZwolnienieLekarskieBezOkresuWyczekiwania` = 2002
- `WypadekPrzyPracyLubChorobaZawodowa` = 2003 — Wypadek przy pracy lub choroba zawodowa (100%)
- `WypadekWDrodzeDoZPracy` = 2004 — Wypadek w drodze do lub z pracy (100%)
- `NiezdolnośćDoPracyWOkresieCiąży` = 2005 — Niezdolność do pracy w okresie ciąży (100%)
- `NadużycieAlkoholu` = 2006 — Niezdolność do pracy spowodowana nadużyciem alkoholu
- `UdziałWBójceLubWPobiciu` = 2007 — Udział w bójce lub w pobiciu (przestępstwo, wykroczenie)
- `LeczenieSzpitalne` = 2008
- `ZwolnienieSpowodowaneGruźlicą` = 2009
- `PobranieKomórekTkanekNarządów` = 2010 — Badanie lub pobranie komórek, tkanek, narządów (100%)
- `ChorobaZakaźna` = 2011 — Niezdolność do pracy spowodowaną chorobą zakaźną, której okres wylęgania jest dłuższy niż 14 dni, lub inną chorobą, której objawy chorobowe ujawniają się po okresie dłuższym niż 14 dni od początku choroby
- `KwarantannaPracownikaMedycznegoKoronawirus` = 2012 — Kwarantanna lub izolacja pracownika medycznego/służby państwowe - koronawirus (100%)
- `KwarantannaPracownikaKoronawirus` = 2013 — Kwarantanna lub izolacja pracownika - koronawirus (100%)
- `OpiekaSprawowanaNadDziećmi` = 2100 — Opieka sprawowana nad zdrowym dzieckiem w wieku do lat 8
- `OpiekaSprawowanaNadInnymiCzłonkamiRodziny` = 2101
- `OpiekaSprawowanaNadDziećmiDoLat14` = 2102
- `OpiekaSprawowanaNadDzieckiemNiepełnospDoLat18` = 2104 — Opieka sprawowana nad dzieckiem niepełnosprawnym w wieku od 8/14 lat do ukończenia 18 lat
- `OpiekaSprawowanaNadNoworodkiemDo8TygodniaŻycia` = 2103 — Opieka sprawowana nad noworodkiem do 8 tygodnia życia
- `ZamknięciePlacówkiOpiekuńczejKoronawirus` = 2105 — Zamknięcie placówki opiekuńczej
- `ZamknięciePlacówkiDorosłejOsobyKoronawirus` = 2106 — Zamknięcie placówki dorosłej osoby niepełnosprawnej
- `UrlopRehabilitacyjny` = 2200
- `UrlopRehabilitacyjnyCiąża` = 2201 — Urlop rehabilitacyjny w okresie ciąży (100%)
- `UrlopRehabilitacyjnyWypadek` = 2202 — Urlop rehabilitacyjny z powodu wypadku w drodze do lub z pracy (hist.)
- `UrlopRehabilitacyjnyWypadekPrzyPracy` = 2203 — Urlop rehabilitacyjny z powodu wypadku przy pracy lub choroby zawodowej (100%)
- `UrlopMacierzyński100` = 3001 — Urlop macierzyński (100%)
- `UrlopMacierzyński815` = 3004 — Urlop macierzyński (81,50%)
- `UrlopMacierzyński80` = 3002 — Urlop macierzyński (80%)
- `UrlopMacierzyński0` = 3003 — Urlop macierzyński (bez zasiłku)
- `UrlopRodzicielski815` = 3014 — Urlop rodzicielski (81,50%)
- `UrlopRodzicielski815ZaZyciem` = 3018 — Urlop rodzicielski (81,5% ustawa "Za życiem")
- `UrlopRodzicielski80` = 3010 — Urlop rodzicielski (80%)
- `UrlopRodzicielski70` = 3015 — Urlop rodzicielski (70%)
- `UrlopRodzicielski70do9tyg` = 3016 — Urlop rodzicielski (70% do 9 tygodni)
- `UrlopRodzicielski70ZaZyciem` = 3017 — Urlop rodzicielski (70% ustawa "Za życiem")
- `UrlopRodzicielski60` = 3011 — Urlop rodzicielski (60%)
- `UrlopRodzicielski100` = 3012 — Urlop rodzicielski (100%)
- `UrlopRodzicielski0` = 3013 — Urlop rodzicielski (bez zasiłku)

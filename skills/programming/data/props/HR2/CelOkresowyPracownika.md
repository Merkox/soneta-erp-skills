# Pola i właściwości klasy biznesowej: `Soneta.HR2.CelOkresowyPracownika`
Nazwa tabeli: `CeleOkresowePrac`
Tytuł: Cele okresowe
Opis: Cel okresowy wyznaczony pracownikowi w ramach zarządzania przez cele (MBO). Rejestruje nazwę celu, termin realizacji i wartość docelową, umożliwiając późniejszą ocenę stopnia realizacji.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oceniony | `bool` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Realizacja | `Soneta.HR2.RealizacjaCelu` | tylko-odczyt |  |  |
| Realizacje | `SubTable<Soneta.HR2.RealizacjaCelu>` | podlista |  |  |
| Termin | `Date` | bazodanowe |  |  |
| Wartosc | `Soneta.Oceny.WartośćElementuOceny` (subrow) | bazodanowe |  |  |
| Wartosc.Host | `Soneta.Oceny.IWartośćOcenyHost` | tylko-odczyt |  |  |
| Wartosc.Ocena | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe |  |  |
| Wartosc.Punktacja | `decimal` | bazodanowe | Punktacja |  |
| Wartosc.Uzasadnienie | `MemoText` | bazodanowe, podlista |  |  |
| Wartosc.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Wartosc.Wartosc2 | `decimal` |  |  |  |
| Wartosc.WartoscInt | `int` |  |  |  |
| Wartosc.WgOcena | `Key` | podlista |  |  |
| Wartosc.Wykonanie | `decimal` | bazodanowe | Wykonanie |  |
| Wartosc.WykonanieInt | `int` |  | Wykonanie |  |
| Wartosc.Wypełniona | `bool` | tylko-odczyt |  |  |

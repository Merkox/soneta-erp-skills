# Pola i właściwości klasy biznesowej: `Soneta.HR2.CelOkresowyPracownika`
Nazwa tabeli: `CeleOkresowePrac`
Tytuł: Cele okresowe
Opis: Cel okresowy wyznaczony pracownikowi w ramach zarządzania przez cele (MBO). Rejestruje nazwę celu, termin realizacji i wartość docelową, umożliwiając późniejszą ocenę stopnia realizacji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oceniony | `bool` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Realizacja | `Soneta.HR2.RealizacjaCelu` |  |  |  |
| Realizacje | `Soneta.Business.SubTable<Soneta.HR2.RealizacjaCelu>` |  |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| Wartosc | `Soneta.Oceny.WartośćElementuOceny` | bazodanowe |  |  |
| Wartosc.Host | `Soneta.Oceny.IWartośćOcenyHost` |  |  |  |
| Wartosc.Ocena | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe |  |  |
| Wartosc.Punktacja | `decimal` | bazodanowe | Punktacja |  |
| Wartosc.Uzasadnienie | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Wartosc.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Wartosc.Wartosc2 | `decimal` |  |  |  |
| Wartosc.WartoscInt | `int` |  |  |  |
| Wartosc.WgOcena | `Soneta.Business.Key` |  |  |  |
| Wartosc.Wykonanie | `decimal` | bazodanowe | Wykonanie |  |
| Wartosc.WykonanieInt | `int` |  | Wykonanie |  |
| Wartosc.Wypełniona | `bool` |  |  |  |

# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.Wyroznienie`
Nazwa tabeli: `Wyroznienia`
Tytuł: Certyfikaty, odznaczenia
Opis: Rejestr wyróżnień, certyfikatów i odznaczeń przyznanych uczestnikom. Dokumentuje wydane certyfikaty z datą uzyskania, numerem i powiązaniem ze zgłoszeniem szkoleniowym, umożliwiając śledzenie kwalifikacji członków.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 3
- subrowy: 1
- razem: 22

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowane | `bool` | bazodanowe |  | Wyróżnienie anulowane. |
| Data | `Date` | bazodanowe | Data uzyskania | Data uzyskania. |
| DefWyroznienia | `Soneta.CzlonkowieSzkolenia.DefWyroznienia` | bazodanowe |  |  |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| Nazwa | `string` | bazodanowe | Nazwa wyróżnienia | Nazwa wyróżnienia. |
| Numer | `string` | bazodanowe | Numer wyróżnienia | Numer wyróżnienia. |
| NumerAuto | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| NumerAuto.Numer | `int` | bazodanowe |  |  |
| NumerAuto.NumerPelny | `string` |  |  |  |
| NumerAuto.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| NumerAuto.Symbol | `string` | bazodanowe |  |  |
| NumerAuto.WgNumeruDokumentu | `Key` | podlista |  |  |
| NumerAuto.WgSymboluDokumentu | `Key` | podlista |  |  |
| Podpis1 | `string` | bazodanowe | Podpis 1 |  |
| Podpis2 | `string` | bazodanowe | Podpis 2 |  |
| Podpis3 | `string` | bazodanowe | Podpis 3 |  |
| PokazPodpisy | `bool` | tylko-odczyt |  |  |
| Stan | `Soneta.CzlonkowieSzkolenia.StanWyroznienia` (enum) | bazodanowe |  |  |
| Typ | `Soneta.CzlonkowieSzkolenia.TypWyroznienia` (enum) | bazodanowe, tylko-odczyt |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi | Dodatkowe uwagi. |
| Wyrozniony | `Soneta.Core.ITrainee` | bazodanowe |  |  |
| ZgloszenieUczestnik | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanWyroznienia (`Soneta.CzlonkowieSzkolenia.StanWyroznienia`)
- `Bufor` = 0 — Bufor
- `Zatwierdzony` = 1

### TypWyroznienia (`Soneta.CzlonkowieSzkolenia.TypWyroznienia`)
- `Certyfikat` = 1 — Certyfikat
- `Odznaczenie` = 2

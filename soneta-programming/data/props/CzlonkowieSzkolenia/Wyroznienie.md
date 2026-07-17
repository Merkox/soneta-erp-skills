# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.Wyroznienie`
Nazwa tabeli: `Wyroznienia`
Tytuł: Certyfikaty, odznaczenia
Opis: Rejestr wyróżnień, certyfikatów i odznaczeń przyznanych uczestnikom. Dokumentuje wydane certyfikaty z datą uzyskania, numerem i powiązaniem ze zgłoszeniem szkoleniowym, umożliwiając śledzenie kwalifikacji członków.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowane | `bool` | bazodanowe |  | Wyróżnienie anulowane. |
| Data | `Soneta.Types.Date` | bazodanowe | Data uzyskania | Data uzyskania. |
| DefWyroznienia | `Soneta.CzlonkowieSzkolenia.DefWyroznienia` | bazodanowe |  |  |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| Nazwa | `string` | bazodanowe | Nazwa wyróżnienia | Nazwa wyróżnienia. |
| Numer | `string` | bazodanowe | Numer wyróżnienia | Numer wyróżnienia. |
| NumerAuto | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| NumerAuto.Numer | `int` | bazodanowe |  |  |
| NumerAuto.NumerPelny | `string` |  |  |  |
| NumerAuto.Pelny | `string` | bazodanowe | Numer pełny |  |
| NumerAuto.Symbol | `string` | bazodanowe |  |  |
| NumerAuto.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerAuto.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Podpis1 | `string` | bazodanowe | Podpis 1 |  |
| Podpis2 | `string` | bazodanowe | Podpis 2 |  |
| Podpis3 | `string` | bazodanowe | Podpis 3 |  |
| PokazPodpisy | `bool` |  |  |  |
| Stan | `Soneta.CzlonkowieSzkolenia.StanWyroznienia` | bazodanowe, enum |  |  |
| Typ | `Soneta.CzlonkowieSzkolenia.TypWyroznienia` | bazodanowe, enum |  |  |
| Uczestnik | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi | Dodatkowe uwagi. |
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

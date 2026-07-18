# Pola i właściwości klasy biznesowej: `Soneta.Kasa.HistoriaStatusuBL`
Nazwa tabeli: `StatusBLHist`
Tytuł: Historia statusów Biała lista
Opis: Rejestr historii weryfikacji rachunku bankowego w Wykazie podatników VAT (Biała Lista). Przechowuje wyniki kolejnych sprawdzeń, w tym status, datę weryfikacji, identyfikator zapytania oraz zastosowaną metodę weryfikacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Date` | bazodanowe | Data aktualności |  |
| Data | `System.DateTime` | bazodanowe | Data sprawdzenia |  |
| IdentyfikatorZapytania | `string` | bazodanowe | Identyfikator zapytania |  |
| Informacja | `string` | bazodanowe | Informacja |  |
| MetodaWeryfikacji | `Soneta.Core.MetodaWeryfikacjiBialaLista` (enum) | bazodanowe | Metoda weryfikacji |  |
| RachunekBankowyPodmiotu | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| StatusBL | `Soneta.Core.StatusBialaLista` (enum) | bazodanowe | Status |  |
| ZweryfikowanyNumer | `string` | bazodanowe | Zweryfikowany numer konta |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### MetodaWeryfikacjiBialaLista (`Soneta.Core.MetodaWeryfikacjiBialaLista`)
- `ApiMF` = 0 — Serwis API MF
- `PlikPlaskiMF` = 1 — Plik płaski MF

### StatusBialaLista (`Soneta.Core.StatusBialaLista`)
- `Niezweryfikowany` = 0 — Niezweryfikowany
- `Zarejestrowany` = 1 — Zarejestrowany
- `Niezarejestrowany` = 2 — Niezarejestrowany
- `NiePodlega` = 3 — Nie podlega weryfikacji

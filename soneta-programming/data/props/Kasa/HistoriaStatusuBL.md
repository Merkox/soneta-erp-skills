# Pola i właściwości klasy biznesowej: `Soneta.Kasa.HistoriaStatusuBL`
Nazwa tabeli: `StatusBLHist`
Tytuł: Historia statusów Biała lista
Opis: Rejestr historii weryfikacji rachunku bankowego w Wykazie podatników VAT (Biała Lista). Przechowuje wyniki kolejnych sprawdzeń, w tym status, datę weryfikacji, identyfikator zapytania oraz zastosowaną metodę weryfikacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.Date` | bazodanowe | Data aktualności |  |
| Data | `System.DateTime` | bazodanowe | Data sprawdzenia |  |
| IdentyfikatorZapytania | `string` | bazodanowe | Identyfikator zapytania |  |
| Informacja | `string` | bazodanowe | Informacja |  |
| MetodaWeryfikacji | `Soneta.Core.MetodaWeryfikacjiBialaLista` | bazodanowe, enum | Metoda weryfikacji |  |
| RachunekBankowyPodmiotu | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| StatusBL | `Soneta.Core.StatusBialaLista` | bazodanowe, enum | Status |  |
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

# Pola i właściwości klasy biznesowej: `Soneta.Kadry.SzkolenieBHP`
Nazwa tabeli: `SzkoleniaBHP`
Tytuł: Szkolenia BHP
Opis: Szkolenie BHP pracownika rejestrujące termin skierowania, datę odbycia, zakres tematyczny i osobę prowadzącą. Służy do kontroli terminowości szkoleń z zakresu bezpieczeństwa i higieny pracy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 7
- podlisty: 1
- subrowy: 0
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| DataExt | `Date` | tylko-odczyt |  |  |
| Definicja | `Soneta.Kadry.DefinicjaSzkoleniaBHP` | bazodanowe |  |  |
| Następne | `Soneta.Kadry.SzkolenieBHP` | tylko-odczyt |  |  |
| NastępneDefinicja | `Soneta.Kadry.DefinicjaSzkoleniaBHP` | tylko-odczyt |  |  |
| NastępneTermin | `Date` |  | Termin następnego szkolenia |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Osoba | `string` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Termin | `Date` | bazodanowe |  |  |
| WażneDo | `Date` | tylko-odczyt |  |  |
| Wykonane | `bool` | tylko-odczyt |  |  |
| Zakres | `string` | bazodanowe |  |  |

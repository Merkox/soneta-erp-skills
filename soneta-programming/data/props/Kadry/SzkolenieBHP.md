# Pola i właściwości klasy biznesowej: `Soneta.Kadry.SzkolenieBHP`
Nazwa tabeli: `SzkoleniaBHP`
Tytuł: Szkolenia BHP
Opis: Szkolenie BHP pracownika rejestrujące termin skierowania, datę odbycia, zakres tematyczny i osobę prowadzącą. Służy do kontroli terminowości szkoleń z zakresu bezpieczeństwa i higieny pracy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataExt | `Soneta.Types.Date` |  |  |  |
| Definicja | `Soneta.Kadry.DefinicjaSzkoleniaBHP` | bazodanowe |  |  |
| Następne | `Soneta.Kadry.SzkolenieBHP` |  |  |  |
| NastępneDefinicja | `Soneta.Kadry.DefinicjaSzkoleniaBHP` |  |  |  |
| NastępneTermin | `Soneta.Types.Date` |  | Termin następnego szkolenia |  |
| Nazwa | `string` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Osoba | `string` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| WażneDo | `Soneta.Types.Date` |  |  |  |
| Wykonane | `bool` |  |  |  |
| Zakres | `string` | bazodanowe |  |  |

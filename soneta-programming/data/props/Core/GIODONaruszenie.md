# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODONaruszenie`
Nazwa tabeli: `GIODONaruszenia`
Tytuł: Naruszenia ochrony danych osobowych
Opis: Rejestr naruszeń ochrony danych osobowych zgodnie z RODO. Dokumentuje nazwę, datę i czas naruszenia, datę zgłoszenia, opis, liczbę osób dotkniętych, możliwe konsekwencje, zastosowane środki zaradzenia oraz przyczynę ewentualnego opóźnienia zgłoszenia.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IDokument`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasNaruszenia | `Soneta.Types.Time` | bazodanowe |  | Czas naruszenia |
| CzasZgloszenia | `Soneta.Types.Time` | bazodanowe |  | Czas zgłoszenia |
| Data | `Soneta.Types.Date` |  |  |  |
| DataNaruszenia | `Soneta.Types.Date` | bazodanowe |  | Data naruszenia |
| DataZgloszenia | `Soneta.Types.Date` | bazodanowe |  | Data zgłoszenia |
| Definicja | `Soneta.Core.IDefinicjaDokumentu` | iface-ref |  |  |
| Konsekwencje | `Soneta.Business.MemoText` | bazodanowe | Konsekwencje naruszenia | Możliwe konsekwencje naruszenie |
| LiczbaOsob | `int` | bazodanowe | Liczba osób | Przybliżona liczba osób, których dotyczy naruszenie |
| Nazwa | `string` | bazodanowe | Nazwa czynności | Nazwa czynności lub kategorii czynności |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis naruszenia | Opis naruszenia (w tym kategorie i liczba wpisów danych osobowych) |
| PrzyczynaOpoznienia | `Soneta.Business.MemoText` | bazodanowe | Przyczyna opóźnienia | Opis przyczyny opóźnienia zgłoszenia |
| SrodkiZaradzenia | `Soneta.Business.MemoText` | bazodanowe | Środki zaradzenia | Zastosowane/proponowane środki w celu zaradzenia naruszeniu lub zminimalizowania skutków naruszenia danych osobowych |
| ZbiorDanych | `Soneta.Core.GIODO.GIODOZbiorDanych` | bazodanowe | Zbiór danych |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definicja | `IDefinicjaDokumentu` | `ChronoOrder` |

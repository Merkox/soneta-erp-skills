# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODONaruszenie`
Nazwa tabeli: `GIODONaruszenia`
Tytuł: Naruszenia ochrony danych osobowych
Opis: Rejestr naruszeń ochrony danych osobowych zgodnie z RODO. Dokumentuje nazwę, datę i czas naruszenia, datę zgłoszenia, opis, liczbę osób dotkniętych, możliwe konsekwencje, zastosowane środki zaradzenia oraz przyczynę ewentualnego opóźnienia zgłoszenia.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IDokument`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 6
- subrowy: 1
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasNaruszenia | `Time` | bazodanowe |  | Czas naruszenia |
| CzasZgloszenia | `Time` | bazodanowe |  | Czas zgłoszenia |
| Data | `Date` | tylko-odczyt |  |  |
| DataNaruszenia | `Date` | bazodanowe |  | Data naruszenia |
| DataZgloszenia | `Date` | bazodanowe |  | Data zgłoszenia |
| Definicja | `Soneta.Core.IDefinicjaDokumentu` | tylko-odczyt, iface-ref |  |  |
| Konsekwencje | `MemoText` | bazodanowe, podlista | Konsekwencje naruszenia | Możliwe konsekwencje naruszenie |
| LiczbaOsob | `int` | bazodanowe | Liczba osób | Przybliżona liczba osób, których dotyczy naruszenie |
| Nazwa | `string` | bazodanowe | Nazwa czynności | Nazwa czynności lub kategorii czynności |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis naruszenia | Opis naruszenia (w tym kategorie i liczba wpisów danych osobowych) |
| PrzyczynaOpoznienia | `MemoText` | bazodanowe, podlista | Przyczyna opóźnienia | Opis przyczyny opóźnienia zgłoszenia |
| SrodkiZaradzenia | `MemoText` | bazodanowe, podlista | Środki zaradzenia | Zastosowane/proponowane środki w celu zaradzenia naruszeniu lub zminimalizowania skutków naruszenia danych osobowych |
| ZbiorDanych | `Soneta.Core.GIODO.GIODOZbiorDanych` | bazodanowe | Zbiór danych |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definicja | `IDefinicjaDokumentu` | `ChronoOrder` |

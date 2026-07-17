# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZgloszeniePozDok`
Nazwa tabeli: `ZgloszeniaPozDok`
Opis: Powiązanie zgłoszeń szkoleniowych z pozycjami dokumentów handlowych. Rejestruje faktury i inne dokumenty finansowe wystawione w związku ze zgłoszeniem uczestnika na szkolenie, umożliwiając rozliczenie kosztów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  |  |
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` | bazodanowe |  |  |
| Info | `string` |  |  |  |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  |  |
| PozycjaRelacji | `Soneta.Handel.PozycjaRelacjiHandlowej` | bazodanowe |  |  |
| Typ | `Soneta.CzlonkowieSzkolenia.ZgloszeniePozDokTyp` | bazodanowe, enum |  |  |
| Zgloszenie | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |
| ZgloszenieUczGrupa | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ZgloszeniePozDokTyp (`Soneta.CzlonkowieSzkolenia.ZgloszeniePozDokTyp`)
- `Zapotrzebowanie` = 1 — Zapotrzebowanie
- `Rozliczenie` = 2
- `Storno` = 3
- `Materiały` = 4
- `ZapotrzebowanieWpisowe` = 5
- `RozliczenieWpisowe` = 6

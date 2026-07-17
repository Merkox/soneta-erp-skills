# Pola i właściwości klasy biznesowej: `Soneta.CRM.PozycjaZdarzenia`
Nazwa tabeli: `PozycjeZdarzen`
Tytuł: Obsługa zdarzenia
Opis: Element szczegółowy zdarzenia CRM (PozycjaZdarzenia). Rejestruje kolejne etapy obsługi zdarzenia, umożliwiając śledzenie postępu realizacji z odrębnymi datami, operatorami i uwagami dla każdego kroku.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentZdarzenia`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Dokument | `Soneta.CRM.DokumentZdarzenia` | bazodanowe, guided-parent |  |  |
| Godzina | `Soneta.Types.Time` | bazodanowe |  |  |
| Kontakt | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| Pozostaje | `int` |  |  |  |
| Realizacja | `Soneta.Types.Date` | bazodanowe |  |  |
| RealizacjaGodzina | `Soneta.Types.Time` | bazodanowe |  |  |
| Temat | `string` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| TerminGodzina | `Soneta.Types.Time` | bazodanowe |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zrealizowana | `bool` |  |  |  |
| Zwłoka | `int` |  |  |  |

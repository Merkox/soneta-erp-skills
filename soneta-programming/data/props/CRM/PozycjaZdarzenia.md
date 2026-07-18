# Pola i właściwości klasy biznesowej: `Soneta.CRM.PozycjaZdarzenia`
Nazwa tabeli: `PozycjeZdarzen`
Tytuł: Obsługa zdarzenia
Opis: Element szczegółowy zdarzenia CRM (PozycjaZdarzenia). Rejestruje kolejne etapy obsługi zdarzenia, umożliwiając śledzenie postępu realizacji z odrębnymi datami, operatorami i uwagami dla każdego kroku.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentZdarzenia`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 1
- subrowy: 0
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Dokument | `Soneta.CRM.DokumentZdarzenia` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Godzina | `Time` | bazodanowe |  |  |
| Kontakt | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| Operator | `App.Operator` | bazodanowe |  |  |
| Pozostaje | `int` | tylko-odczyt |  |  |
| Realizacja | `Date` | bazodanowe, tylko-odczyt |  |  |
| RealizacjaGodzina | `Time` | bazodanowe, tylko-odczyt |  |  |
| Temat | `string` | bazodanowe |  |  |
| Termin | `Date` | bazodanowe |  |  |
| TerminGodzina | `Time` | bazodanowe |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| Zrealizowana | `bool` | tylko-odczyt |  |  |
| Zwłoka | `int` | tylko-odczyt |  |  |

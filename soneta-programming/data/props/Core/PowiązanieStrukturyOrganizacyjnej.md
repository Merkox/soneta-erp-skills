# Pola i właściwości klasy biznesowej: `Soneta.Core.PowiązanieStrukturyOrganizacyjnej`
Nazwa tabeli: `PowiazaniaStrOrg`
Tytuł: Powiązania elementyów struktur organizacyjnych
Opis: Element szczegółowy źródła powiązania (IŹródłoPowiązaniaStrukturyOrganizacyjnej). Reprezentuje powiązanie obiektu biznesowego (np. pracownika) z elementem struktury organizacyjnej, z okresem obowiązywania tego powiązania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zrodlo` → `IŹródłoPowiązaniaStrukturyOrganizacyjnej`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Element | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| IsReadOnlyEfektywnyOkres | `bool` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresEx | `Soneta.Types.FromTo` |  |  |  |
| Zrodlo | `Soneta.Business.IŹródłoPowiązaniaStrukturyOrganizacyjnej` | bazodanowe, guided-parent, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IŹródłoPowiązaniaStrukturyOrganizacyjnej` | `DbTuple`, `DokumentAktualizacjiKalendarza`, `KontaktOsoba`, `OcenaRealizacja`, `Operator`, `Pracownik` |

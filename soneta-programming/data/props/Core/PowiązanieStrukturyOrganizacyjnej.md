# Pola i właściwości klasy biznesowej: `Soneta.Core.PowiązanieStrukturyOrganizacyjnej`
Nazwa tabeli: `PowiazaniaStrOrg`
Tytuł: Powiązania elementyów struktur organizacyjnych
Opis: Element szczegółowy źródła powiązania (IŹródłoPowiązaniaStrukturyOrganizacyjnej). Reprezentuje powiązanie obiektu biznesowego (np. pracownika) z elementem struktury organizacyjnej, z okresem obowiązywania tego powiązania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zrodlo` → `IŹródłoPowiązaniaStrukturyOrganizacyjnej`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Element | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe, tylko-odczyt |  |  |
| IsReadOnlyEfektywnyOkres | `bool` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresEx | `FromTo` | podlista |  |  |
| Zrodlo | `IŹródłoPowiązaniaStrukturyOrganizacyjnej` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IŹródłoPowiązaniaStrukturyOrganizacyjnej` | `DbTuple`, `DokumentAktualizacjiKalendarza`, `KontaktOsoba`, `OcenaRealizacja`, `Operator`, `Pracownik` |

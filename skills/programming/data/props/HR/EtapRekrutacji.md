# Pola i właściwości klasy biznesowej: `Soneta.HR.EtapRekrutacji`
Nazwa tabeli: `EtapyRekrutacji`
Tytuł: Etapy rekrutacji
Opis: Element szczegółowy rekrutacji (Rekrutacja). Reprezentuje pojedynczy krok w procesie rekrutacyjnym kandydata, z przypisanym terminem, datą realizacji, osobą odpowiedzialną i opisem wyników.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOcenaPracownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.HR.DefinicjaEtapuRekrutacji` | bazodanowe |  |  |
| ElementyOceny | `SubTable<Soneta.HR.ElementOcenyPracownika>` | podlista |  |  |
| Lp | `int` | bazodanowe |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisLinia | `string` | tylko-odczyt |  |  |
| OpisPierwszaLinia | `string` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| Rekrutacja | `Soneta.HR.Rekrutacja` | bazodanowe, tylko-odczyt |  |  |
| Termin | `Date` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Odpowiedzialny | `IOceniający` | `KontaktOsoba`, `Pracownik`, `WykladowcaSzkol` |

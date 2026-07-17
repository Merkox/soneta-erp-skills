# Pola i właściwości klasy biznesowej: `Soneta.HR.EtapRekrutacji`
Nazwa tabeli: `EtapyRekrutacji`
Tytuł: Etapy rekrutacji
Opis: Element szczegółowy rekrutacji (Rekrutacja). Reprezentuje pojedynczy krok w procesie rekrutacyjnym kandydata, z przypisanym terminem, datą realizacji, osobą odpowiedzialną i opisem wyników.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOcenaPracownika`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.HR.DefinicjaEtapuRekrutacji` | bazodanowe |  |  |
| ElementyOceny | `Soneta.Business.SubTable<Soneta.HR.ElementOcenyPracownika>` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` |  |  |  |
| Rekrutacja | `Soneta.HR.Rekrutacja` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Odpowiedzialny | `IOceniający` | `KontaktOsoba`, `Pracownik`, `WykladowcaSzkol` |

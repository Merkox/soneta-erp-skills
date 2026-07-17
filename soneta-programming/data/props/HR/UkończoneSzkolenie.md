# Pola i właściwości klasy biznesowej: `Soneta.HR.UkończoneSzkolenie`
Nazwa tabeli: `UkonczSzkolenia`
Tytuł: Ukończone szkolenia
Opis: Ewidencja szkoleń ukończonych przez pracownika. Rejestruje temat, okres trwania i ocenę szkolenia, tworząc historię rozwoju zawodowego niezależnie od procesu wnioskowania.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOcenaPracownika`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe |  |  |
| ElementyOceny | `Soneta.Business.SubTable<Soneta.HR.ElementOcenyPracownika>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Ocena | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Wniosek | `Soneta.HR.WniosekOSzkolenie` | bazodanowe |  |  |

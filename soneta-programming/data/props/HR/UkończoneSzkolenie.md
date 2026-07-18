# Pola i właściwości klasy biznesowej: `Soneta.HR.UkończoneSzkolenie`
Nazwa tabeli: `UkonczSzkolenia`
Tytuł: Ukończone szkolenia
Opis: Ewidencja szkoleń ukończonych przez pracownika. Rejestruje temat, okres trwania i ocenę szkolenia, tworząc historię rozwoju zawodowego niezależnie od procesu wnioskowania.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOcenaPracownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe |  |  |
| ElementyOceny | `SubTable<Soneta.HR.ElementOcenyPracownika>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Ocena | `string` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Wniosek | `Soneta.HR.WniosekOSzkolenie` | bazodanowe, tylko-odczyt |  |  |

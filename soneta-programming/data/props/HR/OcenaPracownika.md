# Pola i właściwości klasy biznesowej: `Soneta.HR.OcenaPracownika`
Nazwa tabeli: `OcenyPracownikow`
Tytuł: Oceny pracowników
Opis: Dokument oceny okresowej pracownika. Rejestruje termin, datę przeprowadzenia i wynik oceny, umożliwiając śledzenie historii ocen w kontekście rozwoju zawodowego.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOcenaPracownika`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| ElementyOceny | `Soneta.Business.SubTable<Soneta.HR.ElementOcenyPracownika>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |

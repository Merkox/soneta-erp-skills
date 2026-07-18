# Pola i właściwości klasy biznesowej: `Soneta.HR.OcenaPracownika`
Nazwa tabeli: `OcenyPracownikow`
Tytuł: Oceny pracowników
Opis: Dokument oceny okresowej pracownika. Rejestruje termin, datę przeprowadzenia i wynik oceny, umożliwiając śledzenie historii ocen w kontekście rozwoju zawodowego.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOcenaPracownika`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| ElementyOceny | `SubTable<Soneta.HR.ElementOcenyPracownika>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisLinia | `string` | tylko-odczyt |  |  |
| OpisPierwszaLinia | `string` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Termin | `Date` | bazodanowe |  |  |

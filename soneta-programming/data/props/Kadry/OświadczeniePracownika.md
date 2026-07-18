# Pola i właściwości klasy biznesowej: `Soneta.Kadry.OświadczeniePracownika`
Nazwa tabeli: `OswiadczeniaPrac`
Tytuł: Oświadczenia pracowników
Opis: Oświadczenie złożone przez pracownika na podstawie wybranej definicji i treści. Rejestruje datę złożenia, okres obowiązywania, ewentualną datę wycofania oraz indywidualną treść oświadczenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 3
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataWycofania | `Date` | bazodanowe, tylko-odczyt | Data wycofania |  |
| DataZlozenia | `Date` | bazodanowe | Data złożenia |  |
| Definicja | `Soneta.Kadry.DefinicjaOświadczenia` | bazodanowe, tylko-odczyt | Oświadczenie |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Następne | `Soneta.Kadry.OświadczeniePracownika` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| Poprzednie | `Soneta.Kadry.OświadczeniePracownika` | tylko-odczyt |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Tresc | `MemoText` | bazodanowe, podlista | Treść |  |
| TrescOswiadczenia | `Soneta.Kadry.TreśćOświadczenia` | bazodanowe | Treść |  |

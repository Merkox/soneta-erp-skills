# Pola i właściwości klasy biznesowej: `Soneta.Kadry.OświadczeniePracownika`
Nazwa tabeli: `OswiadczeniaPrac`
Tytuł: Oświadczenia pracowników
Opis: Oświadczenie złożone przez pracownika na podstawie wybranej definicji i treści. Rejestruje datę złożenia, okres obowiązywania, ewentualną datę wycofania oraz indywidualną treść oświadczenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataWycofania | `Soneta.Types.Date` | bazodanowe | Data wycofania |  |
| DataZlozenia | `Soneta.Types.Date` | bazodanowe | Data złożenia |  |
| Definicja | `Soneta.Kadry.DefinicjaOświadczenia` | bazodanowe | Oświadczenie |  |
| EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Następne | `Soneta.Kadry.OświadczeniePracownika` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres obowiązywania |  |
| Poprzednie | `Soneta.Kadry.OświadczeniePracownika` |  |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Treść |  |
| TrescOswiadczenia | `Soneta.Kadry.TreśćOświadczenia` | bazodanowe | Treść |  |

# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien`
Nazwa tabeli: `ZklGrSzkolUpr`
Tytuł: Grupy szkoleń i uprawnień
Opis: Słownik porządkuje szkolenia i uprawnienia w logiczne kategorie tematyczne lub formalne. Używany w profilu szkoleń i uprawnień umożliwia zarządzanie wymaganiami rozwojowymi na wysokim poziomie.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |

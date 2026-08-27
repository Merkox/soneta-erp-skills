# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien`
Nazwa tabeli: `ZklGrSzkolUpr`
Tytuł: Grupy szkoleń i uprawnień
Opis: Słownik porządkuje szkolenia i uprawnienia w logiczne kategorie tematyczne lub formalne. Używany w profilu szkoleń i uprawnień umożliwia zarządzanie wymaganiami rozwojowymi na wysokim poziomie.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |

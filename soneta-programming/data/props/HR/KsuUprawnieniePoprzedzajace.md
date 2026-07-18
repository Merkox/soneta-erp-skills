# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.KSU.KsuUprawnieniePoprzedzajace`
Nazwa tabeli: `ZklKsuUprPop`
Tytuł: Powiązania informacji KSU z uprawnieniami poprzedzającymi
Opis: Tabela przechowuje wymagane uprawnienia formalne. Zapewnia zgodność z regulacjami i standardami, pozwala ustawić ścieżki uprawnień.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaInfo | `Soneta.HR.ZKL.Slowniki.KSU.KsuDefinicjaInfo` | bazodanowe, tylko-odczyt | Definicja informacji KSU |  |
| DefinicjaUprawnienia | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe | Uprawnienie poprzedzające |  |

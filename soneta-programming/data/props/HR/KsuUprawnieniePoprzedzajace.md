# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.KSU.KsuUprawnieniePoprzedzajace`
Nazwa tabeli: `ZklKsuUprPop`
Tytuł: Powiązania informacji KSU z uprawnieniami poprzedzającymi
Opis: Tabela przechowuje wymagane uprawnienia formalne. Zapewnia zgodność z regulacjami i standardami, pozwala ustawić ścieżki uprawnień.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaInfo | `Soneta.HR.ZKL.Slowniki.KSU.KsuDefinicjaInfo` | bazodanowe | Definicja informacji KSU |  |
| DefinicjaUprawnienia | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe | Uprawnienie poprzedzające |  |

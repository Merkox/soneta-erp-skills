# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaPoświadczeniaOdbioru`
Nazwa tabeli: `DefPoswOdbioru`
Tytuł: Definicje poświadczeń odbioru
Opis: Definicja wzorca poświadczenia odbioru dokumentu. Określa nazwę, treść poświadczenia i flagę blokady. Służy do konfiguracji treści oświadczeń, które użytkownicy potwierdzają przy odbiorze dokumentów.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Definicja zablokowana |
| Poswiadczenie | `string` | bazodanowe | Oświadczenie | Nazwa poświadczenia |
| Tresc | `MemoText` | bazodanowe, podlista | Oświadczenie | Treść poświadczenia |

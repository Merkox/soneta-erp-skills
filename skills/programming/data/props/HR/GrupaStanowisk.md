# Pola i właściwości klasy biznesowej: `Soneta.HR.GrupaStanowisk`
Nazwa tabeli: `GrupaStanow`
Tytuł: Grupy stanowisk
Opis: Grupowanie stanowisk pracy w organizacji według poziomów kariery i kategorii. Umożliwia klasyfikację stanowisk na potrzeby polityki wynagrodzeń, ścieżek kariery i analiz HR.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| KategoriaGrupyStanowisk | `Soneta.HR.KategoriaGrupyStanowisk` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe | opis kategorii |  |
| PoziomKariery | `string` | bazodanowe | Poziom kariery/stanowiska |  |
| Priorytet | `int` |  |  |  |
| Symbol | `string` |  |  |  |
| SymbolGrupy | `string` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |

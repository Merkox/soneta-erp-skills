# Pola i właściwości klasy biznesowej: `Soneta.Core.ElemSysZewn`
Nazwa tabeli: `ElementySysZewn`
Tytuł: Elementy systemu zewnętrznego
Opis: Konfiguracja elementów (obiektów biznesowych) obsługiwanych przez system zewnętrzny. Określa powiązanie obiektu wewnętrznego z systemem zewnętrznym, tryb pobierania, dodawania i obsługi pobranych danych oraz domyślność.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 1
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjeCen | `ViewInfo` | tylko-odczyt |  |  |
| Dodawanie | `bool` | bazodanowe | Dodawanie |  |
| Domyslny | `bool` | bazodanowe | Domyślny |  |
| Element | `IElemSysZewnHost` | bazodanowe | Element |  |
| ElementZewn | `string` | bazodanowe | Obiekt z systemu zewnętrznego | Wskazanie na obiekt z systemu zewnętrzenego |
| Magazyny | `ViewInfo` | tylko-odczyt |  |  |
| Pobieranie | `bool` | bazodanowe | Pobieranie |  |
| Podrzędne | `SubTable<Soneta.Core.ElemSysZewnRelacje>` | podlista |  |  |
| Rodzaj | `Soneta.Core.RodzajElementuSysZewn` (enum) | bazodanowe, tylko-odczyt | Rodzaj danych elementu |  |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe, tylko-odczyt | System zewnętrzny |  |
| TrybObslugiPobranego | `Soneta.Core.TrybObslugiPobranego` (enum) | bazodanowe | Tryb obsługi pobranego |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajElementuSysZewn (`Soneta.Core.RodzajElementuSysZewn`)
- `Magazyn` = 10 — Magazyn
- `GrupaTowarów` = 20 — Grupa towarów
- `SposobDostawy` = 30 — Sposób dostawy
- `SposobZaplaty` = 40 — Sposób zapłaty
- `CechaTowaru` = 50 — Cecha towaru
- `SysZewnImpDef` = 60
- `Producent` = 70 — Producent
- `CechaWariantu` = 80 — Cecha wariantu
- `ZestawCechWariantowych` = 90 — Zestaw cech wariantowych
- `DefDokHandlowego` = 100 — Definicja dokumentu handlowego
- `DefDokHandlowegoBuforStan` = 101 — Definicja synchronizacji stanu bufor
- `DefDokHandlowegoZatwierdzonyStan` = 102 — Definicja synchronizacji stanu zatwierdzony
- `CechaDokumentu` = 110 — Cecha dokumentu
- `CechaPozycji` = 120 — Cecha pozycji
- `CechaPartiiTowaru` = 130 — Cecha partii towaru
- `CechaKontrahenta` = 140 — Cecha kontrahenta
- `Lokalizacja` = 150 — Lokalizacja
- `Spedytor` = 160 — Spedytor
- `ESklep` = 170 — e-Sklep
- `DefinicjaCeny` = 180 — Definicja ceny
- `CechaKatalogu` = 190 — Cecha katalogu
- `Waluta` = 200 — Waluta
- `SzablonNazw` = 210 — Szablon nazw
- `SzablonCech` = 220 — Szablon cech
- `SzablonOpisow` = 230 — Szablon opisów
- `SzablonOpisowKr` = 232 — Szablon opisów krótkich

### TrybObslugiPobranego (`Soneta.Core.TrybObslugiPobranego`)
- `Brak` = 0 — Brak
- `Aktualizacja` = 1 — Aktualizacja
- `DodaniePodrzednego` = 2 — Dodanie podrzędnego

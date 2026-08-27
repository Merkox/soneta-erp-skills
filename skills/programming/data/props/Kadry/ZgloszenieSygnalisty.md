# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZgloszenieSygnalisty`
Nazwa tabeli: `ZgloszSygnalisty`
Tytuł: Naruszenie
Opis: Zgłoszenie sygnalisty dotyczące naruszenia prawa lub procedur wewnętrznych. Zawiera dane zgłaszającego, kategorię i kanał zgłoszenia, datę i miejsce naruszenia, opis, status sprawy, numer dokumentu oraz odpowiedź na zgłoszenie.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Data dokumentu |  |
| DataWystapieniaNaruszenia | `Date` | bazodanowe | Data wystąpienia naruszenia |  |
| DataZakonczenia | `Date` | bazodanowe | Data zakończenia |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Email | `string` | bazodanowe | Adres e-mail |  |
| Godzina | `Time` | bazodanowe | Godzina wystąpienia naruszenia |  |
| IsReadOnlyPodsumowanieGrup | `bool` | tylko-odczyt |  |  |
| IsVisibleOpisZadaniaDlaOperatora | `bool` | tylko-odczyt |  |  |
| KanalZgloszenia | `Soneta.Kadry.KanalZgloszeniaSygnalisty` | bazodanowe | Kanał zgłoszenia |  |
| Kategoria | `Soneta.Kadry.KategoriaZgloszeniaSygnalisty` | bazodanowe |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | tylko-odczyt, iface-ref |  |  |
| Miejsce | `string` | bazodanowe | Miejsce wystąpienia naruszenia |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe | Numer sprawy |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| OczekiwanaOdpowiedz | `bool` | bazodanowe | Oczekiwana odpowiedź |  |
| Odpowiedz | `string` | bazodanowe | Odpowiedź |  |
| Opis | `string` | bazodanowe | Opis zgłoszenia |  |
| OpisZadaniaDlaOperatora | `string` | bazodanowe | Opis zadania dla operatora |  |
| PodsumowaniePodjetychDzialan | `string` | tylko-odczyt |  |  |
| PowodAnulowania | `string` | bazodanowe | Powód anulowania |  |
| PrzetwarzanieZgloszenSygnalisty | `SubTable<Soneta.Kadry.PrzetwarzanieZgloszeniaSygnalisty>` | podlista |  |  |
| StatusZgloszenia | `Soneta.Kadry.StatusZgloszeniaSygnalisty` (enum) | bazodanowe |  |  |
| Zglaszajacy | `ITaskUser` | bazodanowe, iface-ref | Zgłaszający |  |
| ZgloszenieAnonimowe | `bool` | bazodanowe | Zgłoszenie anonimowe |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| Zglaszajacy | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusZgloszeniaSygnalisty (`Soneta.Kadry.StatusZgloszeniaSygnalisty`)
- `Wprowadzany` = 1
- `Przyjęty` = 10
- `Przetwarzany` = 11
- `Obsłużony` = 12
- `Odrzucony` = 20
- `Zakończony` = 22

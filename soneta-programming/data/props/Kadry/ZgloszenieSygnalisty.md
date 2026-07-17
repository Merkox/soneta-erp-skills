# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZgloszenieSygnalisty`
Nazwa tabeli: `ZgloszSygnalisty`
Tytuł: Naruszenie
Opis: Zgłoszenie sygnalisty dotyczące naruszenia prawa lub procedur wewnętrznych. Zawiera dane zgłaszającego, kategorię i kanał zgłoszenia, datę i miejsce naruszenia, opis, status sprawy, numer dokumentu oraz odpowiedź na zgłoszenie.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresEmail | `string` | bazodanowe | Adres e-mail |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data dokumentu |  |
| DataWystapieniaNaruszenia | `Soneta.Types.Date` | bazodanowe | Data wystąpienia naruszenia |  |
| DataZakonczenia | `Soneta.Types.Date` | bazodanowe | Data zakończenia |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Email | `string` | bazodanowe | Adres e-mail |  |
| Godzina | `Soneta.Types.Time` | bazodanowe | Godzina wystąpienia naruszenia |  |
| IsReadOnlyPodsumowanieGrup | `bool` |  |  |  |
| IsVisibleOpisZadaniaDlaOperatora | `bool` |  |  |  |
| KanalZgloszenia | `Soneta.Kadry.KanalZgloszeniaSygnalisty` | bazodanowe | Kanał zgłoszenia |  |
| Kategoria | `Soneta.Kadry.KategoriaZgloszeniaSygnalisty` | bazodanowe |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | iface-ref |  |  |
| Miejsce | `string` | bazodanowe | Miejsce wystąpienia naruszenia |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe | Numer sprawy |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| OczekiwanaOdpowiedz | `bool` | bazodanowe | Oczekiwana odpowiedź |  |
| Odpowiedz | `string` | bazodanowe | Odpowiedź |  |
| Opis | `string` | bazodanowe | Opis zgłoszenia |  |
| OpisZadaniaDlaOperatora | `string` | bazodanowe | Opis zadania dla operatora |  |
| PodsumowaniePodjetychDzialan | `string` |  |  |  |
| PowodAnulowania | `string` | bazodanowe | Powód anulowania |  |
| PrzetwarzanieZgloszenSygnalisty | `Soneta.Business.SubTable<Soneta.Kadry.PrzetwarzanieZgloszeniaSygnalisty>` |  |  |  |
| StatusZgloszenia | `Soneta.Kadry.StatusZgloszeniaSygnalisty` | bazodanowe, enum |  |  |
| Zglaszajacy | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Zgłaszający |  |
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

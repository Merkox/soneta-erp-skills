# Pola i właściwości klasy biznesowej: `Soneta.Zadania.HistZadania`
Nazwa tabeli: `HistZadan`
Tytuł: Historia zadań
Opis: Element szczegółowy zadania (Zadanie). Przechowuje migawkę stanu zadania CRM w momencie modyfikacji — dane kontrahenta, operatorów, terminy, wartości i stany — umożliwiając śledzenie historii zmian.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zadanie` → `Zadanie`

- pola bazodanowe: 32
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasDo | `Soneta.Types.Time` | bazodanowe | Godzina zakończenia | Planowana godzina zakończenia zadania |
| CzasModyfikacji | `Soneta.Types.Time` | bazodanowe |  |  |
| CzasOd | `Soneta.Types.Time` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia zadania |
| CzasZamkniecia | `Soneta.Types.Time` | bazodanowe | Godzina zamknięcia zadania | Godzina zamknięcia zadania |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Planowana data zakończenia zadania |
| DataModyfikacji | `Soneta.Types.Date` | bazodanowe |  |  |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia zadania |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe | Data zamknięcia zadania | Data zamknięcia zadania |
| EtapProjektu | `Soneta.Zadania.EtapProjektu` | bazodanowe |  |  |
| Kampania | `Soneta.Zadania.Kampania` | bazodanowe |  | Kampania, z którą powiązane jest zadanie |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Koszt | `Soneta.Types.Currency` | bazodanowe | Koszt | Szacowany koszt zadania |
| Modyfikujacy | `Soneta.Business.App.Operator` | bazodanowe | Operator modyfikujący zadanie |  |
| Nazwa | `string` | bazodanowe | Nazwa | Krótka nazwa zadania lub zdarzenia, na podstawie której będzie można go wyszukiwać |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis zadania lub zdarzenia |
| PriorytetZadania | `Soneta.Zadania.PriorytetZadania` | bazodanowe |  | Priorytet projektu. |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe |  | Projekt, z którym powiązane jest zadanie |
| Prowadzacy | `Soneta.Business.App.Operator` | bazodanowe | Zlecający | Osoba zlecająca zadanie |
| Przedstawiciel | `Soneta.CRM.KontaktOsoba` | bazodanowe | Przedstawiciel | Osoba odpowiedzialna za wykonanie zadania ze strony kontrahenta |
| Przychod | `Soneta.Types.Currency` | bazodanowe | Przychód | Szacowany przychód zadania |
| Rodzaj | `Soneta.Core.RodzajZadania` | bazodanowe, enum | Rodzaj zadania | Rodzaj zadania. Może być zadanie lub zdarzenie. Dziedziczone z definicji. |
| Role | `Soneta.Business.App.Role` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  | Rola dla której przypisane jest zadanie. |
| StanZadania | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan projektu. |
| Telefon | `string` |  |  |  |
| Urzadzenie | `Soneta.Zadania.Urzadzenie` | bazodanowe | Urządzenie, którego dotyczy przegląd | Urządzenie, którego dotyczy przegląd |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi | Uwagi dotyczące zadania wpisywane przez operatora wykonującego zadanie. |
| Wykonujacy | `Soneta.Business.App.Operator` | bazodanowe | Operator | Osoba wykonująca zadanie |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe, guided-parent |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajZadania (`Soneta.Core.RodzajZadania`)
- `Zadanie` = 1 — Zadanie
- `Zdarzenie` = 2
- `Zlecenie` = 3
- `Wypożyczenie` = 4
- `OrgPracyZdalnej` = 5 — Praca hybrydowa
- `Planowane` = 6 — Zdarzenie planowane
- `Incydentalne` = 7 — Zdarzenie incydentalne
- `Pomiar` = 8
- `Najem` = 9
- `Polisa` = 10
- `Szkoda` = 11
- `Rezerwacja` = 50 — Wewnętrzne
- `Kanban` = 51
- `Fleet` = 100 — Flota
- `Grupujace` = 150 — Zadanie grupujące
- `Projektowe` = 151 — Zadanie projektowe

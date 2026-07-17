# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.BudzetUprawnienie`
Nazwa tabeli: `BudzetUprawn`
Tytuł: Uprawnienia budżetów
Opis: Uprawnienie do pozycji budżetu projektu. Definiuje poziom dostępu (odczyt, edycja) dla operatora lub grupy organizacyjnej do konkretnej pozycji budżetowej.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudzetProjektu | `Soneta.Zadania.Budzetowanie.BudzetProjektu` | bazodanowe | Budżet projektu |  |
| GrupaUprawnionych | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| Poziom | `Soneta.Zadania.Budzetowanie.PoziomUprawnien` | bazodanowe, enum | Poziom uprawnień |  |
| PozycjaBudzetu | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` | bazodanowe | Pozycja budżetu |  |
| Uprawniony | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Uprawniony |  |
| ZGrupamiPodrzednymi | `bool` | bazodanowe | Z grupami podrzędnymi |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Uprawniony | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PoziomUprawnien (`Soneta.Zadania.Budzetowanie.PoziomUprawnien`)
- `Niezdefiniowany` = 0
- `WykonawcaPodstawowy` = 10 — Wykonawca podstawowy
- `WykonawcaZaawansowany` = 20 — Wykonawca zaawansowany
- `WykonawcaPelny` = 30 — Wykonawca
- `Dysponent` = 40 — Dysponent
- `Zarzadzajacy` = 50 — Zarządzający
- `Prowadzacy` = 60 — Prowadzący
- `BrakDostepu` = 70 — Brak dostępu

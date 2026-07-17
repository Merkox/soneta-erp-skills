# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.KolumnaZestKS`
Nazwa tabeli: `KolumnyZestKS`
Tytuł: Kolumny zestawień księgowych
Opis: Element szczegółowy zestawienia księgowego (ZestawienieKS). Definiuje kolumnę raportu księgowego z nazwą, zakresem czasowym i wyrażeniem obliczeniowym. Kolumny mogą być generowane dynamicznie oraz chronione przed edycją.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Zestawienie` → `ZestawienieKS`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaEdycji | `bool` | bazodanowe |  | Blokada możliwości edycji kolumny |
| BlokadaNumeru | `bool` | bazodanowe | Blokada Lp. | Blokada możliwości zmiany numeru kolumny |
| BlokadaWyrazenia | `bool` | bazodanowe | Blokada wyrażenia | Blokada możliwości zmiany wyrażenia kolumny |
| ClassName | `string` |  |  |  |
| GenerujWg | `Soneta.Ksiega.KolumnaZestKSGenerujWg` | bazodanowe, enum | Generuj wg |  |
| IsSystem | `bool` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypKolumnyZestawienia` | bazodanowe, enum |  |  |
| Tytul | `string` | bazodanowe | Tytuł |  |
| Wyrazenie | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zakres | `Soneta.Ksiega.DefinicjaZakresu` | bazodanowe |  |  |
| Zakres.LicznikOkresu | `int` | bazodanowe |  |  |
| Zakres.LicznikZakresu | `int` | bazodanowe |  |  |
| Zakres.Okres | `Soneta.Ksiega.PredefinicjaOkresu` | bazodanowe, enum |  |  |
| Zakres.RodzajWzglednego | `Soneta.Ksiega.RodzajZakresuWzględnego` | bazodanowe, enum | Rodzaj zakresu względnego |  |
| Zakres.Zakres | `Soneta.Ksiega.PredefinicjaZakresu` | bazodanowe, enum |  |  |
| Zakres.ZakresReczny | `Soneta.Types.FromTo` | bazodanowe |  |  |
| ZakresWg | `Soneta.Ksiega.KolumnaZestKSZakresWg` | bazodanowe, enum | Zakres wg |  |
| Zestawienie | `Soneta.Ksiega.ZestawienieKS` | bazodanowe, guided-parent |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KolumnaZestKSGenerujWg (`Soneta.Ksiega.KolumnaZestKSGenerujWg`)
- `Null` = 0
- `Firmy` = 1 — Firmy

### KolumnaZestKSZakresWg (`Soneta.Ksiega.KolumnaZestKSZakresWg`)
- `WgKontekstu` = 0

### PredefinicjaOkresu (`Soneta.Ksiega.PredefinicjaOkresu`)
- `Bieżący` = 0 — Bieżący
- `Poprzedni` = 1

### PredefinicjaZakresu (`Soneta.Ksiega.PredefinicjaZakresu`)
- `CałyOkres` = 0 — Cały okres
- `Półrocze` = 1
- `Kwartał` = 2
- `Miesiąc` = 3
- `Ręczny` = 4
- `Bieżący` = 5
- `WzględemBieżącego` = 6
- `OkresObrachunkowy` = 7 — Okres okresu obrach.

### RodzajZakresuWzględnego (`Soneta.Ksiega.RodzajZakresuWzględnego`)
- `MiesiącWstecz` = 0 — Miesiąc wstecz
- `RokWstecz` = 1
- `ZakresWstecz` = 2

### TypKolumnyZestawienia (`Soneta.Ksiega.TypKolumnyZestawienia`)
- `Użytkownika` = 0 — Użytkownika
- `Wartość` = 1

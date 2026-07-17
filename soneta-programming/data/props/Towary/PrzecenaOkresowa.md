# Pola i właściwości klasy biznesowej: `Soneta.Towary.PrzecenaOkresowa`
Nazwa tabeli: `PrzecenyOkres`
Opis: Definicja promocji okresowej (przeceny) obowiązującej w określonym przedziale czasu. Obsługuje promocje ogólne, indywidualne (dla kontrahenta) i grupowe (dla grupy kontrahentów) z konfiguracją priorytetu, kierunku ceny, przypisanego cennika i magazynu oraz opcjami zatwierdzania i rabatowania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `Soneta.Towary.CelPrzecenyOkresowej` | bazodanowe, enum |  |  |
| Cena | `Soneta.Towary.DefinicjaCeny` | bazodanowe | Cena przeceniana |  |
| GrupaKontrahentow | `Soneta.Business.FeatureDefinition` | bazodanowe | Nazwa cechy grupującej | Określa dla jakiej grupy kontrahentów jest promocja grupowa. |
| GrupaKontrahentowWartosc | `string` | bazodanowe | Wartość cechy grupującej | Określa dla jakiej grupy kontrahentów jest promocja grupowa. |
| IsVisibleGrupaKontrahentów | `bool` |  |  |  |
| IsVisibleKontrahent | `bool` |  |  |  |
| Kierunek | `Soneta.Towary.KierunekCeny` | bazodanowe, enum | Kierunek ceny |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  | Określa dla jakiego kontrahenta jest promocja indywidualna. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn, którego dotyczy przecena |  |
| Nazwa | `string` | bazodanowe |  | Nazwa przeceny okresowej (promocji). |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Okres obowiązywania przeceny okresowej. |
| Priorytet | `int` | bazodanowe | Priorytet | Określa priorytet ważności promocji - jedynie w przypadku przeceny dla grup. |
| PrzecenyTowarow | `Soneta.Business.SubTable<Soneta.Towary.PrzecenaOkresowaTowaru>` |  |  |  |
| Rabatowana | `bool` | bazodanowe |  | Wskazuje na to, czy promocja podlega rabatowaniu. |
| SchematyGratisowDlaTowaruWPrzecenie | `Soneta.Business.SubTable<Soneta.Towary.PrzecenaOkresowaTowaruSchematGratisow>` |  |  |  |
| Stan | `Soneta.Towary.StanPrzeceny` | enum |  |  |
| StanWGOkresu | `Soneta.Towary.StanWgOkresu` | enum |  |  |
| Stosowanie | `Soneta.Towary.StosowaniePrzeceny` | bazodanowe, enum | Stosowanie przeceny okresowej | Stosowawnie przeceny okresowej. |
| Typ | `Soneta.Towary.TypPrzecenyOkresowej` | bazodanowe, enum |  | Wskazuje na typ danej promocji okresowej, ważne przy ewentualnym ustalaniu priorytetów w przypadku zachodzących na siebie okresów promocji. |
| Zatwierdzona | `bool` | bazodanowe |  | Wskazuje na to, czy promocja jest zatwierdzona. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CelPrzecenyOkresowej (`Soneta.Towary.CelPrzecenyOkresowej`)
- `PrzecenaCeny` = 0
- `PrzecenaRabatu` = 1

### KierunekCeny (`Soneta.Towary.KierunekCeny`)
- `Brak` = 1
- `Przychod` = 2
- `Rozchod` = 4

### StanPrzeceny (`Soneta.Towary.StanPrzeceny`)
- `Bufor` = 0
- `Zatwierdzona` = 1

### StanWgOkresu (`Soneta.Towary.StanWgOkresu`)
- `None` = 0 — Nieokreślona
- `Past` = 1 — Zakończona
- `Current` = 2 — Aktywna
- `Future` = 3 — Planowana
- `All` = 4 — Razem

### StosowaniePrzeceny (`Soneta.Towary.StosowaniePrzeceny`)
- `JesliCenaNizsza` = 0 — Jeśli cena jest niższa
- `Zawsze` = 1

### TypPrzecenyOkresowej (`Soneta.Towary.TypPrzecenyOkresowej`)
- `Ogólna` = 10 — Ogólna
- `GrupyKontrahnetów` = 20 — Grupy kontrahentów
- `Indywidualna` = 30 — Indywidualna
- `Razem` = 666

# Pola i właściwości klasy biznesowej: `Soneta.Towary.PrzecenaOkresowa`
Nazwa tabeli: `PrzecenyOkres`
Opis: Definicja promocji okresowej (przeceny) obowiązującej w określonym przedziale czasu. Obsługuje promocje ogólne, indywidualne (dla kontrahenta) i grupowe (dla grupy kontrahentów) z konfiguracją priorytetu, kierunku ceny, przypisanego cennika i magazynu oraz opcjami zatwierdzania i rabatowania.
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `Cel` (`Soneta.Towary.CelPrzecenyOkresowej`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `Soneta.Towary.CelPrzecenyOkresowej` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Cena | `Soneta.Towary.DefinicjaCeny` | bazodanowe | Cena przeceniana |  |
| GrupaKontrahentow | `FeatureDefinition` | bazodanowe | Nazwa cechy grupującej | Określa dla jakiej grupy kontrahentów jest promocja grupowa. |
| GrupaKontrahentowWartosc | `string` | bazodanowe | Wartość cechy grupującej | Określa dla jakiej grupy kontrahentów jest promocja grupowa. |
| IsVisibleGrupaKontrahentów | `bool` | tylko-odczyt |  |  |
| IsVisibleKontrahent | `bool` | tylko-odczyt |  |  |
| Kierunek | `Soneta.Towary.KierunekCeny` (enum) | bazodanowe | Kierunek ceny |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  | Określa dla jakiego kontrahenta jest promocja indywidualna. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn, którego dotyczy przecena |  |
| Nazwa | `string` | bazodanowe |  | Nazwa przeceny okresowej (promocji). |
| Okres | `FromTo` | bazodanowe, podlista |  | Okres obowiązywania przeceny okresowej. |
| Priorytet | `int` | bazodanowe | Priorytet | Określa priorytet ważności promocji - jedynie w przypadku przeceny dla grup. |
| PrzecenyTowarow | `SubTable<Soneta.Towary.PrzecenaOkresowaTowaru>` | podlista |  |  |
| Rabatowana | `bool` | bazodanowe |  | Wskazuje na to, czy promocja podlega rabatowaniu. |
| SchematyGratisowDlaTowaruWPrzecenie | `SubTable<Soneta.Towary.PrzecenaOkresowaTowaruSchematGratisow>` | podlista |  |  |
| Stan | `Soneta.Towary.StanPrzeceny` (enum) |  |  |  |
| StanWGOkresu | `Soneta.Towary.StanWgOkresu` (enum) | tylko-odczyt |  |  |
| Stosowanie | `Soneta.Towary.StosowaniePrzeceny` (enum) | bazodanowe | Stosowanie przeceny okresowej | Stosowawnie przeceny okresowej. |
| Typ | `Soneta.Towary.TypPrzecenyOkresowej` (enum) | bazodanowe |  | Wskazuje na typ danej promocji okresowej, ważne przy ewentualnym ustalaniu priorytetów w przypadku zachodzących na siebie okresów promocji. |
| Zatwierdzona | `bool` | bazodanowe |  | Wskazuje na to, czy promocja jest zatwierdzona. |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Cel`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `PrzecenaCeny` | 0 | `Soneta.Towary.PrzecenaOkresowaCeny` | Przecena okresowa |
| `PrzecenaRabatu` | 1 | `Soneta.Towary.PrzecenaOkresowaRabatu` | Rabat okresowy |

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

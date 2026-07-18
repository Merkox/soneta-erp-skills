# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.RodzajSzkol`
Nazwa tabeli: `RodzajeSzkol`
Tytuł: Rodzaje szkoleń
Opis: Kartoteka rodzajów szkoleń oferowanych przez organizację. Definiuje typy kursów z programem, przedmiotami, wyróżnieniami i uprawnieniami, stanowiąc wzorzec do tworzenia grup szkoleniowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 8
- podlisty: 10
- subrowy: 0
- razem: 30

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `MemoText` | bazodanowe, podlista | Cel szkolenia | Cel szkolenia. |
| CelCaption | `string` | tylko-odczyt |  |  |
| Definicja | `Soneta.CzlonkowieSzkolenia.DefRodzajSzkol` | bazodanowe |  | Definicja rodzaju szkolenia. |
| DrukZakresow | `bool` | bazodanowe |  | Drukuj tylko zakresy. |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| FakturowanieMat | `bool` | bazodanowe |  | Fakturowanie materiałów |
| Forma | `Soneta.CzlonkowieSzkolenia.FormaSzkolenia` (enum) | bazodanowe | Forma szkolenie | Forma szkolenie. |
| GrupySzkol | `SubTable<Soneta.CzlonkowieSzkolenia.GrupaSzkol>` | podlista |  |  |
| IsCourseGroup | `bool` | tylko-odczyt |  |  |
| IsModuleCourse | `bool` | tylko-odczyt |  |  |
| IsStandardCourse | `bool` | tylko-odczyt |  |  |
| IsUserGroup | `bool` | tylko-odczyt |  |  |
| Modulowe | `bool` | bazodanowe |  | Określa, czy szkolenie składa sie z modułów. |
| Moduly | `SubTable<Soneta.CzlonkowieSzkolenia.ModulSzkol>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa szkolenia | Nazwa szkolenia. |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| OgraniczPrzedmioty | `bool` | bazodanowe |  | Określa, czy zawęzic listę przedmiotów na grupie szkoleniowej. |
| Opis | `MemoText` | bazodanowe, podlista | Opis szkolenia | Opis szkolenia. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Przedmioty | `SubTable<Soneta.CzlonkowieSzkolenia.RodzajSzkolPrzedmiot>` | podlista |  |  |
| PrzedmiotyBase | `Soneta.CzlonkowieSzkolenia.PrzedmiotSzkol[]` | podlista |  |  |
| ShowDistinctions | `bool` | tylko-odczyt |  |  |
| ShowLicenses | `bool` | tylko-odczyt |  |  |
| Stan | `Soneta.CzlonkowieSzkolenia.StanSzkolenia` (enum) | bazodanowe | Stan szkolenia | Stan szkolenia. |
| Symbol | `string` | bazodanowe | Symbol szkolenia | Symbol szkolenia. |
| Typ | `Soneta.CzlonkowieSzkolenia.RodzajSzkolenia` (enum) | bazodanowe, tylko-odczyt |  |  |
| Unijne | `bool` | bazodanowe |  | Określa szkolenie unijne. |
| Uprawnienia | `SubTable<Soneta.CzlonkowieSzkolenia.RodzajSzkolUprawnienie>` | podlista |  |  |
| Wpisowe | `bool` | bazodanowe |  | Wpisowe na studia |
| Wyroznienia | `SubTable<Soneta.CzlonkowieSzkolenia.RodzajSzkolWyroznienie>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FormaSzkolenia (`Soneta.CzlonkowieSzkolenia.FormaSzkolenia`)
- `Kurs` = 1 — Kurs
- `KursZawodowy` = 2
- `Seminarium` = 3
- `PraktykaZawodowa` = 4
- `Inne` = 5
- `Szkolenie` = 6
- `Razem` = 99

### RodzajSzkolenia (`Soneta.CzlonkowieSzkolenia.RodzajSzkolenia`)
- `Standardowe` = 1
- `Rozszerzone` = 2
- `Wydarzenie` = 3

### StanSzkolenia (`Soneta.CzlonkowieSzkolenia.StanSzkolenia`)
- `WPrzygotowaniu` = 1 — W przygotowaniu
- `Czynny` = 2
- `Zablokowany` = 3
- `Razem` = 99

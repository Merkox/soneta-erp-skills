# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.RodzajSzkol`
Nazwa tabeli: `RodzajeSzkol`
Tytuł: Rodzaje szkoleń
Opis: Kartoteka rodzajów szkoleń oferowanych przez organizację. Definiuje typy kursów z programem, przedmiotami, wyróżnieniami i uprawnieniami, stanowiąc wzorzec do tworzenia grup szkoleniowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `Soneta.Business.MemoText` | bazodanowe | Cel szkolenia | Cel szkolenia. |
| CelCaption | `string` |  |  |  |
| Definicja | `Soneta.CzlonkowieSzkolenia.DefRodzajSzkol` | bazodanowe |  | Definicja rodzaju szkolenia. |
| DrukZakresow | `bool` | bazodanowe |  | Drukuj tylko zakresy. |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| FakturowanieMat | `bool` | bazodanowe |  | Fakturowanie materiałów |
| Forma | `Soneta.CzlonkowieSzkolenia.FormaSzkolenia` | bazodanowe, enum | Forma szkolenie | Forma szkolenie. |
| GrupySzkol | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.GrupaSzkol>` |  |  |  |
| IsCourseGroup | `bool` |  |  |  |
| IsModuleCourse | `bool` |  |  |  |
| IsStandardCourse | `bool` |  |  |  |
| IsUserGroup | `bool` |  |  |  |
| Modulowe | `bool` | bazodanowe |  | Określa, czy szkolenie składa sie z modułów. |
| Moduly | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ModulSzkol>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa szkolenia | Nazwa szkolenia. |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| OgraniczPrzedmioty | `bool` | bazodanowe |  | Określa, czy zawęzic listę przedmiotów na grupie szkoleniowej. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis szkolenia | Opis szkolenia. |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Przedmioty | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.RodzajSzkolPrzedmiot>` |  |  |  |
| PrzedmiotyBase | `Soneta.CzlonkowieSzkolenia.PrzedmiotSzkol[]` |  |  |  |
| ShowDistinctions | `bool` |  |  |  |
| ShowLicenses | `bool` |  |  |  |
| Stan | `Soneta.CzlonkowieSzkolenia.StanSzkolenia` | bazodanowe, enum | Stan szkolenia | Stan szkolenia. |
| Symbol | `string` | bazodanowe | Symbol szkolenia | Symbol szkolenia. |
| Typ | `Soneta.CzlonkowieSzkolenia.RodzajSzkolenia` | bazodanowe, enum |  |  |
| Unijne | `bool` | bazodanowe |  | Określa szkolenie unijne. |
| Uprawnienia | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.RodzajSzkolUprawnienie>` |  |  |  |
| Wpisowe | `bool` | bazodanowe |  | Wpisowe na studia |
| Wyroznienia | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.RodzajSzkolWyroznienie>` |  |  |  |

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

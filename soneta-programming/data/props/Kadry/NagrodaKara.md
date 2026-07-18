# Pola i właściwości klasy biznesowej: `Soneta.Kadry.NagrodaKara`
Nazwa tabeli: `NagrodyKary`
Opis: Nagroda lub kara przyznana pracownikowi. Rejestruje typ (nagroda/kara), definicję, datę przyznania, dane rozliczeniowe (element płacowy, kwotę) oraz datę anulowania w przypadku kary regulaminowej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 5
- podlisty: 4
- subrowy: 1
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DataAnulowania | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kadry.DefinicjaNagrodyKary` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RodzajŹródła | `Soneta.Place.RodzajŹródłaWypłaty` (enum) | tylko-odczyt |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieSwiadczenia` (subrow) | bazodanowe |  |  |
| Rozliczenie.Data | `Date` | bazodanowe |  |  |
| Rozliczenie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Rozliczenie.Kwota | `Currency` | bazodanowe |  |  |
| Rozliczenie.Okres | `FromTo` | bazodanowe, podlista |  |  |
| Rozliczenie.Rozliczone | `bool` | tylko-odczyt |  |  |
| Rozliczenie.WgElement | `Key` | podlista |  |  |
| Typ | `Soneta.Kadry.TypNagrodyKary` (enum) | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypNagrodyKary (`Soneta.Kadry.TypNagrodyKary`)
- `Nagroda` = 1
- `Kara` = 2

### RodzajŹródłaWypłaty (`Soneta.Place.RodzajŹródłaWypłaty`)
- `Etat` = 1
- `Nieobecność` = 2
- `Umowa` = 3
- `Akord` = 4
- `Storno` = 5
- `Dodatek` = 6
- `NadgodzinyI` = 7 — Nadgodziny I
- `NadgodzinyII` = 8 — Nadgodziny II
- `NadgodzinyŚw` = 9
- `Nocne` = 10
- `Kurs` = 11
- `Świadczenie` = 12
- `Nagroda` = 13
- `Kara` = 14
- `FundPożWpisowe` = 15
- `FundPożWycofanie` = 16
- `FundPożSkładka` = 17
- `Pożyczka` = 18
- `PożyczkaSpłata` = 19
- `Zaliczka` = 21
- `SpłataZaliczki` = 22 — Zaliczka zwrot
- `ZajęcieKomornicze` = 23
- `Odchyłki` = 24
- `DodatekAutomatyczny` = 25
- `ZbiegPracyIRodzicielstwa` = 26
- `PIT40` = 27 — PIT-40
- `ZajęcieKomorniczeZwrotNadpłaty` = 28
- `ZajęcieKomorniczeUznanieNadpłaty` = 29
- `ZajęcieKomorniczeRozliczDepozytu` = 30
- `UmowaRozliczenie` = 31
- `WyrównanieDoMinimalnej` = 32
- `ZwrotNadpłatyPPK` = 33 — Zwrot nadpłaty PPK
- `PrzychódOdSkładkiPracodawcyPPK` = 34 — Przychód od składki pracodawcy PPK

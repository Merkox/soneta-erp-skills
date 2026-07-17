# Pola i właściwości klasy biznesowej: `Soneta.Core.AdresExt`
Nazwa tabeli: `Adresy`
Tytuł: Adres
Opis: Element szczegółowy hosta adresowego (IAdresHost). Przechowuje adres danego typu (np. siedziby, korespondencyjny, dostawy) wraz z danymi identyfikacyjnymi (GLN) oraz flagą blokady.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IAdresHost`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | bazodanowe |  |  |
| Adres.AdresExt | `Soneta.Core.AdresExt` |  |  |  |
| Adres.AdresRozszerzony | `Soneta.Core.AdresRozszerzony` |  |  |  |
| Adres.Faks | `string` | bazodanowe |  | Numer faksu |
| Adres.GLN | `string` |  |  |  |
| Adres.Gmina | `string` | bazodanowe |  | Gmina |
| Adres.IsRozszerzonyAdres | `bool` |  |  |  |
| Adres.KodKraju | `string` | bazodanowe |  | Kod kraju |
| Adres.KodPocztowy | `int` | bazodanowe |  | Kod pocztowy |
| Adres.KodPocztowyS | `string` |  |  |  |
| Adres.Kraj | `string` | bazodanowe |  | Kraj |
| Adres.Linia1 | `string` |  |  |  |
| Adres.Linia2 | `string` |  |  |  |
| Adres.Miejscowosc | `string` | bazodanowe | Miejscowość | Miejscowość |
| Adres.NietypowaLokalizacja | `string` | bazodanowe |  | Nietypowe miejsce lokalizacji |
| Adres.NrDomu | `string` | bazodanowe |  | Numer domu (bloku) |
| Adres.NrLokalu | `string` | bazodanowe |  | Numer lokalu w domu (bloku) |
| Adres.Pełny | `string` |  |  |  |
| Adres.Poczta | `string` | bazodanowe |  | Poczta |
| Adres.Powiat | `string` | bazodanowe |  | Powiat |
| Adres.Telefon | `string` | bazodanowe |  | Numer telefonu |
| Adres.Ulica | `string` | bazodanowe |  | Nazwa ulicy (alei, osiedla) |
| Adres.Wojewodztwo | `Soneta.Core.Wojewodztwa` | bazodanowe, enum |  | Województwo |
| Adres.ZagranicznyKodPocztowy | `string` | bazodanowe |  | Zagraniczny kod pocztowy |
| Blokada | `bool` | bazodanowe |  |  |
| Host | `Soneta.Core.IAdresHost` | bazodanowe, guided-parent, iface-ref |  |  |
| IdentyfikacjaAdresu | `Soneta.Core.IdentyfikacjaAdresu` | bazodanowe |  |  |
| IdentyfikacjaAdresu.GLN | `string` | bazodanowe | GLN (ILN) | Globalny numer lakalizacji. |
| Info | `string` |  |  |  |
| Kod | `string` |  |  |  |
| RcpWorkMode | `Soneta.Core.Enums.RcpWorkMode` | enum |  |  |
| Typ | `Soneta.Core.RodzajAdresu` | bazodanowe, enum |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IAdresHost` | `Bank`, `CzlonekRodziny`, `InstytucjaFinansowaPPK`, `JednostkaSprawozdaniaKS`, `KontaktOsoba`, `Kontrahent`, `Lokalizacja`, `OddzialFirmy`, `OddziałZUS`, `OfertaSzkolenia`, `PracHistoria`, `Pracownik`, `PrzelewBase`, `RachunekBankowyPodmiotu`, `RealizacjaSzkolenia`, `UrzadCelny`, `UrzadSkarbowy`, `WizytowkaFirmy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RcpWorkMode (`Soneta.Core.Enums.RcpWorkMode`)
- `Stationary` = 0 — Stacjonarna
- `Remote` = 1 — Zdalna
- `All` = 2 — Wszystkie

### RodzajAdresu (`Soneta.Core.RodzajAdresu`)
- `Główny` = 1
- `Korespondencyjny` = 2
- `Zameldowania` = 4
- `Zamieszkania` = 5
- `PełnomocnikaPFRON` = 6 — Pełnomocnika PFRON
- `ZleceniodawcaPrzelewu` = 10
- `OdbiorcaPrzelewu` = 11
- `Inny` = 1000

### Wojewodztwa (`Soneta.Core.Wojewodztwa`)
- `nieokreślone` = 0
- `dolnośląskie` = 1
- `kujawsko_pomorskie` = 2 — kujawsko-pomorskie
- `lubelskie` = 3
- `lubuskie` = 4
- `łódzkie` = 5
- `małopolskie` = 6
- `mazowieckie` = 7
- `opolskie` = 8
- `podkarpackie` = 9
- `podlaskie` = 10
- `pomorskie` = 11
- `śląskie` = 12
- `świętokrzyskie` = 13
- `warmińsko_mazurskie` = 14 — warmińsko-mazurskie
- `wielkopolskie` = 15
- `zachodniopomorskie` = 16

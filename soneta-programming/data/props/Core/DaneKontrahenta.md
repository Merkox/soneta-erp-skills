# Pola i właściwości klasy biznesowej: `Soneta.Core.DaneKontrahenta`
Nazwa tabeli: `DaneKontrahentow`
Opis: Element szczegółowy hosta danych kontrahenta (IDaneKontrahentaHost). Przechowuje dane identyfikacyjne kontrahenta: nazwę, NIP, EU VAT, adres, rodzaj i status podmiotu oraz informację o statusie podatnika VAT.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IDaneKontrahentaHost`
Implementuje interfejsy: `IDaneKontaktoweHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` (subrow) | bazodanowe |  |  |
| Adres.AdresExt | `Soneta.Core.AdresExt` | tylko-odczyt |  |  |
| Adres.AdresRozszerzony | `Soneta.Core.AdresRozszerzony` | tylko-odczyt |  |  |
| Adres.Faks | `string` | bazodanowe |  | Numer faksu |
| Adres.GLN | `string` |  |  |  |
| Adres.Gmina | `string` | bazodanowe |  | Gmina |
| Adres.IsRozszerzonyAdres | `bool` |  |  |  |
| Adres.KodKraju | `string` | bazodanowe |  | Kod kraju |
| Adres.KodPocztowy | `int` | bazodanowe |  | Kod pocztowy |
| Adres.KodPocztowyS | `string` |  |  |  |
| Adres.Kraj | `string` | bazodanowe |  | Kraj |
| Adres.Linia1 | `string` | tylko-odczyt |  |  |
| Adres.Linia2 | `string` | tylko-odczyt |  |  |
| Adres.Miejscowosc | `string` | bazodanowe | Miejscowość | Miejscowość |
| Adres.NietypowaLokalizacja | `string` | bazodanowe |  | Nietypowe miejsce lokalizacji |
| Adres.NrDomu | `string` | bazodanowe |  | Numer domu (bloku) |
| Adres.NrLokalu | `string` | bazodanowe |  | Numer lokalu w domu (bloku) |
| Adres.Pełny | `string` |  |  |  |
| Adres.Poczta | `string` | bazodanowe |  | Poczta |
| Adres.Powiat | `string` | bazodanowe |  | Powiat |
| Adres.Telefon | `string` | bazodanowe |  | Numer telefonu |
| Adres.Ulica | `string` | bazodanowe |  | Nazwa ulicy (alei, osiedla) |
| Adres.Wojewodztwo | `Soneta.Core.Wojewodztwa` (enum) | bazodanowe |  | Województwo |
| Adres.ZagranicznyKodPocztowy | `string` | bazodanowe |  | Zagraniczny kod pocztowy |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| Host | `Soneta.Core.IDaneKontrahentaHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| KodKraju | `string` | tylko-odczyt |  | Kod kraju kontrahenta wyliczony na podstawie NIP/EuVAT. |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| PodatnikVAT | `bool` | bazodanowe | Podatnik VAT |  |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` (enum) | bazodanowe |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` (enum) | bazodanowe |  |  |
| Typ | `int` | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IDaneKontrahentaHost` | `BasicDocument`, `DokEwidencji`, `DokumentHandlowy`, `KSeFPodmiot3`, `Zaplata` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajPodmiotu (`Soneta.Core.RodzajPodmiotu`)
- `Krajowy` = 0
- `Eksportowy` = 1
- `EksportowyPodróżny` = 2
- `Unijny` = 3
- `UnijnyTrójstronny` = 4
- `BezVAT` = 5 — Bez VAT

### StatusPodmiotu (`Soneta.Core.StatusPodmiotu`)
- `PodmiotGospodarczy` = 0
- `Finalny` = 1

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

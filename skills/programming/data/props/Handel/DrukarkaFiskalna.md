# Pola i właściwości klasy biznesowej: `Soneta.Handel.DrukarkaFiskalna`
Nazwa tabeli: `DrukarkiFiskalne`
Tytuł: Lista drukarek fiskalnych
Opis: Konfiguracja drukarki fiskalnej: nazwa, port, symbol kasy, ustawienia drukowania (stawki VAT, kopie, LCD, kody QR). Definiuje integracje z platformą e-paragonów.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `string` | bazodanowe |  |  |
| AdresIP | `string` |  |  |  |
| AdresPort | `int` |  |  |  |
| CechaNazwyTowaru | `string` | bazodanowe |  |  |
| ComTimeout | `int` |  |  |  |
| DodawajStawkeVATDoNazwy | `bool` | bazodanowe |  |  |
| Domyslna | `bool` | bazodanowe |  |  |
| Drukarka | `string` | bazodanowe |  |  |
| DrukujJednostkiNaPozycji | `bool` | bazodanowe |  |  |
| DrukujNipNabywcy | `bool` | bazodanowe |  | Drukowanie NIP-u nabywcy na paragonie |
| DrukujNrBarcode | `bool` | bazodanowe |  | Drukowanie numeru systemowego kodem kreskowym |
| DrukujNumer | `bool` | bazodanowe |  |  |
| DrukujQR | `bool` | bazodanowe |  | Drukowanie kodu QR |
| DrukujRabatNaPozycji | `bool` | bazodanowe |  |  |
| DrukujSposobZaplaty | `bool` | bazodanowe |  |  |
| EParagonyPlClientId | `string` | bazodanowe |  |  |
| EParagonyPlClientSecret | `string` | bazodanowe |  |  |
| EParagonyPlPosId | `string` | bazodanowe |  |  |
| EParagonyWebhookSecret | `string` | bazodanowe |  |  |
| ElzabTD | `Soneta.Fiskal.ElzabTekstDodatkowy` (enum) | bazodanowe |  |  |
| FiskalizujNPJakoZW | `bool` | bazodanowe |  |  |
| IloscZnakowNazwy | `int` | bazodanowe |  |  |
| Logowanie | `bool` | bazodanowe |  |  |
| MapaStawekVat | `System.Tuple<int, char, string, decimal>[]` | podlista |  |  |
| MapowanieStawekVat | `Soneta.Handel.MapowanieStawekVat` (enum) | bazodanowe |  | Rodzaj mapowania stawek Vat. |
| MiejsceFiskalizacjiParagonow | `Soneta.Fiskal.MiejsceFiskalizacjiParagonow` (enum) | bazodanowe | Miejsce fiskalizacji paragonów | Miejsce fiskalizacji paragonów |
| MinDlugoscIlosci | `int` | bazodanowe |  |  |
| MinDlugoscNazwy | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaKolejki | `string` | bazodanowe |  |  |
| NazwaKolejkiDrukarki | `string` |  |  |  |
| NumerEwidencyjny | `string` | bazodanowe |  |  |
| NumerKlienta | `string` | bazodanowe |  |  |
| NumerRejestracyjny | `string` | bazodanowe |  |  |
| NumerZamowienia | `string` | bazodanowe |  |  |
| OsobaZamawiajaca | `string` | bazodanowe |  |  |
| PlatformaEParagonow | `Soneta.Fiskal.PlatformaEParagonow` (enum) | bazodanowe | Platforma e-paragonów | Platforma e-paragonów |
| Port | `string` | bazodanowe |  |  |
| PrzesylajNaLCD | `bool` | bazodanowe |  |  |
| QRCode | `string` | bazodanowe |  | QR code |
| ReczneMapowanieStawekVat | `bool` | tylko-odczyt |  |  |
| RodzajKontaEParagonyPl | `Soneta.Fiskal.RodzajKontaEParagonyPl` (enum) | bazodanowe | Rodzaj konta eparagony.pl | Rodzaj konta eparagony.pl |
| SposobDostawy | `string` | bazodanowe |  |  |
| SprzedazNiefiskalna | `bool` | bazodanowe |  |  |
| Stanowiska | `SubTable<Soneta.Handel.DrukarkaFiskalnaStanowisko>` | podlista |  |  |
| StawkaA | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka przypisana do rejestru A. |
| StawkaB | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka przypisana do rejestru B. |
| StawkaC | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka przypisana do rejestru C. |
| StawkaD | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka przypisana do rejestru D. |
| StawkaE | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka przypisana do rejestru E. |
| StawkaF | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka przypisana do rejestru F. |
| StawkaG | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka przypisana do rejestru G. |
| SymbolKasy | `string` | bazodanowe |  |  |
| TSFP | `bool` | bazodanowe |  |  |
| TcpTimeout | `int` |  |  |  |
| TekstReklamowy | `string` | bazodanowe |  |  |
| TekstReklamowyCecha | `string` | bazodanowe |  |  |
| TimeoutCOM | `int` | bazodanowe |  |  |
| TimeoutTCP | `int` | bazodanowe |  |  |
| TrybSerwera | `bool` | bazodanowe |  |  |
| USB | `bool` | bazodanowe |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| WarunkiDostawy | `string` | bazodanowe |  |  |
| ZaawansowaneZatwierdzanie | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ElzabTekstDodatkowy (`Soneta.Fiskal.ElzabTekstDodatkowy`)
- `ZAPŁACONO` = 0 — ZAPŁACONO
- `RESZTA` = 1 — RESZTA
- `SPOSÓB_ZAPŁATY` = 2 — SPOSÓB ZAPŁATY:
- `ZAPRASZAMY` = 3 — ZAPRASZAMY
- `OTWARTE` = 4 — OTWARTE
- `OBSŁUGUJĄCY` = 5 — OBSŁUGUJĄCY
- `KOMPUTEROWY` = 6 — KOMPUTEROWY
- `VOUCHER` = 7 — VOUCHER
- `KAUCJA` = 8 — KAUCJA
- `ZWROT_KAUCJI` = 9 — ZWROT KAUCJI
- `GOTÓWKA` = 10 — GOTÓWKA
- `BEZ_NARZUTU` = 11 — BEZ NARZUTU
- `NUMER` = 12 — NUMER
- `STAN_LICZNIKA` = 13 — STAN LICZNIKA
- `KLIENT` = 14 — KLIENT
- `KARTA_KREDYTOWA` = 15 — KARTA KREDYTOWA

### MiejsceFiskalizacjiParagonow (`Soneta.Fiskal.MiejsceFiskalizacjiParagonow`)
- `Lokalnie` = 0
- `EParagonyPl` = 1 — eparagony.pl

### PlatformaEParagonow (`Soneta.Fiskal.PlatformaEParagonow`)
- `Brak` = 0
- `HUBParagonowyMF` = 1 — HUB paragonowy MF
- `EParagonyPl` = 2 — eparagony.pl

### RodzajKontaEParagonyPl (`Soneta.Fiskal.RodzajKontaEParagonyPl`)
- `Produkcyjne` = 0
- `Testowe` = 1

### MapowanieStawekVat (`Soneta.Handel.MapowanieStawekVat`)
- `Automatyczne` = 0
- `Reczne` = 1 — Ręczne

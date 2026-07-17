# Pola i właściwości klasy biznesowej: `Soneta.Place.PlanowanyElementWypłaty`
Nazwa tabeli: `PlanElementyWyp`
Tytuł: Planowane elementy
Opis: Element szczegółowy planowanej wypłaty (PlanowanaWypłata). Przechowuje naliczoną wartość rezerwy dla konkretnego składnika wynagrodzenia z rozbiciem na brutto, narzuty i koszty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wyplata` → `PlanowanaWypłata`

- pola bazodanowe: 105
- pola kalkulowane (z klas biznesowych): 96

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BazaZrodla | `Soneta.Place.IBazaZrodlaWyplaty` | iface-ref |  |  |
| BazaZrodlaId | `int` | bazodanowe |  |  |
| BazaZrodlaTbl | `string` | bazodanowe |  |  |
| Brutto | `decimal` | bazodanowe |  |  |
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Dni | `int` | bazodanowe |  |  |
| DoOpodatkowania | `decimal` |  |  |  |
| Koszty | `decimal` | bazodanowe | Razem koszty |  |
| Narzuty | `decimal` | bazodanowe |  |  |
| Netto | `decimal` |  |  |  |
| NiePodlegaOpodatkowaniu | `decimal` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Okres za jaki naliczono rezerwę |
| Podatki | `Soneta.Place.Podatki` | bazodanowe |  |  |
| Podatki.Brutto50 | `decimal` | bazodanowe |  |  |
| Podatki.BudzetTyUb | `Soneta.Kadry.TytulUbezpieczenia` | bazodanowe |  |  |
| Podatki.BudżetZUS | `decimal` |  |  |  |
| Podatki.Chorobowa | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.ChorobowaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.Emerytalna | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.Emerytalna.Firma | `decimal` | bazodanowe |  |  |
| Podatki.Emerytalna.JestMinus | `bool` |  |  | Informuje, czy składka pracownika lub firmy jest ujemna. |
| Podatki.Emerytalna.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.Emerytalna.Prac | `decimal` | bazodanowe |  |  |
| Podatki.Emerytalna.Składka | `decimal` |  |  |  |
| Podatki.EmerytalnaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.EmerytalnaBudzet.JestMinus | `bool` |  |  | Informuje, czy składka jest ujemna. |
| Podatki.EmerytalnaBudzet.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.EmerytalnaBudzet.Skladka | `decimal` | bazodanowe |  |  |
| Podatki.FEP | `Soneta.Place.SkladkaZUSFirma` | bazodanowe |  |  |
| Podatki.FGSP | `Soneta.Place.SkladkaZUSFirma` | bazodanowe |  |  |
| Podatki.FP | `Soneta.Place.SkladkaZUSFirma` | bazodanowe |  |  |
| Podatki.FP.JestMinus | `bool` |  |  | Informuje, czy składka jest ujemna. |
| Podatki.FP.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.FP.Skladka | `decimal` | bazodanowe |  |  |
| Podatki.FirmaZUS | `decimal` |  |  |  |
| Podatki.JestMinus | `bool` |  |  | Informuje, że są podatki lub składki o wartości ujemnej. |
| Podatki.Korekta | `bool` | bazodanowe |  |  |
| Podatki.Koszty | `decimal` | bazodanowe |  |  |
| Podatki.Koszty50 | `decimal` | bazodanowe |  |  |
| Podatki.KosztyPIT | `decimal` |  |  |  |
| Podatki.KosztyRazem | `decimal` |  |  |  |
| Podatki.KosztyZUS | `decimal` |  |  |  |
| Podatki.KosztyZUS26 | `decimal` |  |  |  |
| Podatki.KosztyZUSNieodlicz | `decimal` | bazodanowe |  | Suma składek ZUS niepomniejszających podstawy opodatkowania |
| Podatki.KosztyZUSPomn | `decimal` | bazodanowe |  |  |
| Podatki.KosztyZUSPomnKosztow | `decimal` |  |  |  |
| Podatki.KosztyZdrow26 | `decimal` |  |  |  |
| Podatki.KosztyZdrowPomn | `decimal` |  |  |  |
| Podatki.NalFIS | `decimal` | bazodanowe |  |  |
| Podatki.Narzuty | `decimal` |  |  |  |
| Podatki.OdliczoneZdrowotne | `decimal` |  |  |  |
| Podatki.OrgTyUb | `Soneta.Kadry.TytulUbezpieczenia` | bazodanowe |  |  |
| Podatki.PPK | `Soneta.Place.SkładkaPPK` | bazodanowe |  |  |
| Podatki.PPK.DodPracodawcy | `decimal` | bazodanowe |  |  |
| Podatki.PPK.DodPracownika | `decimal` | bazodanowe |  |  |
| Podatki.PPK.JestMinus | `bool` |  |  | Informuje, czy składka pracownika lub firmy jest ujemna. |
| Podatki.PPK.PodstPracodawcy | `decimal` | bazodanowe |  |  |
| Podatki.PPK.PodstPracownika | `decimal` | bazodanowe |  |  |
| Podatki.PPK.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.PPK.Pracodawcy | `decimal` |  |  |  |
| Podatki.PPK.PracodawcyDoPodatku | `decimal` | bazodanowe |  |  |
| Podatki.PPK.Pracownika | `decimal` |  |  |  |
| Podatki.PPK.Składka | `decimal` |  |  |  |
| Podatki.PakietMobilności | `bool` |  |  |  |
| Podatki.PakietMobilnościPomniejszenieFIS | `decimal` |  |  |  |
| Podatki.PakietMobilnościPomniejszenieZUS | `decimal` |  |  |  |
| Podatki.PakietMobilnościWartośćDiet | `decimal` |  |  |  |
| Podatki.PodstawaFIS | `decimal` | bazodanowe |  |  |
| Podatki.PodstawaZUS | `decimal` | bazodanowe |  |  |
| Podatki.PomnKosztyZUS | `decimal` |  |  |  |
| Podatki.PomnKosztyZUSPomn | `decimal` |  |  |  |
| Podatki.PomniejszenieFIS | `decimal` | bazodanowe |  |  |
| Podatki.PomniejszeniePodstawyFIS | `bool` |  |  |  |
| Podatki.PomniejszenieZUS | `decimal` | bazodanowe |  |  |
| Podatki.ProcentFIS | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki.Przychod26 | `decimal` | bazodanowe |  |  |
| Podatki.Przychod26BezPPK | `decimal` |  |  |  |
| Podatki.Przychod26Ulgi | `decimal` |  |  |  |
| Podatki.Przychod50 | `decimal` | bazodanowe |  |  |
| Podatki.Rentowa | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.RentowaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.TyUb | `Soneta.Kadry.TytulUbezpieczenia` | bazodanowe |  |  |
| Podatki.TypKosztowUzyskaniaPrzychodu | `Soneta.Place.TypKosztowUzyskaniaPrzychodu` | enum |  |  |
| Podatki.TypPomniejszeniaFIS | `Soneta.Place.TypPomniejszeniaFIS` | enum |  | Sposób pomniejszania zaliczki podatku od zdrowotnego z uzwględnieniem ryczałtu. |
| Podatki.UjemneKwoty | `string` |  |  |  |
| Podatki.Ulga | `decimal` | bazodanowe |  |  |
| Podatki.UlgaDuzaRodzina | `decimal` | bazodanowe |  |  |
| Podatki.UlgaEmeryt | `decimal` | bazodanowe |  |  |
| Podatki.UlgaKlasaSrednia | `decimal` | bazodanowe |  |  |
| Podatki.UlgaZagranica | `decimal` | bazodanowe |  |  |
| Podatki.VAT | `Soneta.Place.PodatekVAT` | bazodanowe |  |  |
| Podatki.VAT.DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT opisująca rodzaj stawki 22%, 7%, itp |
| Podatki.VAT.Podatek | `decimal` | bazodanowe |  |  |
| Podatki.VAT.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.VAT.Stawka | `Soneta.Core.StawkaVat` | bazodanowe |  | Typ stawki VAT |
| Podatki.VAT.Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Podatki.VAT.Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Podatki.VAT.Stawka.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki.VAT.Stawka.Status | `Soneta.Core.StatusStawkiVat` | bazodanowe, enum |  |  |
| Podatki.VAT.Stawka.WgKraj | `Soneta.Business.Key` |  |  |  |
| Podatki.VAT.Stawka.WymagaSWW | `bool` |  |  |  |
| Podatki.VAT.Stawka.Zrodlowa | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki.VAT.WgDefinicjaStawki | `Soneta.Business.Key` |  |  |  |
| Podatki.WyliczonyPrzychód50 | `decimal` |  |  |  |
| Podatki.Wypadkowa | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.WypadkowaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.ZUS | `decimal` |  |  |  |
| Podatki.ZalFIS | `decimal` | bazodanowe |  |  |
| Podatki.ZalFISDoplata | `decimal` | bazodanowe |  |  |
| Podatki.ZalFISKorekta | `decimal` | bazodanowe |  |  |
| Podatki.ZalFISPL | `decimal` | bazodanowe |  |  |
| Podatki.Zaniechanie | `decimal` | bazodanowe |  |  |
| Podatki.Zdrowotna | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.ZdrowotnaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.ZdrowotneDoOdliczenia | `decimal` | bazodanowe |  | Składka na NFZ do odliczenia od zaliczki podatku |
| Podatki.ZdrowotneDoOdliczenia26 | `decimal` | bazodanowe |  | Składka 26 latka na NFZ do odliczenia od zaliczki podatku |
| Podatki.ZdrowotneFaktycznieOdliczone | `decimal` |  | Zdrowotne odliczone | Składka na NFZ faktycznie odliczenia od zaliczki podatku |
| Podatki.ZdrowotneNieodliczane | `decimal` |  |  | Składka na NFZ nieodliczana od zaliczki podatku |
| Podatki2021 | `Soneta.Place.Podatki2021` | bazodanowe |  |  |
| Podatki2021.Brutto50 | `decimal` | bazodanowe |  |  |
| Podatki2021.BudzetTyUb | `Soneta.Kadry.TytulUbezpieczenia` |  |  |  |
| Podatki2021.BudżetZUS | `decimal` |  |  |  |
| Podatki2021.Chorobowa | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.ChorobowaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.Emerytalna | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.EmerytalnaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.FEP | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.FGSP | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.FP | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.FirmaZUS | `decimal` |  |  |  |
| Podatki2021.Koszty | `decimal` | bazodanowe |  |  |
| Podatki2021.Koszty50 | `decimal` | bazodanowe |  |  |
| Podatki2021.KosztyPIT | `decimal` |  |  |  |
| Podatki2021.KosztyRazem | `decimal` |  |  |  |
| Podatki2021.KosztyZUS | `decimal` | bazodanowe |  |  |
| Podatki2021.KosztyZUS26 | `decimal` |  |  |  |
| Podatki2021.KosztyZUSNieodlicz | `decimal` | bazodanowe |  |  |
| Podatki2021.KosztyZUSPomn | `decimal` | bazodanowe |  |  |
| Podatki2021.KosztyZUSPomnKosztow | `decimal` |  |  |  |
| Podatki2021.KosztyZdrow26 | `decimal` |  |  |  |
| Podatki2021.NalFIS | `decimal` | bazodanowe |  |  |
| Podatki2021.Narzuty | `decimal` |  |  |  |
| Podatki2021.OdliczoneZdrowotne | `decimal` |  |  |  |
| Podatki2021.OrgTyUb | `Soneta.Kadry.TytulUbezpieczenia` |  |  |  |
| Podatki2021.PPK | `Soneta.Place.ISkładkaPPK` |  |  |  |
| Podatki2021.PakietMobilnościPomniejszenieFIS | `decimal` |  |  |  |
| Podatki2021.PakietMobilnościPomniejszenieZUS | `decimal` |  |  |  |
| Podatki2021.PakietMobilnościWartośćDiet | `decimal` |  |  |  |
| Podatki2021.PodstawaFIS | `decimal` | bazodanowe |  |  |
| Podatki2021.PodstawaZUS | `decimal` |  |  |  |
| Podatki2021.PomnKosztyZUS | `decimal` |  |  |  |
| Podatki2021.PomnKosztyZUSPomn | `decimal` |  |  |  |
| Podatki2021.PomniejszenieFIS | `decimal` | bazodanowe |  |  |
| Podatki2021.PomniejszeniePodstawyFIS | `bool` |  |  |  |
| Podatki2021.PomniejszenieZUS | `decimal` |  |  |  |
| Podatki2021.ProcentFIS | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki2021.Przychod26 | `decimal` | bazodanowe |  |  |
| Podatki2021.Przychod26BezPPK | `decimal` |  |  |  |
| Podatki2021.Przychod26Ulgi | `decimal` |  |  |  |
| Podatki2021.Przychod50 | `decimal` | bazodanowe |  |  |
| Podatki2021.Puste | `bool` |  |  |  |
| Podatki2021.Rentowa | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.RentowaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.TyUb | `Soneta.Kadry.TytulUbezpieczenia` |  |  |  |
| Podatki2021.TypKosztowUzyskaniaPrzychodu | `Soneta.Place.TypKosztowUzyskaniaPrzychodu` | enum |  |  |
| Podatki2021.TypPomniejszeniaFIS | `Soneta.Place.TypPomniejszeniaFIS` | enum |  | Sposób pomniejszania zaliczki podatku od zdrowotnego z uzwględnieniem ryczałtu. |
| Podatki2021.Ulga | `decimal` | bazodanowe |  |  |
| Podatki2021.UlgaDuzaRodzina | `decimal` |  |  |  |
| Podatki2021.UlgaEmeryt | `decimal` |  |  |  |
| Podatki2021.UlgaKlasaSrednia | `decimal` |  |  |  |
| Podatki2021.UlgaZagranica | `decimal` |  |  |  |
| Podatki2021.VAT | `Soneta.Place.PodatekVAT` |  |  |  |
| Podatki2021.WyliczonyPrzychód50 | `decimal` |  |  |  |
| Podatki2021.Wypadkowa | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.WypadkowaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.ZUS | `decimal` |  |  |  |
| Podatki2021.ZalFIS | `decimal` | bazodanowe |  |  |
| Podatki2021.ZalFISDoplata | `decimal` |  |  |  |
| Podatki2021.ZalFISKorekta | `decimal` |  |  |  |
| Podatki2021.ZalFISPL | `decimal` |  |  |  |
| Podatki2021.Zaniechanie | `decimal` | bazodanowe |  |  |
| Podatki2021.Zdrowotna | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.ZdrowotnaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.ZdrowotneDoOdliczenia | `decimal` | bazodanowe |  |  |
| Podatki2021.ZdrowotneDoOdliczenia26 | `decimal` | bazodanowe |  |  |
| Podatki2021.ZdrowotneFaktycznieOdliczone | `decimal` |  | Zdrowotne odliczone | Składka na NFZ faktycznie odliczenia od zaliczki podatku |
| Podatki2021.ZdrowotneNieodliczane | `decimal` |  |  | Składka na NFZ nieodliczana od zaliczki podatku |
| Podstawa1 | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Podstawa2 | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Podstawa3 | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Podstawa4 | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Podstawa5 | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| RodzajSkladki | `Soneta.Place.RodzajSkladki` | bazodanowe, enum | Rodzaj składki |  |
| Wartosc | `decimal` | bazodanowe | Wartość |  |
| Wyplata | `Soneta.Place.PlanowanaWypłata` | bazodanowe, guided-parent |  |  |
| ZapisObliczen | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zatwierdzony | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| BazaZrodla | `IBazaZrodlaWyplaty` | `Akord`, `Deklaracja`, `Dodatek`, `DodatekAutomatyczny`, `FundPozyczkowy`, `KorektaZajęciaKomorniczego`, `NagrodaKara`, `Nieobecnosc`, `Pozyczka`, `Pracownik`, `RataPozyczki`, `SwiadczSocjalne`, `Umowa`, `WniosekOSzkolenie`, `ZajęcieKomornicze`, `Zaliczka`, `ZbiegPracyIRodzicielstwa`, `ZmianaWkładuFunduszuPozyczkowego` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusStawkiVat (`Soneta.Core.StatusStawkiVat`)
- `Opodatkowana` = 0 — Opodatkowana
- `Zaniżona` = 1
- `Zwolniona` = 2
- `NiePodlega` = 3
- `Brak` = 4

### RodzajSkladki (`Soneta.Place.RodzajSkladki`)
- `Emerytalna` = 1 — Emerytalna
- `Rentowa` = 2
- `Chorobowa` = 4
- `Wypadkowa` = 8
- `Zdrowotna` = 16
- `FP` = 32
- `FGŚP` = 64
- `FEP` = 128
- `EmerytalnaBudzet` = 256
- `RentowaBudzet` = 512
- `ZdrowotnaBudzet` = 1024
- `ChorobowaBudzet` = 4096
- `WypadkowaBudzet` = 8192
- `PPK` = 2048
- `Waloryzacja` = 32768
- `Podatek` = 65536
- `Pit26` = 131072
- `PakietMobilności` = 262144
- `PomniejszenieFIS` = 524288
- `UlgaDuzaRodzina` = 1048576
- `UlgaEmeryt` = 2097152
- `UlgaZagranica` = 4194304
- `Podatki2021` = 8388608
- `SkładkiZUS` = 31
- `SkładkiBudżet` = 14080
- `Składki` = 14111
- `Narzuty` = 2272
- `Pit26UlgiBezFIS` = 7471104
- `Pit26Ulgi` = 7995392
- `Flagi` = 7569408
- `FlagiZUS` = 14335

### TypKosztowUzyskaniaPrzychodu (`Soneta.Place.TypKosztowUzyskaniaPrzychodu`)
- `NieNaliczać` = 0
- `ZeStosunkuPracy` = 1
- `ZeStosunkuPracy50` = 2
- `Procentowe` = 3
- `WWysokościStosunkuPracy` = 4 — W wysokości stosunku pracy
- `Procentowe50` = 5
- `ProcentoweWarunkowo` = 6
- `WWysokościStosunkuPracyWarunkowo` = 7 — W wysokości stosunku pracy warunkowo
- `KosztyAutorskie50` = 8

### TypPomniejszeniaFIS (`Soneta.Place.TypPomniejszeniaFIS`)
- `NiePomniejsza` = 0
- `Pomniejsza` = 1
- `PomniejszaDoFIS` = 2 — Pomniejsza do FIS
- `PomniejszaWarunkowo` = 3 — Pomniejsza warunkowo do FIS
- `PomniejszaWarunkowoBezFis` = 4 — Pomniejsza warunkowo

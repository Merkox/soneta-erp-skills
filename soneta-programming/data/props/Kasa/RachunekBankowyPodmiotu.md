# Pola i właściwości klasy biznesowej: `Soneta.Kasa.RachunekBankowyPodmiotu`
Nazwa tabeli: `RachBankPodmiot`
Tytuł: Rachunki bankowe
Opis: Rachunek bankowy przypisany do podmiotu kasowego (kontrahenta, pracownika itp.). Przechowuje dane rachunku (numer IBAN, bank, SWIFT), walutę, priorytet oraz status weryfikacji w Wykazie podatników VAT (Biała Lista). Służy do generowania przelewów i identyfikacji rachunków przy importach bankowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 10
- podlisty: 4
- subrowy: 2
- razem: 37

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DataSprawdzeniaBL | `Date` | bazodanowe | Data sprawdzenia w Wykazie |  |
| Domyslne | `bool` |  |  |  |
| Ewidencja | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| IsAdres | `bool` |  |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Nazwa1 | `string` | bazodanowe |  | Pierwsza linia informacji do umieszczenia na przelewie |
| Nazwa2 | `string` | bazodanowe |  | Druga linia informacji do umieszczenia na przelewie |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Platnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Procent | `Percent` | bazodanowe |  |  |
| Przelewy | `SubTable<Soneta.Kasa.PrzelewBase>` | podlista |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowy` (subrow) | bazodanowe |  |  |
| Rachunek.Bank | `Soneta.Kasa.IBank` | bazodanowe |  |  |
| Rachunek.Numer | `Soneta.Kasa.NumerRachunku` (subrow) | bazodanowe |  |  |
| Rachunek.Numer.CS | `string` | bazodanowe |  |  |
| Rachunek.Numer.IBAN | `bool` | tylko-odczyt |  |  |
| Rachunek.Numer.IsEmpty | `bool` | tylko-odczyt |  |  |
| Rachunek.Numer.Kierunek | `string` | bazodanowe |  |  |
| Rachunek.Numer.Kraj | `string` | bazodanowe |  |  |
| Rachunek.Numer.NRB | `bool` | tylko-odczyt |  |  |
| Rachunek.Numer.Numer | `string` | bazodanowe |  |  |
| Rachunek.Numer.NumerF | `string` | tylko-odczyt |  |  |
| Rachunek.Numer.PKO | `bool` | tylko-odczyt |  |  |
| Rachunek.Numer.Pełny | `string` |  | Numer rachunku |  |
| Rachunek.Numer.PełnyNRB | `string` |  | Numer rachunku |  |
| Rachunek.Numer.SEPA | `bool` | tylko-odczyt |  |  |
| Rachunek.SWIFT | `string` | bazodanowe |  |  |
| Rachunek.WgBank | `Key` | podlista |  |  |
| StatusBL | `Soneta.Core.StatusBialaLista` (enum) | bazodanowe | Status w Wykazie |  |
| StatusyBL | `SubTable<Soneta.Kasa.HistoriaStatusuBL>` | podlista |  |  |
| Typ | `Soneta.Kasa.TypRachunkuBankowego` (enum) | bazodanowe, tylko-odczyt |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusBialaLista (`Soneta.Core.StatusBialaLista`)
- `Niezweryfikowany` = 0 — Niezweryfikowany
- `Zarejestrowany` = 1 — Zarejestrowany
- `Niezarejestrowany` = 2 — Niezarejestrowany
- `NiePodlega` = 3 — Nie podlega weryfikacji

### TypRachunkuBankowego (`Soneta.Kasa.TypRachunkuBankowego`)
- `Nieokreslony` = 0
- `Pracownika` = 5001
- `EwidencjiSP` = 8001
- `Kontrahenta` = 9001
- `PIT` = 9011
- `CIT` = 9012
- `VAT` = 9013
- `ZalPIT` = 9014
- `AKC` = 9015
- `OSS` = 9016
- `Spoleczne` = 9021
- `Zdrowotne` = 9022
- `Fundusze` = 9023
- `PFRON` = 9024
- `PFRONWpłaty` = 9025
- `FEP` = 9026
- `ZUS` = 9027
- `PPK` = 9028
- `KAS` = 9029
- `KAS_GV` = 9030

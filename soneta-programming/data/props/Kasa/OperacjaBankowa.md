# Pola i właściwości klasy biznesowej: `Soneta.Kasa.OperacjaBankowa`
Nazwa tabeli: `OperacjeBankowe`
Tytuł: Operacje bankowe
Opis: Element szczegółowy raportu ewidencji ŚP (RaportESP) reprezentujący pojedynczą operację z wyciągu bankowego. Przechowuje dane zaimportowanej operacji bankowej (kwota, kierunek, rachunek, podmiot, opis) i umożliwia jej powiązanie z zapłatą oraz weryfikację w Wykazie podatników VAT (Biała Lista).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `WyciagBankowy` → `RaportESP`

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 10
- podlisty: 2
- subrowy: 0
- razem: 31

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DataOperacji | `Date` | bazodanowe |  |  |
| DataSprawdzeniaBL | `Date` | bazodanowe | Data sprawdzenia w Wykazie |  |
| Handlowa | `bool` | bazodanowe |  | Czy operacja bankowa dotyczy operacji zakwalifikowanej jako handlowa |
| Hash | `string` | bazodanowe, tylko-odczyt |  | SHA-1 wyliczony dla operacji przez mechanizm importowy |
| IdentyfikacjaPodmiotu | `Soneta.Kasa.SposóbIdentyfikacjiPodmiotu` (enum) | bazodanowe, tylko-odczyt |  |  |
| IdentyfikatorZapytania | `string` | bazodanowe | Identyfikator zapytania |  |
| Kierunek | `Soneta.Core.KierunekPlatnosci` (enum) | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| KwotaRaportu | `Currency` | bazodanowe |  |  |
| KwotaVAT | `Currency` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  |  |
| MetodaWeryfikacji | `Soneta.Core.MetodaWeryfikacjiBialaLista` (enum) | bazodanowe | Metoda weryfikacji |  |
| Mpp | `Soneta.Kasa.OperacjaBankowa.WartosciMpp` | tylko-odczyt |  |  |
| NumerRachunku | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| Podmiot | `string` | bazodanowe |  |  |
| Przychód | `Currency` | tylko-odczyt |  |  |
| RachunekWirtualny | `string` | bazodanowe |  |  |
| Rozchód | `Currency` | tylko-odczyt |  |  |
| SplitPayment | `bool` | tylko-odczyt |  |  |
| Stan | `Soneta.Kasa.StanOperacjiBankowej` (enum) | bazodanowe |  |  |
| StatusBL | `Soneta.Core.StatusBialaLista` (enum) | bazodanowe | Status w Wykazie |  |
| Tekst | `MemoText` | bazodanowe, podlista |  |  |
| WeryfikacjaBL | `Soneta.Kasa.OperacjaBankowa.WeryfikacjaBialaLista` | tylko-odczyt |  |  |
| WyciagBankowy | `Soneta.Kasa.RaportESP` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Zaplata | `Soneta.Kasa.Zaplata` | bazodanowe, tylko-odczyt |  |  |
| ZaplataPodmiot | `Soneta.Kasa.IPodmiotKasowy` | iface-ref |  |  |
| ZaplataRozliczana | `bool` |  |  |  |
| Zwrot | `bool` | bazodanowe |  | Czy z tej operacji bankowej ma powstać zapłata oznaczona jako zwrot |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ZaplataPodmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekPlatnosci (`Soneta.Core.KierunekPlatnosci`)
- `Brak` = 0
- `Przychod` = 1 — Przychód
- `Rozchod` = 2 — Rozchód

### MetodaWeryfikacjiBialaLista (`Soneta.Core.MetodaWeryfikacjiBialaLista`)
- `ApiMF` = 0 — Serwis API MF
- `PlikPlaskiMF` = 1 — Plik płaski MF

### StatusBialaLista (`Soneta.Core.StatusBialaLista`)
- `Niezweryfikowany` = 0 — Niezweryfikowany
- `Zarejestrowany` = 1 — Zarejestrowany
- `Niezarejestrowany` = 2 — Niezarejestrowany
- `NiePodlega` = 3 — Nie podlega weryfikacji

### SposóbIdentyfikacjiPodmiotu (`Soneta.Kasa.SposóbIdentyfikacjiPodmiotu`)
- `Brak` = 0 — Brak
- `WgNumeruRachunku` = 1
- `WgOpisu` = 2
- `WgNumeruIOpisu` = 3
- `WgWskazania` = 4
- `WgRachunkuWirtualnego` = 5
- `WgSerwisu` = 6
- `WgRachunkuPodmiotu` = 7

### StanOperacjiBankowej (`Soneta.Kasa.StanOperacjiBankowej`)
- `Wprowadzona` = 1 — Wprowadzona
- `Niezweryfikowana` = 2
- `Zweryfikowana` = 3

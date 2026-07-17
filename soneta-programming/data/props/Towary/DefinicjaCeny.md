# Pola i właściwości klasy biznesowej: `Soneta.Towary.DefinicjaCeny`
Nazwa tabeli: `DefinicjeCen`
Tytuł: Definicje cen
Opis: Konfigurowalna definicja cennika określająca zasady wyliczania, aktualizacji i rabatowania cen towarów. Zawiera algorytm kalkulacji ceny (bazowa, współczynnik, waluta, zaokrąglenie), priorytet, do pięciu poziomów rabatów, obsługę cen indywidualnych, grupowych, progowych i promocji okresowych oraz parametry wpływające na sposób przeliczania cen na dokumentach handlowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 48
- pola kalkulowane (z klas biznesowych): 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AkceptujPromocje | `bool` | bazodanowe |  | Określa, czy definicja ceny dopuszcza stosowanie promocji. |
| AktualizujPrzychodem | `bool` | bazodanowe |  | Określa, czy dana cena ma być automatycznie aktualizowana po wprowadzeniu dokumentu przychodowego. |
| Algorytm | `Soneta.Towary.AlgorytmCeny` | bazodanowe |  | Określa współczynnik uwzględniany w wyliczanej cenie |
| Algorytm.CechaBazowa | `string` | bazodanowe |  | Cecha towaru, która jest podstawą wyliczania ceny |
| Algorytm.CenaBazowa | `Soneta.Towary.DefinicjaCeny` | bazodanowe |  | Definicja ceny, która jest podstawą wyliczania |
| Algorytm.Definicja | `Soneta.Towary.DefinicjaCeny` |  |  |  |
| Algorytm.Delta | `double` | bazodanowe |  | O ile pomniejszyć kwotę 100, po zaokrągleniu. |
| Algorytm.Dokladnosc | `double` | bazodanowe |  | Dokladność z jaką należy zaokrąglić kwotą 100. |
| Algorytm.LiczonyOdBrutto | `bool` |  |  | Określa czy cena jest liczona od cenhy bazowej wg brutto. |
| Algorytm.LiczonyOdNetto | `bool` |  |  | Określa czy cena jest liczona od cenhy bazowej wg netto. |
| Algorytm.NazwaMetody | `string` |  |  |  |
| Algorytm.PrzykładZaokrąglenia | `string` |  |  |  |
| Algorytm.Typ | `Soneta.Towary.TypAlgorytmuCeny` | bazodanowe, enum |  | Określa sposób utworzenia algorytmu wyliczania ceny |
| Algorytm.Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  | Określa walutę, w której ma być wyrażona cena. |
| Algorytm.WgCenaBazowa | `Soneta.Business.Key` |  |  |  |
| Algorytm.WgWaluta | `Soneta.Business.Key` |  |  |  |
| Algorytm.Wspolczynnik | `Soneta.Towary.WspolczynnikCeny` | bazodanowe |  | Określa współczynnik uwzględniany w wyliczanej cenie |
| Algorytm.Wspolczynnik.Algorytm | `Soneta.Towary.AlgorytmCeny` |  |  |  |
| Algorytm.Wspolczynnik.Opis | `string` |  |  |  |
| Algorytm.Wspolczynnik.Typ | `Soneta.Towary.TypWspółczynnikaCeny` | bazodanowe, enum |  | Określa rodzaj współczynnika |
| Algorytm.Wspolczynnik.Wartosc | `string` | bazodanowe |  | W zależności od rodzaju współczynnika przyjmuje wartość, cechę lub właściwość będącą współczynnikiem |
| Algorytm.Wspolczynnik.Znak | `Soneta.Towary.ZnakWspółczynnika` | bazodanowe, enum |  | Określa sposób uwzglęcnienia współczynnika w cenie towaru |
| Algorytm.Wyrażenie | `string` |  |  |  |
| Algorytm.ZalezyOdDokumentu | `bool` | bazodanowe |  | Wyliczenie ceny możliwe jest tylko na dokumencie. Nie można wykorzystać ceny w cenniku |
| Algorytm.Zaokraglenie | `bool` | bazodanowe |  | Pozwala na automatyczne zaokrąglanie ceny wg podanych reguł. |
| Blokada | `bool` | bazodanowe |  | Określa cenę, która nie jest już używana przez program. |
| CenaOdbiorcy | `bool` | bazodanowe |  | Określa sposób wyliczania ceny kontrahenta. |
| CenyOkresowe | `bool` | bazodanowe | Ceny okresowe | Określa, czy definicja ceny dopuszcza cena okresowe. |
| DodawanaDoTowaru | `bool` | bazodanowe |  | Cena będzie dodawana i zapamiętana w towarze. |
| DomyslnaMarza | `Soneta.Types.Percent` | bazodanowe | Marża % | Proponowany narzut dla nowych cen |
| DomyslnyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut % | Proponowany narzut dla nowych cen |
| Indywidualna | `Soneta.Towary.AlgorytmRabatu` | bazodanowe |  | Określa sposób wyliczania ceny indywidualnej. |
| Indywidualna.Grupa | `Soneta.Business.FeatureDefinition` | bazodanowe |  | Definicja grupy kontrahenta, dokumentu, itp biorącej udział w naliczania rabatu. |
| Indywidualna.GrupaTowarowa | `Soneta.Business.FeatureDefinition` | bazodanowe |  | Definicja grupy towarowej biorącej udział w naliczania rabatu. |
| Indywidualna.Lokalizacja | `string` |  |  |  |
| Indywidualna.OpisRodzaju | `string` |  |  | Tekstowy opis działania rabatu. |
| Indywidualna.Rodzaj | `Soneta.Towary.RodzajRabatu` | bazodanowe, enum |  | Określa rodzaj naliczanego rabatu. |
| Indywidualna.WgGrupa | `Soneta.Business.Key` |  |  |  |
| Indywidualna.WgGrupaTowarowa | `Soneta.Business.Key` |  |  |  |
| Indywidualna.Wliczaj | `Soneta.Towary.WliczanieRabatu` | bazodanowe, enum |  | Określa sposób wpływania ratabu na pozycję dokumentu handlowego. |
| Indywidualna.WymaganaGrupa | `bool` |  |  | Określa, czy wymagane jest wypełnienie pola grupy towarowej. |
| Indywidualna.WymaganaGrupaTowarowa | `bool` |  |  | Określa, czy wymagane jest wypełnienie pola grupy towarowej. |
| Indywidualna2 | `Soneta.Towary.AlgorytmRabatu` | bazodanowe |  | Określa drugi sposób wyliczania ceny indywidualnej. |
| Indywidualna3 | `Soneta.Towary.AlgorytmRabatu` | bazodanowe |  | Określa trzeci sposób wyliczania ceny indywidualnej. |
| IndywidualnaRabatowana | `bool` | bazodanowe |  | Określa, czy cena indywidualna będzie rabatowana. |
| InfoCenaRabat | `Soneta.Handel.InfoCenaRabat` | bazodanowe, enum | Informacje o cenie i rabacie | Określa, czy system powinien zapisywać informacje o naliczonej cenie i rabacie pozycji dokumentu handlowego. |
| KGO | `bool` | bazodanowe | Obsługa KGO | Określa, czy definicja ceny obsługuje stawki KGO. |
| Kierunek | `Soneta.Towary.KierunekCeny` | bazodanowe, enum | Kierunek ceny |  |
| KierunekBrak | `bool` |  |  |  |
| KierunekPrzychod | `bool` |  |  |  |
| KierunekRozchod | `bool` |  |  |  |
| Metoda | `Soneta.Business.MemoText` | bazodanowe |  | Algorytm wyliczenia ceny |
| Nazwa | `string` | bazodanowe |  | Nazwa ceny |
| PodmiotCeny | `Soneta.Towary.PodmiotCeny` | bazodanowe, enum |  | Określa sposób wyliczania ceny kontrahenta. |
| Priorytet | `int` | bazodanowe |  | Priorytet określający kolejność wyliczania cen towaru. |
| ProgiIlosciowe | `bool` | bazodanowe | Progi ilościowe | Określa, czy definicja ceny dopuszcza progi ilościowe. |
| Przeliczaj | `bool` |  |  | Określa, czy cena jest automatycznie przeliczana. |
| Rabat1 | `Soneta.Towary.AlgorytmRabatu` | bazodanowe |  | Określa pierwszy rodzaj naliczanego rabatu. |
| Rabat2 | `Soneta.Towary.AlgorytmRabatu` | bazodanowe |  | Określa drugi rodzaj naliczanego rabatu. |
| Rabat3 | `Soneta.Towary.AlgorytmRabatu` | bazodanowe |  | Określa trzeci rodzaj naliczanego rabatu. |
| Rabat4 | `Soneta.Towary.AlgorytmRabatu` | bazodanowe |  | Określa czwarty rodzaj naliczanego rabatu. |
| Rabat5 | `Soneta.Towary.AlgorytmRabatu` | bazodanowe |  | Określa piąty rodzaj naliczanego rabatu. |
| RabatTerminPlatnosci | `Soneta.Towary.WliczanieRabatuZaTerminPlatnosci` | bazodanowe, enum | Rabat za wcześniejszy termin płatności | Określa sposób naliczania rabatu za wcześniejszy termin płatności. |
| RabatujPromocje | `bool` | bazodanowe |  | Określa, czy definicja ceny dopuszcza rabatowanie przeceny. |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### InfoCenaRabat (`Soneta.Handel.InfoCenaRabat`)
- `Nigdy` = 0
- `Zawsze` = 1
- `Bufor` = 2 — Gdy dokument w buforze

### KierunekCeny (`Soneta.Towary.KierunekCeny`)
- `Brak` = 1
- `Przychod` = 2
- `Rozchod` = 4

### PodmiotCeny (`Soneta.Towary.PodmiotCeny`)
- `Kontrahent` = 0 — kontrahenta głównego
- `Odbiorca` = 1 — odbiorcy/dostawcy

### RodzajRabatu (`Soneta.Towary.RodzajRabatu`)
- `Brak` = 0 — Brak
- `IndywidualnyKażdegoTowaru` = 1
- `GrupowyKażdegoTowaru` = 2
- `IndywidualnyGrupyTowarowej` = 3
- `GrupowyGrupyTowarowej` = 4
- `IndywidualnyWszystkichTowarów` = 6
- `GrupowyWszystkichTowarów` = 5
- `OkresowyKażdegoTowaru` = 7

### TypAlgorytmuCeny (`Soneta.Towary.TypAlgorytmuCeny`)
- `CenyWprowadzaneRęcznie` = 0 — Ceny wprowadzane ręcznie
- `NaPodstawieCenyBazowejNetto` = 1
- `NaPodstawieCenyBazowejBrutto` = 2
- `WyrażenieJakoCenaNetto` = 3
- `WyrażenieJakoCenaBrutto` = 4
- `KodMetody` = 5
- `CechaTowaruJakoCenaNetto` = 6
- `CechaTowaruJakoCenaBrutto` = 7
- `NaPodstawieOstatniejCenyZakupu` = 8
- `NaPodstawieOstatniejCenySprzedaży` = 9
- `NaPodstawieOstatniejCenyZakupuKontrahenta` = 10

### TypWspółczynnikaCeny (`Soneta.Towary.TypWspółczynnikaCeny`)
- `Liczba` = 0 — Liczba
- `Procent` = 1
- `Współczynnik` = 2
- `CechaTowaruLiczba` = 3
- `CechaTowaruLiczbaZWalutą` = 4
- `CechaTowaruUłamek` = 5
- `CechaTowaruProcent` = 6
- `WłaściwośćTowaru` = 7
- `WłaściwośćDokumentu` = 8
- `WłaściwośćPozycjiDokumentu` = 9
- `WłaściwośćKontrahenta` = 11
- `Cena` = 12

### WliczanieRabatu (`Soneta.Towary.WliczanieRabatu`)
- `PrzepiszDoPozycjiDokumentu` = 0 — Przepisz do pozycji dokumentu
- `MaksymalnyRabatPozycjiDokumentu` = 1
- `MinimalnyRabatPozycjiDokumentu` = 2
- `SumujRabatyPozycjiDokumentu` = 3
- `NaliczajKolejnoRabatyPozycjiDokumentu` = 4

### WliczanieRabatuZaTerminPlatnosci (`Soneta.Towary.WliczanieRabatuZaTerminPlatnosci`)
- `Brak` = 0
- `Sumuj` = 1 — Sumuj rabaty pozycji dokumentu
- `NaliczajKolejno` = 2 — Naliczaj kolejno rabaty pozycji dokumentu

### ZnakWspółczynnika (`Soneta.Towary.ZnakWspółczynnika`)
- `Brak` = 0 — Brak
- `Plus` = 1 — +
- `Minus` = 2 — -
- `PlusWstecz` = 3 — + wstecz
- `MinusWstecz` = 4 — - wstecz

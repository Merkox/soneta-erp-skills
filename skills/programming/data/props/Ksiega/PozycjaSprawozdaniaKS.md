# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PozycjaSprawozdaniaKS`
Nazwa tabeli: `PozycjeSprawKS`
Tytuł: Pozycje sprawozdań księgowych
Opis: Element szczegółowy sprawozdania finansowego (IPozycjaSprawozdaniaRoot). Reprezentuje pojedynczą pozycję sprawozdania (np. wiersz bilansu, RZiS) z kwotami za rok bieżący i poprzedni, treścią opisową, podstawą prawną oraz opcjonalnym załącznikiem. Pozycje tworzą hierarchiczną strukturę sprawozdania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `RootPoz` → `IPozycjaSprawozdaniaRoot`
Implementuje interfejsy: `IPozycjaSprawozdaniaRoot`
Selektor: pole `Typ` (`Soneta.Ksiega.TypPozycjiSprawozdzaniaKS`) — wiele typów w jednej tabeli, podtypów: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Attachment | `Db.Attachment` | bazodanowe | Załącznik | Załącznik powiązany z pozycją sprawozdania |
| Jednostka | `Soneta.Ksiega.JednostkaSprawozdaniaKS` | bazodanowe, tylko-odczyt |  | Jednostka sprawozdania, do którego należy pozycja |
| Kwoty | `Soneta.Ksiega.PozSprKsKwoty` (subrow) | bazodanowe |  | Kwoty główne pozycji sprawozdania księgowego |
| Kwoty.CzyRP | `bool` | bazodanowe |  | Czy podane są kwoty za rok poprzedni |
| Kwoty.RB | `Soneta.Ksiega.PozSprKsKwoty3` (subrow) | bazodanowe |  | Kwoty za rok bieżący |
| Kwoty.RB.CzyBC | `bool` | bazodanowe |  | Czy kwoty podane są w rozbiciu |
| Kwoty.RB.KwotaA | `decimal` | bazodanowe |  | Wartość łączna kwoty |
| Kwoty.RB.KwotaAInt | `long` |  |  |  |
| Kwoty.RB.KwotaB | `decimal` | bazodanowe |  | Część kwoty z zysków kapitałowych |
| Kwoty.RB.KwotaBInt | `long` |  |  |  |
| Kwoty.RB.KwotaC | `decimal` | bazodanowe |  | Część kwoty z innych źródeł przychodów |
| Kwoty.RB.KwotaCInt | `long` |  |  |  |
| Kwoty.RP | `Soneta.Ksiega.PozSprKsKwoty3` (subrow) | bazodanowe |  | Kwoty za rok poprzedni |
| Lp | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa pozycji sprawozdania księgowego |
| NazwaPliku | `string` | bazodanowe |  | Nazwa pliku |
| Podstawa | `Soneta.Ksiega.PozSprKsPodstawa` (subrow) | bazodanowe |  | Podstawa prawna pozycji użytkownika |
| Podstawa.Art | `string` | bazodanowe |  |  |
| Podstawa.Lit | `string` | bazodanowe |  |  |
| Podstawa.Pkt | `string` | bazodanowe |  |  |
| Podstawa.Ust | `string` | bazodanowe |  |  |
| Pozostale | `Soneta.Ksiega.PozSprKsKwoty` (subrow) | bazodanowe |  | Kwoty pozostałe pozycji sprawozdania księgowego |
| Pozycje | `SubTable<Soneta.Ksiega.PozycjaSprawozdaniaKS>` | podlista |  |  |
| RootPoz | `Soneta.Ksiega.IPozycjaSprawozdaniaRoot` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| Sprawozdanie | `Soneta.Ksiega.SprawozdanieKS` | bazodanowe, tylko-odczyt |  | Sprawozdanie, do którego należy pozycja |
| Tresc | `MemoText` | bazodanowe, podlista |  | Treść pozycji sprawozdania księgowego |
| Typ | `Soneta.Ksiega.TypPozycjiSprawozdzaniaKS` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ pozycji sprawozdania księgowego |
| Typ2 | `Soneta.Ksiega.Typ2PozycjiSprawozdzaniaKS` (enum) | bazodanowe, tylko-odczyt |  | Subtyp pozycji sprawozdania księgowego |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `ZasadyRachunkowosci` | 0 | `Soneta.Ksiega.PozycjaSprawozdaniaZasadyRachunkowosci` | Pozycja sprawozdania - zasady rachunkowości |
| `DodatkoweObjasnienia` | 1 | `Soneta.Ksiega.PozycjaSprawozdaniaDodatkoweObjasnienia` | Pozycja sprawozdania - dodatkowe wyjaśnienia |
| `PodatekDochodowy` | 2 | `Soneta.Ksiega.PozycjaSprawozdaniaPodatekDochodowy` | Pozycja sprawozdania - podatek dochodowy |
| `PodatekDochodowyUz` | 3 | `Soneta.Ksiega.PozycjaSprawozdaniaPodatekDochodowyUz` | Pozycja sprawozdania - podatek dochodowy (użytkownika) |
| `ZestawienieLokat` | 4 | `Soneta.Ksiega.PozycjaSprawozdaniaZestawienieLokat` | Pozycja sprawozdania - zestawienie lokat |
| `ZestawienieInformacji` | 5 | `Soneta.Ksiega.PozycjaSprawozdaniaZestawienieInformacji` | Pozycja sprawozdania - zestawienie informacji |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| RootPoz | `IPozycjaSprawozdaniaRoot` | `JednostkaSprawozdaniaKS`, `PozycjaSprawozdaniaKS`, `SprawozdanieKS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Typ2PozycjiSprawozdzaniaKS (`Soneta.Ksiega.Typ2PozycjiSprawozdzaniaKS`)
- `Podatkowa1` = 1 — A. Zysk / strata
- `Podatkowa2` = 2 — B. Przychody zwolnione z opodatkowania
- `Podatkowa3` = 3 — C. Przychody niepodlegające opodatkowaniu w roku bieżącym
- `Podatkowa4` = 4 — D. Przychody podlegające opodatkowaniu w roku bieżącym, ujęte w latach ubiegłych
- `Podatkowa5` = 5 — E. Koszty niestanowiące kosztów uzyskania przychodów
- `Podatkowa6` = 6 — F. Koszty nieuznawane za koszty uzyskania przychodów
- `Podatkowa7` = 7 — G. Koszty uznawane za koszty uzyskania przychodów, ujęte w latach ubiegłych
- `Podatkowa8` = 8 — H. Strata z lat ubiegłych
- `Podatkowa9` = 9 — I. Inne zmiany podstawy opodatkowania
- `Podatkowa10` = 10 — J. Podstawa opodatkowania podatkiem dochodowym
- `Podatkowa11` = 11 — K. Podatek dochodowy

### TypPozycjiSprawozdzaniaKS (`Soneta.Ksiega.TypPozycjiSprawozdzaniaKS`)
- `ZasadyRachunkowosci` = 0
- `DodatkoweObjasnienia` = 1
- `PodatekDochodowy` = 2
- `PodatekDochodowyUz` = 3
- `ZestawienieLokat` = 4
- `ZestawienieInformacji` = 5

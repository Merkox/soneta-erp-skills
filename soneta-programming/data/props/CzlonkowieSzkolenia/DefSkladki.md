# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.DefSkladki`
Nazwa tabeli: `DefSkladek`
Tytuł: Definicje składek
Opis: Słownik definicji składek członkowskich określający zasady naliczania opłat. Definiuje schemat numeracji, okres naliczania, kwotę lub algorytm wyliczania składki oraz parametry księgowania i generowania płatności.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie definicji. Zablokowane definicje dokumentów nie będą wyświetlane w liście wyboru. |
| ClassName | `string` | tylko-odczyt |  |  |
| DefinicjaEwidencji | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Informacja o miejscu umieszczenia dokumentu w ewidencji księgowej (sposobie księgowania). |
| GeneracjaPlatnosci | `bool` | bazodanowe |  | Określa czy dokument generuje płatności. |
| Kod | `string` | tylko-odczyt |  |  |
| KsiegowanieKasowe | `bool` | bazodanowe |  | Określa czy dokument ma być księgowany metodą kasową, a nie memoriałową. |
| NaliczanieProporcjonalne | `Soneta.CzlonkowieSzkolenia.NaliczanieProporcjonalne` (enum) | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  | Pełna nazwa definicji dokumentu wykorzystywana do wyszukiwania deifnicji. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  | Schemat numeracji dla definicji składki. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| OkresNaliczania | `Soneta.CzlonkowieSzkolenia.OkresDoNaliczania` (enum) | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Skladka | `Currency` | bazodanowe |  | Wielkość naliczanej składki. |
| SkladkaAlgorytm | `MemoText` | bazodanowe, podlista |  | Kod wyliczania stawki. |
| SkladkaDeklarowana | `bool` | bazodanowe |  | Określan czy używać stawki deklarowanej. |
| SkladkaWyliczana | `bool` | bazodanowe |  | Określa czy stawka jest wyliczana algorytmem. |
| Symbol | `string` | bazodanowe |  | Skrótowa nazwa definicji dokumentu wykorzystywana do wyszukiwania definicji. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NaliczanieProporcjonalne (`Soneta.CzlonkowieSzkolenia.NaliczanieProporcjonalne`)
- `PełnaKwota` = 0 — Pełna kwota
- `PełneOkresy` = 1
- `ProporcjonalnieMiesiące` = 2
- `ProporcjonalnieDni` = 3

### OkresDoNaliczania (`Soneta.CzlonkowieSzkolenia.OkresDoNaliczania`)
- `Miesięczny` = 0 — Miesięczny
- `Roczny` = 1
- `Jednorazowo` = 2
- `Brak` = 3

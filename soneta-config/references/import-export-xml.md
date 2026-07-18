# Import i eksport danych oraz ustawień konfiguracyjnych przez pliki XML

Platforma Soneta wczytuje i zapisuje dane przez pliki XML o wspólnym schemacie. Jeden format
obsługuje trzy zastosowania: **import według rekordów** (dane konfiguracyjne, pliki `*.dbinit.xml`,
bazy demo), **import przez logikę biznesową** (dokumenty i dane operacyjne z pełną walidacją)
oraz **eksport** wskazanych rekordów wraz z powiązanymi danymi (datapack).

## Szkielet pliku

```xml
<?xml version="1.0" encoding="utf-8"?>
<session xmlns="http://www.soneta.pl/schema/business">
  <NazwaObiektu guid="...">       <!-- element = nazwa obiektu biznesowego -->
    <Pole>wartość</Pole>
    <Kolekcja>                    <!-- podkolekcja obiektu -->
      <ObiektPodrzedny> ... </ObiektPodrzedny>
    </Kolekcja>
  </NazwaObiektu>
</session>
```

- Element główny: `<session xmlns="http://www.soneta.pl/schema/business">`.
- `business="true"` na `<session>` → **import przez logikę biznesową**; bez tego atrybutu
  (lub `business="false"`) → **import według rekordów**. Atrybut `business` można też
  postawić na pojedynczym rekordzie lub polu — lokalnie przełącza tryb.
- Elementy bezpośrednio w `<session>` noszą **nazwy obiektów biznesowych** (nazwa logiczna,
  l.poj. — np. `FormaPrawna`, `DokumentHandlowy`; nie nazwa tabeli SQL); ich elementy
  podrzędne to **pola/właściwości** obiektu albo **nazwy kolekcji** obiektów podrzędnych.
- `fromto="..."` na `<session>` ogranicza okres przetwarzania kolekcji datowanych
  (`fromto="(wszystko)"` = bez ograniczenia).

## Który tryb wybrać

| Sytuacja | Tryb |
|---|---|
| Dane konfiguracyjne, słowniki, definicje (brak złożonej logiki biznesowej) | według rekordów |
| Inicjowanie bazy (`*.dbinit.xml`), konwersje ustawień, baza demo/testowa | według rekordów |
| Dokumenty i dane operacyjne wymagające walidacji (np. dokumenty handlowe) | przez logikę biznesową |
| Obiekty ze złożoną logiką biznesową (przeliczenia, stany, zależności pól) | przez logikę biznesową |

## Identyfikacja rekordu

Głównym nośnikiem tożsamości jest **GUID** — importować i eksportować w całości można
**rekordy guidowane** (zob. artykuł *datapack-guidedrow* w `/soneta-programming`). Sposoby
wskazania rekordu, w kolejności rozpoznawania:

| Atrybut | Działanie |
|---|---|
| `where="Pole=wartość"` | znajdź **istniejący** rekord po polu z kluczem; **błąd**, gdy brak lub gdy wiele pasuje |
| `key="Pole=wartość"` | jak `where`, ale gdy brak — **tworzy nowy**; jeśli podano też `guid`, nadpisuje GUID znalezionego |
| `guid="..."` | rekord o tym GUID: istnieje → aktualizacja, nie istnieje → nowy z tym GUID-em |
| *(brak)* | zawsze nowy rekord |

Dodatkowo `id="..."` nadaje rekordowi **identyfikator lokalny w pliku** (unikalny — duplikat
to błąd), do użycia w referencjach dalej w tym samym pliku.

### Referencje do innych rekordów

Wartość pola wskazującego inny rekord zapisuje się tekstowo:

| Forma | Znaczenie |
|---|---|
| `00000000-0009-0013-0001-000000000000` | GUID rekordu obiektu docelowego |
| `Kontrahent:ba66f540-...` | GUID z jawnym wskazaniem miejsca docelowego — **nazwą obiektu lub tabeli** (`Kontrahent:` / `Kontrahenci:`); wymagane przy referencjach polimorficznych/interfejsowych |
| `FormaPrawna_1` | identyfikator lokalny (`id`) rekordu zdefiniowanego w tym pliku |
| `#123` | wewnętrzny numer ID rekordu — **unikać** w plikach przenośnych między bazami |
| *(pusto)* | brak referencji (null) |

W trybie przez logikę biznesową referencję można też wskazać elementem zagnieżdżonym
z `where`: `<Kontrahent where="Kod=Abc" />`.

## Formaty wartości w elementach

Wartości zapisywane są w kulturze niezmiennej (invariant) — niezależnie od ustawień
regionalnych:

| Typ | Format | Przykład |
|---|---|---|
| Tekst | wprost; pusty element `<Pole />` = pusty tekst | `<Nazwa>Spółka z o.o.</Nazwa>` |
| Liczba | kropka dziesiętna, bez separatorów tysięcy | `<Kurs>4.1234</Kurs>` |
| Data | `RRRR-MM-DD` | `<Data>2014-09-01</Data>` |
| Logiczny | `True` / `False` (wielkość liter dowolna) | `<Domyslna>True</Domyslna>` |
| Enum | nazwa wartości | `<Stan>Zatwierdzony</Stan>` |
| Kwota z walutą | liczba + kod waluty | `<Cena>5.13 PLN</Cena>` |
| Ilość z jednostką | liczba + jednostka | `<Ilosc>120 m</Ilosc>` |
| Ułamek/współczynnik | `licznik/mianownik` | `<Wspolczynnik>1/1</Wspolczynnik>` |
| Lista tekstów | wartości rozdzielone `\|` | `<KodyGUS>023\|999</KodyGUS>` |
| Dane binarne | Base64 | — |
| Referencja | zob. wyżej | `<SposobZaplaty>00000000-0003-...</SposobZaplaty>` |

Pole złożone (subrekord, np. numer rachunku bankowego) zapisuje się elementem zagnieżdżonym
z własnymi polami. Wartości prostych pól można też podawać **atrybutami** elementu rekordu
(`<Towar Kod="ABC">`), a w trybie biznesowym atrybuty służą ponadto do przekazania parametrów
tworzenia obiektu.

## Atrybuty specjalne — ściąga

| Atrybut | Gdzie | Działanie |
|---|---|---|
| `business` | session / rekord / pole | `true` = tryb przez logikę biznesową |
| `fromto` | session | okres przetwarzania kolekcji datowanych |
| `guid`, `where`, `key`, `id` | rekord | identyfikacja — zob. wyżej |
| `class` | rekord | konkretny typ przy dziedziczeniu (np. wariant specjalny obiektu) |
| `deleted="True"` | rekord | kasuje wskazany rekord (bez treści elementu) |
| `updateonly="true"` | rekord | tylko aktualizacja — gdy rekord nie istnieje, pomiń |
| `insertonly="true"` | rekord | tylko nowy — gdy rekord istnieje, pomiń |
| `dbversion` | rekord | wczytaj tylko przy konwersji do wersji ≥ tej wartości (pliki dbinit) |
| `addnew="true"` | kolekcja | tylko dopisuj — nie kasuj istniejących elementów kolekcji |
| `relationsimportmode="update"` | kolekcja | aktualizuj po GUID zamiast zastępować |
| `duplicate="Number"` | pole | przy konflikcie unikalności dołóż przyrostek ` 2`, ` 3`… |
| `date` | rekord w kolekcji historycznej | data wpisu historii (aktualizacja od tej daty) |
| `ctor` | rekord (tryb biznesowy) | wybór wariantu tworzenia obiektu |
| `priority`, `versionName` | session (dbinit) | zob. sekcję o dbinit |

---

## Część 1 — Import według rekordów (`business="false"`, domyślny)

Dane trafiają **bezpośrednio do pól rekordów**, z pominięciem logiki biznesowej. Właściwy dla
danych konfiguracyjnych i inicjujących, gdzie logika biznesowa nie istnieje lub nie jest
potrzebna. **Nie używać** na obiektach ze złożoną logiką biznesową — pominięcie jej może
zostawić dane niespójne.

Zasady:

- Używaj wyłącznie **pól bazodanowych** rekordu — nie właściwości kalkulowanych ani innych
  properties dodanych w obiektach biznesowych. Pola obiektu inwentaryzuje narzędzie
  `scan-props` ze skilla `/soneta-programming` — w tym trybie importu interesują nas tylko
  pola oznaczone w kolumnie `Rodzaj` znacznikiem **`bazodanowe`**.
- **Kolejność elementów pól nie ma znaczenia** — wartości trafiają wprost do rekordu.
- Obiekty przystosowane do tego trybu mają metody `OnImporting`/`OnImported` — po zakończeniu
  wczytywania pól rekordu wywoływana jest `OnImported`, która uzupełnia skutki logiki
  biznesowej (opis w artykule *row-types* skilla `/soneta-programming`).
- Podkolekcje (np. pozycje rekordu nadrzędnego) wczytuje się elementem o **nazwie kolekcji**;
  powiązanie z rodzicem realizują klucze bazodanowe relacji. Wewnątrz kolekcji `where`/`key`
  wyszukują w obrębie elementów tego rodzica.

```xml
<session xmlns="http://www.soneta.pl/schema/business">
  <FormaPrawna id="FormaPrawna_1" guid="00000000-0009-0013-0001-000000000000">
    <Kod>NO</Kod>
    <Nazwa>Nieokreślona</Nazwa>
    <Domyslna>true</Domyslna>
  </FormaPrawna>
</session>
```

### Zachowanie kolekcji przy aktualizacji rekordu

Gdy rekord nadrzędny już istnieje, element kolekcji domyślnie **zastępuje** jej zawartość:
istniejące elementy są kasowane (guidowane rekordy standardowe pozostają), po czym wczytywane
są elementy z pliku. Modyfikatory: `addnew="true"` (tylko dopisywanie),
`relationsimportmode="update"` (aktualizacja po GUID; elementy nieobecne w pliku są kasowane
po zakończeniu), `fromto` (kasowanie ogranicza się do okresu).

### Cechy (features)

```xml
<features>
  <feature name="Asortyment">Kraj</feature>
</features>
```

Wartością cechy referencyjnej jest GUID (lub `Obiekt:GUID`); cechy historyczne przyjmują
wartość obowiązującą od daty importu.

## Część 2 — Import przez logikę biznesową (`business="true"`)

Wartości ustawiane są przez **właściwości biznesowe** obiektów — z pełną walidacją,
ograniczeniami i skutkami ubocznymi (przeliczenia, generowanie numerów, zapisy powiązane).
Import może zgłaszać **błędy walidacji**, dokładnie tak jak przy ręcznym wprowadzaniu danych.

Zasady:

- **Kolejność elementów ma znaczenie** — właściwości są ustawiane po kolei, a każda może
  uruchamiać operacje biznesowe. Reguła praktyczna: odzwierciedlaj kolejność, w jakiej
  **operator wpisywałby dane na formularzu** (najpierw definicja dokumentu, potem kontrahent,
  potem pozycje, na końcu stan). Rzeczywistą kolejność pól i **sekcje danych** (zakładki, grupy)
  formularza — nawet gdy masz tylko skompilowane DLL — odczytasz narzędziem **`scan-forms`**
  ze skilla `/soneta-programming` (kolejność pól = kolejność wprowadzania; rozwija też ścieżki
  pól i `Include`).
- Dostępne właściwości biznesowe obiektu (oraz jego podkolekcje) zwraca narzędzie `scan-props`
  ze skilla `/soneta-programming`.
- Nowy obiekt może wymagać parametrów tworzenia — przekazuje się je **atrybutami** elementu
  rekordu (nazwa atrybutu = nazwa parametru); w kolekcji rodzic jest przekazywany
  automatycznie. Atrybut `ctor` wybiera wariant tworzenia.
- Referencje wygodnie wskazywać elementem z `where` po czytelnym kluczu (kod, symbol) —
  plik pozostaje przenośny między bazami.

```xml
<session xmlns="http://www.soneta.pl/schema/business" business="true">
  <DokumentHandlowy>
    <Definicja where="Symbol=PZ" />
    <Magazyn where="Symbol=02" />
    <Kontrahent where="Kod=Abc" />
    <Pozycje>
      <Pozycja>
        <Towar where="Kod=T-001" />
        <Ilosc>120 m</Ilosc>
        <Cena>5.13 PLN</Cena>
      </Pozycja>
    </Pozycje>
    <Stan>Zatwierdzony</Stan>       <!-- na końcu, jak operator -->
  </DokumentHandlowy>
</session>
```

## Część 3 — Eksport danych

Standardowy eksport działa **wyłącznie według rekordów**. Eksportowany jest wskazany rekord
**guidowany** oraz wszystkie rekordy powiązane relacjami guidowanymi — czyli cały **datapack**
(zob. *datapack-guidedrow* w `/soneta-programming`):

- relacje wewnętrzne (inner) — zapisywane **wewnątrz** elementu rekordu jako kolekcje,
- relacje zewnętrzne (outer) — dopisywane jako **osobne elementy główne** tego samego pliku,
- można dodatkowo wskazać kolekcje, relacje lub cechy do dołączenia (np. `Features`,
  nazwy kolekcji, ścieżki rozdzielane kropką).

Struktura wyniku:

- każdy rekord dostaje atrybuty `id` (identyfikator lokalny) i `guid`; typ pochodny — `class`;
- referencje zapisywane są jako `Obiekt:GUID` (rekordy guidowane, np.
  `DokumentHandlowy:1ee7f76c-...`) albo identyfikator lokalny (rekordy nieguidowane,
  dołączone do pliku);
- pola `RRRR-MM-DD`, kropka dziesiętna itd. — formaty jak w tabeli wyżej;
- skasowane rekordy można zaznaczyć wpisem `<NazwaObiektu guid="..." deleted="True" />`;
- `fromto` ogranicza eksport kolekcji datowanych do okresu.

Plik wyniku eksportu jest bezpośrednio zdatny do importu według rekordów — to podstawowy
sposób **przenoszenia ustawień konfiguracyjnych między bazami**.

## Pliki `*.dbinit.xml` — inicjowanie i konwersja bazy

Pliki `*.dbinit.xml` (osadzone w bibliotekach) inicjują nową bazę i **automatycznie konwertują
ustawienia** przy podnoszeniu wersji. Wczytywane są trybem według rekordów, z dodatkowymi
regułami:

- `<session>` musi mieć `versionName` (nazwa wersjonowania, np. `soneta`) i może mieć
  `priority` (kolejność wczytywania plików; mniejsza liczba = wcześniej; domyślnie 100 —
  np. słownik musi poprzedzać dane, które się do niego odwołują);
- **każdy rekord główny musi mieć `dbversion`** — rekord jest przetwarzany tylko, gdy wersja
  bazy jest niższa niż `dbversion` (czyli raz, przy konwersji do tej wersji); rekord bez
  `dbversion` jest w tym trybie pomijany;
- rekordy standardowe kasowane wpisem `deleted="True"` tracą status standardowego GUID-u,
  więc wpis może zostać ponownie zainicjowany w nowszej wersji.

W projekcie dodatku pliki `*.dbinit.xml` osadza się jako **EmbeddedResource** — sposób
osadzania (automatyczny przez Soneta.Sdk lub ręczny wpis w projekcie) opisuje artykuł
*sessionreader-sessionwriter* w `/soneta-programming`.

## Testowanie plików XML

Zbudowany plik przetestuj **próbą wczytania do bazy** narzędziem `dbmgr` (opis narzędzia:
`/soneta-tools`):

```bash
dbmgr importxml <NazwaBazy> plik.xml
```

Zasady:

- Testuj na **bazie testowej lub kopii** (backup/restore i tworzenie baz — `dbmgr`,
  `/soneta-tools`), nigdy od razu na bazie produkcyjnej — nieudany import (np. błędny plik
  roli) potrafi zablokować logowanie do bazy.
- Import przez logikę biznesową (`business="true"`) zgłosi błędy walidacji dokładnie jak przy
  ręcznym wprowadzaniu — komunikat wskazuje rekord i właściwość, której ustawienie się nie
  powiodło; popraw plik i ponów.
- Wczytanie powtórzone na tej samej bazie weryfikuje też **idempotencję** identyfikacji
  (rekordy z `guid`/`where`/`key` aktualizują się zamiast duplikować).
- Efekt obejrzyj na działającej aplikacji (`buscall`, `/soneta-tools`) albo w teście
  integracyjnym (`ImportBusinessXml` — artykuł *integration-tests* w `/soneta-programming`).

## Checklisty

**Przed importem:**
- [ ] Właściwy tryb: konfiguracja/inicjacja → według rekordów; dane operacyjne → logika biznesowa.
- [ ] Rekordy główne to rekordy guidowane; GUID-y stałe i unikalne (nie generuj ich losowo przy każdym wydaniu pliku).
- [ ] Pola zweryfikowane narzędziem `scan-props` (`/soneta-programming`): record-mode → tylko pola bazodanowe; business-mode → właściwości biznesowe.
- [ ] Business-mode: kolejność elementów jak przy wpisywaniu na formularzu; stan dokumentu na końcu.
- [ ] Referencje przenośne: GUID lub `where` po kodzie/symbolu; bez `#ID`.
- [ ] Kolekcje: świadomy wybór zastąpienia (domyślne) vs `addnew` vs `relationsimportmode="update"`.
- [ ] dbinit: `versionName`, `priority` i `dbversion` na każdym rekordzie głównym.

**Testowanie pliku:**
- [ ] Próbne wczytanie na bazie testowej/kopii: `dbmgr importxml <baza> plik.xml` (→ `/soneta-tools`).
- [ ] Ponowne wczytanie nie duplikuje rekordów (idempotencja identyfikacji).
- [ ] Weryfikacja efektu na działającej aplikacji (buscall → `/soneta-tools`) lub testem
  integracyjnym (`ImportBusinessXml` → artykuł *integration-tests* w `/soneta-programming`).

## Powiązania

- `/soneta-programming` — warstwa programistyczna importu/eksportu (klasy `SessionReader` /
  `SessionWriter`): artykuł *sessionreader-sessionwriter*; ponadto *datapack-guidedrow*
  (rekordy guidowane, datapack), *row-types* (`OnImporting`/`OnImported`), *scan-props*
  (inwentaryzacja pól i właściwości), *scan-forms* (zakładki, sekcje danych i kolejność pól
  formularza — kolejność wprowadzania pod `business="true"`), *integration-tests* (`ImportBusinessXml`).
- `/soneta-form-xml` — składnia formularzy (`Page`/`Group`/`Field`/`DataContext`/`EditValue`);
  zakładki i grupy jako sekcje danych do uzupełnienia.
- `/soneta-tools` — `dbmgr` (operacje na bazach, import XML z CLI), `buscall` (weryfikacja
  efektów importu na żywej aplikacji).
- [SKILL.md](../SKILL.md) — mapa tego skilla.

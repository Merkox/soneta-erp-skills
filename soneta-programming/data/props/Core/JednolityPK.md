# Pola i właściwości klasy biznesowej: `Soneta.Core.JednolityPK`
Nazwa tabeli: `JednolitePK`
Tytuł: Jednolity PK
Opis: Plik Jednolitego Pliku Kontrolnego (JPK) generowany i wysyłany do administracji skarbowej. Zawiera informacje o rodzaju, okresie, numerze korekty, formularzu, trybie generowania i podpisu, statusie wysyłki, UPO, plik binarny, metadane oraz powiązania z definicją XML, oddziałem i deklaracją VAT.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 28
- podlisty: 10
- subrowy: 0
- razem: 43

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AuthInfo | `MemoText` | bazodanowe, podlista |  | Informacja o podpisie nieautoryzowanym |
| BramkaJPK | `Soneta.Core.BramkaJPKFile` (enum) | bazodanowe, tylko-odczyt | Bramka JPK | Bramka pliku JPK |
| CelZlozenia | `string` | tylko-odczyt |  |  |
| Czas | `Time` | bazodanowe, tylko-odczyt |  | Czas generowania |
| CzyCIT | `bool` | tylko-odczyt |  |  |
| CzyJPKKRPD | `bool` | tylko-odczyt |  |  |
| CzyJPKVAT | `bool` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  | Data generowania |
| DefinicjaXmlNag | `Soneta.Core.DefXmlNag` | bazodanowe, tylko-odczyt | Definicja |  |
| DeklaracjaVAT7 | `Soneta.Core.IDeklaracja` | bazodanowe, tylko-odczyt, iface-ref | Deklaracja | Deklaracja VAT7 |
| DekretyZamkniecia | `bool` | bazodanowe, tylko-odczyt | Uwzględniaj dekrety zamknięcia |  |
| DziennikBufor | `bool` | bazodanowe, tylko-odczyt | Eksportuj zapisy w buforze |  |
| FormCode | `string` | bazodanowe | Kod formularza | Kod formularza JPK |
| FormSchemaVer | `string` | bazodanowe | Wersja wzorca | Wersja wzorca formularza JPK |
| FormSysCode | `string` | bazodanowe | Kod systemowy | Kod systemowy formularza JPK |
| InitUpload | `MemoText` | bazodanowe, podlista |  | Odpowiedź na żądanie otwarcia sesji wysyłania danych |
| InitUploadXml | `MemoText` | bazodanowe, podlista |  | Żądanie otwarcia sesji wysyłania danych |
| LokalizacjaPliku | `Soneta.Core.LokalizacjaJPK` (enum) | bazodanowe, tylko-odczyt | Lokalizacja pliku | Wskazuje miejsce oraz sposób przechowywania pliku JPK |
| MetaData | `MemoText` | bazodanowe, podlista |  | Plik metadanych (paczka wysyłki) w bazie danych |
| Metadane | `string` | bazodanowe, tylko-odczyt | Ścieżka do pliku metadanych (paczka wysyłki) |  |
| Nadrzedne | `SubTable<Soneta.Core.JednolityPKRel>` | podlista |  |  |
| NumerKorekty | `int` | bazodanowe, tylko-odczyt |  | Numer korekty |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt | Oddział firmy | Oddział firmy |
| Okres | `FromTo` | bazodanowe, podlista |  | Okres za który wygenerowano JPK |
| OkresObrachunkowy | `string` | bazodanowe, tylko-odczyt | Okres obrachunkowy |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Dodatkowy opis |
| Plik | `string` | bazodanowe, tylko-odczyt | Ścieżka do pliku JPK |  |
| PlikBinarny | `MemoBin` | bazodanowe | Zawartość pliku | Zawartość pliku JPK w bazie danych |
| PlikBinarnyEnc | `MemoBin` | bazodanowe | Zaszyfrowana zawartość pliku | Zawartość pliku JPK przygotowanego do wysyłki |
| PlikNazwa | `string` | tylko-odczyt |  |  |
| PlikNazwaHtml | `string` | tylko-odczyt |  |  |
| Podrzedne | `SubTable<Soneta.Core.JednolityPKRel>` | podlista |  |  |
| ProcessingError | `MemoText` | bazodanowe, podlista |  | Błąd przetwarzania danych |
| Rodzaj | `Soneta.Core.SlownikElem` | bazodanowe, tylko-odczyt | Rodzaj | Rodzaj |
| StatusJPK | `Soneta.Core.StatusPlikuJPK` (enum) | bazodanowe, tylko-odczyt | Status JPK | Status pliku JPK |
| Storage | `Soneta.Core.JednolityPK.JPKStorage` | tylko-odczyt |  |  |
| TrybGenerowania | `Soneta.Core.TrybGenerowaniaJPK` (enum) | bazodanowe, tylko-odczyt | Tryb generowania | Tryb generowania pliku JPK |
| TrybPodpisu | `Soneta.Core.TrybPodpisuJPK` (enum) | bazodanowe, tylko-odczyt | Tryb podpisu | Tryb podpisu pliku JPK |
| UPO | `MemoText` | bazodanowe, podlista |  | Urzędowe potwierdzenie odbioru |
| Wielooddzialowosc | `bool` | tylko-odczyt |  |  |
| WynikZestawieniaRPD | `string` | bazodanowe, tylko-odczyt | Wynik zestawienia RPD |  |
| ZakresDanych | `Soneta.Core.ZakresDanychJPK` (enum) | bazodanowe, tylko-odczyt | Zakres danych | Zakres generowanych danych |
| ZrodloJPK | `Soneta.Core.ZrodloPlikuJPK` (enum) | bazodanowe, tylko-odczyt | Źródło JPK | Źródło pliku JPK |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| DeklaracjaVAT7 | `IDeklaracja` | `Deklaracja` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BramkaJPKFile (`Soneta.Core.BramkaJPKFile`)
- `Nieokreslona` = 1 — Nieokreślona
- `Testowa` = 2
- `Oficjalna` = 3

### LokalizacjaJPK (`Soneta.Core.LokalizacjaJPK`)
- `FileSystem` = 1 — System plików
- `BazaDanychSkompresowany` = 2 — W bazie danych

### StatusPlikuJPK (`Soneta.Core.StatusPlikuJPK`)
- `Created` = 10 — Utworzony
- `WaitingForSignature` = 15 — Oczekuje na podpis
- `ReadyToSend` = 20 — Gotowy do wysyłki
- `SendingFiles` = 30 — Wysyłanie plików...
- `ProcessingByGate` = 40 — Przetwarzanie (MF)...
- `Finished` = 100 — Pobrano UPO
- `Failed` = 200 — Błąd przetwarzania

### TrybGenerowaniaJPK (`Soneta.Core.TrybGenerowaniaJPK`)
- `Standard` = 0 — Standardowy
- `OnRequest` = 1 — Na żądanie

### TrybPodpisuJPK (`Soneta.Core.TrybPodpisuJPK`)
- `Brak` = 0
- `Enova365Kwalifikowany` = 1 — Podpis kwalifikowany (aplikacja)
- `Zewnetrzny` = 2 — Profil Zaufany (zewnętrzny)
- `Enova365DaneAutoryzujace` = 3 — Podpis nieweryfikowany (bramka mikro)
- `Enova365DaneAutoryzujaceStandard` = 4 — Podpis nieweryfikowany (bramka standard)

### ZakresDanychJPK (`Soneta.Core.ZakresDanychJPK`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Komplet` = 1 — Dane ewidencyjne oraz deklaracyjne
- `Ewidencyjne` = 2 — Dane ewidencyjne
- `Deklaracyjne` = 3 — Dane deklaracyjne
- `Importowane` = 4 — Dane importowane
- `Zapisy` = 5 — Zapisy
- `ZapisyWykaz` = 6 — Zapisy oraz wykaz

### ZrodloPlikuJPK (`Soneta.Core.ZrodloPlikuJPK`)
- `Nieokreslone` = 0 — Nieokreślone
- `RejestrVAT` = 1 — Rejestr VAT
- `PlikZewnetrzny` = 2 — Plik zewnętrzny
- `GrupaBaz` = 3 — Grupa baz podrzędnych
- `JPKOddzialowe` = 4 — Pliki JPK Oddziałowe
- `WgPowiazan` = 5 — Według powiązań

# Pola i właściwości klasy biznesowej: `Soneta.Core.JednolityPK`
Nazwa tabeli: `JednolitePK`
Tytuł: Jednolity PK
Opis: Plik Jednolitego Pliku Kontrolnego (JPK) generowany i wysyłany do administracji skarbowej. Zawiera informacje o rodzaju, okresie, numerze korekty, formularzu, trybie generowania i podpisu, statusie wysyłki, UPO, plik binarny, metadane oraz powiązania z definicją XML, oddziałem i deklaracją VAT.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 33
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AuthInfo | `Soneta.Business.MemoText` | bazodanowe |  | Informacja o podpisie nieautoryzowanym |
| BramkaJPK | `Soneta.Core.BramkaJPKFile` | bazodanowe, enum | Bramka JPK | Bramka pliku JPK |
| CelZlozenia | `string` |  |  |  |
| Czas | `Soneta.Types.Time` | bazodanowe |  | Czas generowania |
| CzyCIT | `bool` |  |  |  |
| CzyJPKKRPD | `bool` |  |  |  |
| CzyJPKVAT | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data generowania |
| DefinicjaXmlNag | `Soneta.Core.DefXmlNag` | bazodanowe | Definicja |  |
| DeklaracjaVAT7 | `Soneta.Core.IDeklaracja` | bazodanowe, iface-ref | Deklaracja | Deklaracja VAT7 |
| DekretyZamkniecia | `bool` | bazodanowe | Uwzględniaj dekrety zamknięcia |  |
| DziennikBufor | `bool` | bazodanowe | Eksportuj zapisy w buforze |  |
| FormCode | `string` | bazodanowe | Kod formularza | Kod formularza JPK |
| FormSchemaVer | `string` | bazodanowe | Wersja wzorca | Wersja wzorca formularza JPK |
| FormSysCode | `string` | bazodanowe | Kod systemowy | Kod systemowy formularza JPK |
| InitUpload | `Soneta.Business.MemoText` | bazodanowe |  | Odpowiedź na żądanie otwarcia sesji wysyłania danych |
| InitUploadXml | `Soneta.Business.MemoText` | bazodanowe |  | Żądanie otwarcia sesji wysyłania danych |
| LokalizacjaPliku | `Soneta.Core.LokalizacjaJPK` | bazodanowe, enum | Lokalizacja pliku | Wskazuje miejsce oraz sposób przechowywania pliku JPK |
| MetaData | `Soneta.Business.MemoText` | bazodanowe |  | Plik metadanych (paczka wysyłki) w bazie danych |
| Metadane | `string` | bazodanowe | Ścieżka do pliku metadanych (paczka wysyłki) |  |
| Nadrzedne | `Soneta.Business.SubTable<Soneta.Core.JednolityPKRel>` |  |  |  |
| NumerKorekty | `int` | bazodanowe |  | Numer korekty |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Okres za który wygenerowano JPK |
| OkresObrachunkowy | `string` | bazodanowe | Okres obrachunkowy |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Dodatkowy opis |
| Plik | `string` | bazodanowe | Ścieżka do pliku JPK |  |
| PlikBinarny | `Soneta.Business.MemoBin` | bazodanowe | Zawartość pliku | Zawartość pliku JPK w bazie danych |
| PlikBinarnyEnc | `Soneta.Business.MemoBin` | bazodanowe | Zaszyfrowana zawartość pliku | Zawartość pliku JPK przygotowanego do wysyłki |
| PlikNazwa | `string` |  |  |  |
| PlikNazwaHtml | `string` |  |  |  |
| Podrzedne | `Soneta.Business.SubTable<Soneta.Core.JednolityPKRel>` |  |  |  |
| ProcessingError | `Soneta.Business.MemoText` | bazodanowe |  | Błąd przetwarzania danych |
| Rodzaj | `Soneta.Core.SlownikElem` | bazodanowe | Rodzaj | Rodzaj |
| StatusJPK | `Soneta.Core.StatusPlikuJPK` | bazodanowe, enum | Status JPK | Status pliku JPK |
| Storage | `Soneta.Core.JednolityPK.JPKStorage` |  |  |  |
| TrybGenerowania | `Soneta.Core.TrybGenerowaniaJPK` | bazodanowe, enum | Tryb generowania | Tryb generowania pliku JPK |
| TrybPodpisu | `Soneta.Core.TrybPodpisuJPK` | bazodanowe, enum | Tryb podpisu | Tryb podpisu pliku JPK |
| UPO | `Soneta.Business.MemoText` | bazodanowe |  | Urzędowe potwierdzenie odbioru |
| Wielooddzialowosc | `bool` |  |  |  |
| WynikZestawieniaRPD | `string` | bazodanowe | Wynik zestawienia RPD |  |
| ZakresDanych | `Soneta.Core.ZakresDanychJPK` | bazodanowe, enum | Zakres danych | Zakres generowanych danych |
| ZrodloJPK | `Soneta.Core.ZrodloPlikuJPK` | bazodanowe, enum | Źródło JPK | Źródło pliku JPK |

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

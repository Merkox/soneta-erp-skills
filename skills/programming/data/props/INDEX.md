# Indeks pól tabel biznesowych (dane wygenerowane z DLL)

Modułów z tabelami: **37** · tabel: **1188** · interfejsów: **137**.

Pliki w tym katalogu zostały wygenerowane wsadowo przez
`scripts/export-props-all.csx` (ta sama logika co `scan-props.csx`).
Każdy plik `<Moduł>/<RowType>.md` zawiera pełną tabelę pól jednej tabeli,
a `<Moduł>/INDEX.md` — inwentaryzację tabel tego modułu.
Instrukcja odczytu i regeneracji: [../../references/scan-props.md](../../references/scan-props.md).

## Jak znaleźć tabelę

**Znasz `RowType`** (np. `DokumentHandlowy`) — plik ma nazwę `<Moduł>/<RowType>.md`,
więc wystarczy jedno polecenie zamiast czytania indeksów:

```bash
ls */DokumentHandlowy.md          # → Handel/DokumentHandlowy.md
ls */Pracownik*.md               # gdy nie znasz dokładnej nazwy
```

**Znasz nazwę tabeli w bazie** (np. `DokHandlowe`) albo szukasz po tytule:

```bash
rg -l '`DokHandlowe`' */INDEX.md          # moduł zawierający tabelę
rg '^\| \w+ \| Dokumenty handlowe ' */INDEX.md
```

**Szukasz tabel z polem danego typu** (relacje do obiektu):

```bash
rg -l 'Soneta\.CRM\.Kontrahenci\.Kontrahent`' */*.md
```

**Nie wiesz, gdzie szukać** — wybierz moduł z listy poniżej i otwórz jego `INDEX.md`.
Interfejsy i tabele je implementujące: [Interfaces.md](Interfaces.md).

## Moduły

| Moduł | Tabel | Opis | Indeks |
|-------|------:|------|--------|
| BI | 39 | Moduł Business Intelligence. Zawiera definicje kostek analitycznych, miar, wymiarów, raportów oraz mechanizmy agregacji i wizualizacji danych biznesowych. | [BI/INDEX.md](BI/INDEX.md) |
| Business | 69 | Moduł systemowy zawierający podstawowe definicje typów danych, struktur tabel oraz obiektów bazodanowych platformy enova365. Definiuje typy proste (string, int, decimal, date itp.), konfigurację systemu, uprawnienia, powiadomienia i mechanizmy wersjonowania. | [Business/INDEX.md](Business/INDEX.md) |
| CRM | 56 | Moduł zarządzania relacjami z klientami (CRM). Obsługuje ewidencję kontrahentów, osób kontaktowych, banków, urzędów oraz lokalizacji wraz z ich danymi adresowymi i kontaktowymi. Zawiera mechanizmy transakcji i leadów sprzedażowych, zdarzenia CRM, obsługę poczty elektronicznej, szablony korespondencji oraz zarządzanie opiekunami i kategoriami kontrahentów. | [CRM/INDEX.md](CRM/INDEX.md) |
| Core | 176 | Moduł podstawowy platformy enova365 zawierający wspólne obiekty biznesowe. Obejmuje kontrahentów, adresy, lokalizacje, banki, słowniki, szablony, definicje dokumentów, powiadomienia, załączniki oraz mechanizmy konfiguracji systemu. | [Core/INDEX.md](Core/INDEX.md) |
| CzlonkowieSzkolenia | 43 | Moduł zarządzania członkami i szkoleniami organizacji. Zawiera kartotekę członków, kursy szkoleniowe, zapisy, certyfikaty oraz harmonogramy szkoleń. | [CzlonkowieSzkolenia/INDEX.md](CzlonkowieSzkolenia/INDEX.md) |
| Deklaracje | 3 | Moduł obsługujący deklaracje podatkowe i sprawozdawcze. Zawiera szablony deklaracji, formularze XML, mechanizmy generowania i wysyłki deklaracji do urzędów. | [Deklaracje/INDEX.md](Deklaracje/INDEX.md) |
| Delegacje | 9 | Moduł obsługujący delegacje służbowe. Zawiera definicje delegacji, etapy podróży, diety, koszty przejazdów, noclegi oraz rozliczenia delegacji pracowników. | [Delegacje/INDEX.md](Delegacje/INDEX.md) |
| Dms | 19 | Moduł zarządzania dokumentami (DMS). Zawiera rejestry dokumentów, kategorie, statusy, obiegi oraz mechanizmy archiwizacji i wersjonowania dokumentów. | [Dms/INDEX.md](Dms/INDEX.md) |
| EwidencjaVat | 5 | Moduł ewidencji VAT. Zawiera rejestry VAT zakupu i sprzedaży, deklaracje VAT, pliki JPK oraz mechanizmy kontroli i raportowania podatku VAT. | [EwidencjaVat/INDEX.md](EwidencjaVat/INDEX.md) |
| HR | 114 | Moduł zarządzania zasobami ludzkimi (HR). Zawiera strukturę organizacyjną, stanowiska, kompetencje, oceny pracownicze, szkolenia, rekrutację oraz planowanie kariery. | [HR/INDEX.md](HR/INDEX.md) |
| HR2 | 14 | Rozszerzenie modułu HR o dodatkowe funkcjonalności. Zawiera zaawansowane mechanizmy zarządzania kompetencjami, celami, ocenami okresowymi i rozwojem pracowników. | [HR2/INDEX.md](HR2/INDEX.md) |
| Handel | 38 | Moduł handlowy obsługujący dokumenty sprzedaży, zakupu, zamówień i innych operacji handlowych. Zawiera definicje dokumentów, relacje między dokumentami, pozycje dokumentów, sumy VAT, rozliczenia oraz mechanizmy fiskalizacji i EDI. | [Handel/INDEX.md](Handel/INDEX.md) |
| Import | 1 | Moduł importu danych do księgowości. Zawiera definicje importu dokumentów z zewnętrznych systemów finansowo-księgowych. | [Import/INDEX.md](Import/INDEX.md) |
| Kadry | 88 | Moduł kadrowy obsługujący dane pracowników. Zawiera kartoteki pracowników, umowy o pracę, historię zatrudnienia, nieobecności, badania lekarskie, szkolenia BHP oraz dane ubezpieczeniowe. | [Kadry/INDEX.md](Kadry/INDEX.md) |
| Kalend | 75 | Moduł zarządzania czasem pracy. Zawiera kalendarze, definicje dni, strefy czasowe, harmonogramy pracy, reguły rozliczania czasu pracy oraz ewidencję obecności. | [Kalend/INDEX.md](Kalend/INDEX.md) |
| Kasa | 32 | Moduł gospodarki kasowo-bankowej obsługujący ewidencję środków pieniężnych w kasach i na rachunkach bankowych. Realizuje pełny obieg dokumentów płatniczych — od rejestracji płatności i zapłat, przez przelewy i raporty kasowe, po rozliczenia i rozrachunki z kontrahentami. Wspiera magazyn walut, preliminarz płatności, bankowość elektroniczną oraz mechanizm podzielonej płatności (MPP). | [Kasa/INDEX.md](Kasa/INDEX.md) |
| Ksiega | 42 | Moduł księgowości obsługujący pełną rachunkowość firmy: plan kont, zapisy księgowe, dekrety, dzienniki i okresy obrachunkowe. Zapewnia mechanizmy predekretacji za pomocą schematów księgowych, rozliczenia księgowe, opisy analityczne z podzielnikami kosztów, zestawienia księgowe oraz sprawozdania finansowe (bilans, RZiS, rachunek przepływów). Obsługuje również KPiR, kręgi kosztów, słowniki analityczne, matryce dokumentów i rozliczenia złych długów. | [Ksiega/INDEX.md](Ksiega/INDEX.md) |
| Magazyny | 5 | Moduł gospodarki magazynowej obsługujący ewidencję stanów, obrotów i zasobów magazynowych. Definiuje magazyny, okresy magazynowe, partie towarów (grupy dostaw) oraz mechanizmy wyceny rozchodu (FIFO, LIFO, wg cechy). | [Magazyny/INDEX.md](Magazyny/INDEX.md) |
| ManagementTools | 1 | Moduł narzędzi zarządzania platformy enova365. Zawiera rejestr konfiguracji systemu umożliwiający przechowywanie i wersjonowanie ustawień w formacie JSON. | [ManagementTools/INDEX.md](ManagementTools/INDEX.md) |
| Oceny | 19 | Moduł ocen pracowniczych. Zawiera definicje arkuszy ocen, kryteria oceniania, skale oraz mechanizmy przeprowadzania i raportowania ocen okresowych. | [Oceny/INDEX.md](Oceny/INDEX.md) |
| Place | 33 | Moduł płacowy obsługujący naliczanie wynagrodzeń. Zawiera listy płac, składniki wynagrodzenia, elementy wypłat, potrącenia, zasiłki, deklaracje PIT oraz rozliczenia z ZUS i US. | [Place/INDEX.md](Place/INDEX.md) |
| PracaHybrydowa | 6 | Moduł obsługujący pracę zdalną i hybrydową. Zawiera definicje miejsc pracy, harmonogramy pracy zdalnej oraz ewidencję obecności w biurze i poza nim. | [PracaHybrydowa/INDEX.md](PracaHybrydowa/INDEX.md) |
| Produkcja | 23 | Moduł produkcyjny obsługujący planowanie i realizację procesów wytwórczych. Definiuje technologie produkcyjne z operacjami, pozycjami surowcowymi i produktowymi, czasami operacji oraz zasobami (maszynami, osobami). Wspiera rejestrację przebiegu produkcji, kalkulację kosztów wytworzenia, rezerwację surowców, raportowanie braków i awarii oraz rozliczenie akordowe. | [Produkcja/INDEX.md](Produkcja/INDEX.md) |
| ProdukcjaPro | 66 | Zaawansowany moduł produkcji. Zawiera zlecenia produkcyjne, operacje technologiczne, harmonogramowanie, kontrolę jakości, marszruty oraz szczegółowe rozliczanie kosztów produkcji. | [ProdukcjaPro/INDEX.md](ProdukcjaPro/INDEX.md) |
| Przeszeregowania | 2 | Moduł obsługujący przeszeregowania pracowników. Zawiera mechanizmy masowych zmian warunków zatrudnienia, wynagrodzeń i stanowisk. | [Przeszeregowania/INDEX.md](Przeszeregowania/INDEX.md) |
| RMK | 3 | Moduł rozliczeń międzyokresowych kosztów (RMK). Zawiera definicje harmonogramów rozliczania kosztów w czasie, pozycje rozliczeń oraz automatyczne generowanie dekretów. | [RMK/INDEX.md](RMK/INDEX.md) |
| RealEstate | 19 | Moduł zarządzania nieruchomościami. Zawiera kartotekę nieruchomości, lokali, najemców, umowy najmu, rozliczenia mediów oraz mechanizmy fakturowania opłat. | [RealEstate/INDEX.md](RealEstate/INDEX.md) |
| Samochodowka | 10 | Moduł ewidencji przebiegu pojazdów (kilometrówka). Zawiera rejestr pojazdów, trasy, stawki za kilometry oraz rozliczenia kosztów przejazdów służbowych. | [Samochodowka/INDEX.md](Samochodowka/INDEX.md) |
| SrodkiTrwale | 27 | Moduł obsługujący środki trwałe i wartości niematerialne. Zawiera kartotekę środków trwałych, dokumenty OT/LT/MT, amortyzację, inwentaryzację oraz plan amortyzacji. | [SrodkiTrwale/INDEX.md](SrodkiTrwale/INDEX.md) |
| Support | 17 | Moduł wsparcia technicznego i helpdesk. Zawiera zgłoszenia serwisowe, kolejki obsługi, umowy SLA, bazę wiedzy oraz mechanizmy śledzenia i eskalacji problemów. | [Support/INDEX.md](Support/INDEX.md) |
| Towary | 27 | Moduł kartoteki towarów i usług obsługujący ewidencję asortymentu, jednostek miar z przelicznikami, cenników (w tym cen indywidualnych, grupowych, progowych i promocji okresowych) oraz kodów kreskowych. Definiuje schematy opakowań, zamienniki towarowe, komplety produkcyjne, klasyfikacje CN/CPV/BDO/SUP oraz mechanizmy rabatowania i wyceny. | [Towary/INDEX.md](Towary/INDEX.md) |
| Vehicles | 16 | Moduł zarządzania flotą pojazdów. Zawiera kartotekę pojazdów, przeglądy, ubezpieczenia, tankowania, koszty eksploatacji oraz przypisania kierowców. | [Vehicles/INDEX.md](Vehicles/INDEX.md) |
| Waluty | 3 | Moduł obsługujący kursy walut i tabele kursowe. Zawiera definicje walut, tabele kursowe z NBP i ECB oraz mechanizmy przeliczania wartości walutowych. | [Waluty/INDEX.md](Waluty/INDEX.md) |
| WebAuthorization | 4 | Moduł autoryzacji webowej. Zawiera definicje uprawnień, tokenów dostępu oraz mechanizmy uwierzytelniania użytkowników aplikacji webowych enova365. | [WebAuthorization/INDEX.md](WebAuthorization/INDEX.md) |
| Windykacja | 6 | Moduł obsługujący procesy windykacji należności. Zawiera definicje schematów windykacyjnych, akcje windykacyjne, monity oraz śledzenie statusów windykacji kontrahentów. | [Windykacja/INDEX.md](Windykacja/INDEX.md) |
| Workflow | 17 | Moduł automatyzacji procesów biznesowych (workflow). Zawiera definicje procesów, kroki, warunki, akcje automatyczne oraz mechanizmy sterowania obiegiem dokumentów. | [Workflow/INDEX.md](Workflow/INDEX.md) |
| Zadania | 61 | Moduł zarządzania zadaniami i projektami. Zawiera definicje zadań, harmonogramy, przypisania, śledzenie czasu pracy (TimeTrack) oraz rozliczanie realizacji. | [Zadania/INDEX.md](Zadania/INDEX.md) |


# ETAP 2 — Architektura modułu

Cel: określić **jak** moduł będzie zbudowany — role, dane, interfejs, integracje. Dokument dla zespołu projektowego. Nadal bez szczegółowej zawartości obiektów (to Etap 3) — tu chodzi o architekturę i główne struktury.

## Pytania do zadania użytkownikowi

**Pierwsza tura — role i konfiguracja:**
- Jakie role użytkowników będą korzystać z modułu? Jakie zadania realizują?
- Jakie elementy powinny być konfigurowalne przez klienta?

**Druga tura — dane i interfejs:**
- Jakie są główne obiekty danych? (dokumenty, kartoteki, słowniki)
- Jak powinna wyglądać struktura menu?

**Trzecia tura — integracje i przyszłość:**
- Jakie dane z istniejących modułów Soneta będą wykorzystywane? *(w tym momencie przeczytaj odpowiednie moduły z `references/tables.md`)*
- Czy moduł integruje się z systemami zewnętrznymi?
- Czy klient ma dane do migracji?

## Sekcje dokumentu Etapu 2

### 2.1. Role użytkowników
Lista operatorów, ich zadania, procesy w których uczestniczą.

### 2.2. Zakres konfiguracji modułu
Elementy konfigurowalne: definicje dokumentów, słowniki, ustawienia, opcje programu dostępne tylko dla pewnych grup klientów. Zarówno konfiguracja wstępna, jak i definicje używane jako podpowiedzi przy przetwarzaniu danych operacyjnych.

### 2.3. Kluczowe struktury danych
Najważniejsze struktury danych — dokumenty, kartoteki. Bez szczegółowej zawartości (to Etap 3). Ogólny diagram relacji między głównymi obiektami.

Na podstawie `references/tables.md` sprawdź:
- czy potrzebne struktury już istnieją w platformie (unikanie duplikacji),
- jakie tabele nadrzędne mogą być wykorzystane,
- jakie wzorce projektowe stosują istniejące moduły (podział konfiguracyjne/operacyjne, definicje dokumentów, obiekty główne Guided i szczegółowe w relacji do nich, datapacki).

### 2.4. Struktura menu i elementy interfejsu
Foldery, hierarchia list w menu głównym, grupowanie funkcjonalne. Wyróżnij elementy interfejsu kluczowe dla sukcesu produktu (np. w kontrolingu — miejsce do budowania zapytań i warunków na wzór arkusza, AND/OR).

### 2.5. Relacje z modułami platformy Soneta
Na podstawie `references/tables.md`:
- wskaż konkretne moduły, z którymi nowy moduł współpracuje (np. Handel, Kadry, Ksiega, CRM),
- wymień konkretne tabele i obiekty, do których się odwołuje (relacje lookup/inner),
- określ, czy realizacja wymaga rozszerzenia istniejących tabel (nowe kolumny lub relacje do już istniejących obiektów).

### 2.6. Relacje z innymi systemami
Integracje z systemami zewnętrznymi, wymiana danych, procesy integracyjne. Jakie dane zasilają system BI i jakie dane BI zwraca do modułu.

### 2.7. Migracja danych
Dane do importu (kartoteki, dokumenty historyczne, salda), źródła (inne ERP, Excel, bazy), wymagania dotyczące zachowania historii.

### 2.8. Wydajność i skalowalność
- **Wolumeny danych** — przewidywana liczba rekordów w kluczowych tabelach (bieżąca i docelowa), częstotliwość zapisu i odczytu.
- **Optymalizacja dostępu** — tabele i operacje wymagające uwagi (dedykowane indeksy, widoki, denormalizacja, cache).
- **Przetwarzanie wsadowe vs online** — co musi działać w czasie rzeczywistym, a co w tle/wsadowo (przeliczenia, raporty, synchronizacja).
- **Skalowalność** — zachowanie przy rosnącej liczbie użytkowników i rekordów, potencjalne wąskie gardła i sposoby ich unikania.

### 2.9. Kierunki rozwoju
Przyszłe funkcjonalności poza zakresem bieżącej wersji (o ile taki rozwój jest planowany).

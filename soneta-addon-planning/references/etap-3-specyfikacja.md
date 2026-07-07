# ETAP 3 — Specyfikacja szczegółowa

Cel: dostarczyć szczegółowy opis każdego elementu modułu na poziomie implementacyjnym. Dokument dla zespołu implementacyjnego i AI (jest podstawą do generowania `business.xml`, formularzy i kodu w kolejnych skillach).

## Pytania do zadania użytkownikowi

Na tym etapie pytania dotyczą szczegółów poszczególnych obiektów. Pracuj obiekt po obiekcie:
- Jakie pola powinien mieć ten dokument/kartoteka?
- Jakie stany przechodzi? (bufor, zatwierdzony, anulowany…)
- Jakie czynności są dostępne? (zatwierdzanie, kopiowanie, generowanie…)
- Jakie wydruki i raporty?
- Kto ma dostęp do czego?

## Sekcje dokumentu Etapu 3

### 3.1. Dane operacyjne
Dla każdego obiektu danych:
- pola danych z typami,
- cechy szczególne (historyczność, numeracja dokumentów, stany),
- listy szczegółowe (relacje inner),
- relacje do innych danych modułu i do danych spoza modułu,
- część konfiguracyjna (typy, definicje, słowniki).

Przykład: dokument jest numerowany, ma datę wprowadzenia i zatwierdzenia, stany (bufor/zatwierdzony/odrzucony), jest powiązany z pracownikiem i przypisany do definicji dokumentu określającej zasady numeracji, tytuł, warunki akceptacji.

Na podstawie `references/tables.md`:
- odwołuj się do istniejących tabel po nazwach (kolumna „Tabela") i obiektach (kolumna „Obiekt"),
- wykorzystuj hierarchię nadrzędności (kolumna „Nadrzędny") jako wzorzec relacji inner,
- rozróżniaj tabele konfiguracyjne i operacyjne (kolumna „Konfiguracyjna") — ten sam podział stosuj w nowym module,
- identyfikuj istniejące słowniki i kartoteki zamiast tworzyć duplikaty.

### 3.2. Diagram relacji
Graficzne przedstawienie relacji (Mermaid lub tabela):
- Relacje 1:N (inner) — tabele szczegółów
- Relacje N:1 (lookup) — odwołania do słowników i kartotek
- Relacje do tabel spoza modułu (z nazwą modułu źródłowego, np. `Kontrahenci` z CRM, `Pracownicy` z Kadry — nazwy z `references/tables.md`)

### 3.3. Relacje do danych platformy
Dla każdej relacji do danych spoza modułu wskaż na podstawie `references/tables.md`:
- nazwę modułu platformy Soneta (np. Handel, Kadry, Ksiega, CRM, Towary, Kasa),
- konkretną tabelę i obiekt biznesowy (np. tabela `Kontrahenci`, obiekt `Kontrahent` z CRM),
- typ relacji (lookup, inner, powiązanie logiczne),
- cel użycia danych w kontekście projektowanego modułu.

### 3.4. Podstawowe listy modułu
Dla każdej listy:
- kolumny podstawowe i opcjonalne (dostępne w opcjach konfiguracyjnych),
- pola filtrujące (podstawowe i dodatkowe po rozwinięciu),
- filtry predefiniowane.

### 3.5. Formularze
Dla każdego formularza:
- zakładki i grupy na zakładkach,
- pola w każdej grupie,
- listy szczegółów (sublists).

### 3.6. Workery i czynności
- **Czynności na formularzach** — menu „Czynności" na obiektach (zatwierdzanie, anulowanie, kopiowanie, generowanie powiązanych dokumentów). Dla każdej: warunki dostępności (np. stan dokumentu), efekt, wymagane uprawnienia.
- **Czynności na listach** — operacje grupowe (zatwierdzanie wielu dokumentów, eksport, zbiorowe przypisanie).
- **Workery** — procesy w tle (przeliczenia, synchronizacja, raporty wsadowe). Wskaż wyzwalacze (ręczne/harmonogramowe/zdarzeniowe) i oczekiwane czasy.

### 3.7. Raporty i wydruki
- **Wydruki dokumentów** — format (PDF, Excel), szablon, dane.
- **Raporty zbiorcze** — parametry wejściowe (zakres dat, filtry), układ, grupowania.
- **Eksport danych** — formaty (Excel, CSV).

### 3.8. Procesy Workflow
Uszczegółowienie procesów z sekcji 1.6:
- **Stany obiektów** — lista stanów (np. Bufor → Zatwierdzony → W realizacji → Zakończony → Anulowany).
- **Przejścia** — warunki i reguły (kto zatwierdza, jakie warunki, czy odwracalne).
- **Automatyzacje** — akcje przy zmianie stanu (powiadomienie, zmiana pól, generowanie dokumentu).
- **Ścieżki akceptacji** — reguły eskalacji, jeśli proces wymaga akceptacji przełożonego.

### 3.9. Uprawnienia i role
- **Matryca uprawnień** — tabela ról (z sekcji 2.1) vs funkcjonalności:

| Funkcjonalność | Rola A | Rola B | Rola C |
|----------------|--------|--------|--------|
| Lista X — odczyt | Tak | Tak | Nie |
| Lista X — edycja | Tak | Nie | Nie |
| Czynność Y | Tak | Nie | Nie |

- **Uprawnienia do danych** — ograniczenia widoczności (operator widzi swoje dokumenty, kierownik — podwładnych).
- **Uprawnienia konfiguracyjne** — kto modyfikuje ustawienia, definicje, słowniki.

### 3.10. Integracje szczegółowe
Uszczegółowienie integracji z sekcji 2.5 i 2.6:
- **API i protokoły** — REST, SOAP, pliki CSV/XML, bezpośredni dostęp do bazy.
- **Formaty danych** — struktura komunikatów i plików, mapowanie pól.
- **Częstotliwość i tryb synchronizacji** — jednorazowy, cykliczny (harmonogram), w czasie rzeczywistym (zdarzeniowy).
- **Obsługa błędów** — niedostępność systemu zewnętrznego, walidacja danych wejściowych, logowanie błędów.

### 3.11. Scenariusze testowe
- **Testy funkcjonalne** — scenariusze pokrywające ścieżki z sekcji 1.5 (kroki, dane wejściowe, oczekiwany rezultat).
- **Testy integracyjne** — współpraca z innymi modułami Soneta i systemami zewnętrznymi.
- **Testy wydajnościowe** — weryfikacja założeń z sekcji 2.8 (wolumeny, czasy odpowiedzi).
- **Przypadki brzegowe** — puste dane, maksymalne wolumeny, równoczesna edycja, brak uprawnień.

### 3.12. Dane demonstracyjne
- Dane do bazy Demo — reprezentatywne scenariusze pokazujące możliwości modułu.
- Dane do testów — zestawy pokrywające przypadki typowe i brzegowe.

### 3.13. Słownik terminów
Definicje kluczowych terminów biznesowych i technicznych, szczególnie przy modułach domenowych (kontroling, logistyka), gdzie terminologia bywa niejednoznaczna lub branżowa.

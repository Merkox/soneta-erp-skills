# ETAP 1 — Wizja i kontekst biznesowy

Cel: ustalić **co** budujemy, **dla kogo** i **dlaczego**. Dokument tego etapu jest przeznaczony dla decydentów, marketingu i sprzedaży, dlatego operuje językiem korzyści i procesów, a nie szczegółów technicznych.

Poziom szczegółowości jest ogólny — chodzi o założenia, zakres i kluczowe elementy modułu. Szczegóły techniczne powstają w Etapie 2 i 3.

## Pytania do zadania użytkownikowi

Zacznij od ogólnej idei, potem doprecyzowuj. Zadawaj 2–4 pytania na raz i dostosowuj kolejne do odpowiedzi.

**Pierwsza tura — zrozumienie idei:**
- Co jest głównym celem modułu? Jaki problem rozwiązuje?
- Kto jest docelowym użytkownikiem? (mała/średnia/duża firma, branża)

**Druga tura — funkcjonalności i korzyści:**
- Jakie są najważniejsze funkcjonalności? (kluczowe vs opcjonalne)
- Jakie korzyści uzyska klient?

**Trzecia tura — kontekst i ograniczenia:**
- Jakie procesy biznesowe realizuje moduł?
- Czy są ograniczenia techniczne, prawne, licencyjne?
- Jakie moduły platformy Soneta będą wykorzystywane?

## Sekcje dokumentu Etapu 1

Wygeneruj dokument Markdown zawierający te sekcje:

### 1.1. Cel biznesowy projektu
4–5 zdań o celu projektu, kluczowym elemencie, najważniejszej rzeczy do osiągnięcia. Zacznij od podstawowej idei modułu — np. przygotowanie danych, które później będą wykorzystane do analizy innymi narzędziami.

### 1.2. Profil klienta docelowego
Typ firmy (mała/średnia/duża), branża, działalność.

### 1.3. Korzyści dla klienta
Najważniejsze korzyści, problemy rozwiązywane przez moduł. Informacja dla marketingu i sprzedaży, a także jako wprowadzenie do spotkań o module.

### 1.4. Najważniejsze funkcjonalności (priorytetyzacja)
Podział na:
- **Krytyczne (must-have)** — bez nich moduł nie ma sensu, sedno modułu. Wskaż, które elementy interfejsu i funkcjonalności są kluczowe dla sukcesu produktu.
- **Ważne (should-have)** — istotne, ale moduł może działać bez nich w v1.
- **Opcjonalne (nice-to-have)** — kolejne wersje.

Te funkcjonalności będą rozwijane w Etapie 2 (architektura) i Etapie 3 (specyfikacja szczegółowa, sekcje 3.1–3.13).

### 1.5. Scenariusze użytkownika
Kilka kluczowych scenariuszy krok po kroku — jakie działania podejmuje użytkownik, jakie dane wprowadza, jakie wyniki otrzymuje. Tylko najważniejsze dane, bez szczegółów.

### 1.6. Procesy biznesowe
Procesy realizowane w całości przez moduł oraz procesy, w których moduł uczestniczy częściowo (z innymi elementami platformy). Zdefiniowane procesy posłużą później do budowy procesów workflow i przypisania ich do operatorów i ról.

### 1.7. Ograniczenia modułu i wymagania licencyjne
Ograniczenia funkcjonalne, techniczne, integracyjne, prawne. Wymagane licencje platformy Soneta oraz ewentualne licencje zewnętrzne.

### 1.8. Założenia i zależności
- **Założenia** — co zakładamy jako pewne (np. dostępność modułów, wersja platformy, dostęp do API zewnętrznych systemów).
- **Zależności** — od czego projekt zależy (inne projekty, dane od klienta, dostępność zespołu).

### 1.9. Ryzyka projektu
Ryzyka techniczne, biznesowe, integracyjne — z prawdopodobieństwem, wpływem i planem mitygacji. Dla każdego ryzyka wskaż działanie zapobiegawcze.

### 1.10. Kryteria akceptacji
Mierzalne kryteria gotowości: funkcjonalne (scenariusze, które muszą działać), wydajnościowe (orientacyjne wolumeny, czasy odpowiedzi), jakościowe (pokrycie testami, brak błędów krytycznych).

### 1.11. Harmonogram i kamienie milowe
Ramowy harmonogram: fazy projektu (planowanie, MVP, testy, pilotaż, produkcja), kamienie milowe (zatwierdzenie specyfikacji, gotowość MVP, koniec testów integracyjnych, wdrożenie pilotażowe, wersja produkcyjna), zależności czasowe (powiązane z sekcją 1.8). Charakter orientacyjny — służy do ogólnego planowania zasobów.

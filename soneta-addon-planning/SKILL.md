---
name: soneta-addon-planning
description: >
  Planowanie projektów dodatków dla platformy Soneta (enova365, Triva). Tworzy
  kompletną dokumentację projektową obejmującą: strukturę danych (tabele, relacje),
  elementy konfigurowalne, definicje list i menu, formularze, workery i raporty.
  Używaj gdy użytkownik prosi o zaplanowanie nowego modułu/dodatku enova365,
  przygotowanie założeń projektu, stworzenie specyfikacji funkcjonalnej dodatku,
  lub zdefiniowanie struktury danych i interfejsu użytkownika dla nowego modułu.
---

# Planowanie projektu modułu/dodatku Soneta

Skill prowadzi **interaktywny** proces planowania nowego modułu dla platformy Soneta (programy enova365 i Triva — oparte na tej samej platformie technologicznej). Efektem jest dokumentacja projektowa, która w kolejnych krokach zasila skille `/soneta-business-xml` (model danych), `/soneta-form-xml` (formularze) i `/soneta-programming` (logika).

Proces składa się z trzech etapów o rosnącym poziomie szczegółowości. Ten plik jest mapą procesu — szczegółowe specyfikacje sekcji każdego etapu są w plikach `references/`, które czytasz dopiero, gdy dochodzisz do danego etapu.

| Etap | Zakres | Odbiorca | Szczegóły |
|------|--------|----------|-----------|
| **1. Wizja i kontekst biznesowy** | co, dla kogo, dlaczego | decydenci, marketing, sprzedaż | `references/etap-1-wizja.md` |
| **2. Architektura modułu** | jak — role, dane, UI, integracje | zespół projektowy | `references/etap-2-architektura.md` |
| **3. Specyfikacja szczegółowa** | szczegóły implementacyjne obiektów | zespół implementacyjny i AI | `references/etap-3-specyfikacja.md` |

Na końcu, po zamknięciu etapów, generujesz dokument **TODO** z kolejnymi krokami implementacji.

## Wymagania

Etap 1 (Wizja) nie ma zależności technicznych — prowadź go zawsze. Etapy 2–3 opierają się na inwentaryzacji modelu danych platformy narzędziem `scan-modules` (patrz sekcja „Dane referencyjne"), które wymaga:

- skompilowanych bibliotek platformy Soneta — katalog z plikami `*.dll` (u użytkownika zwykle `~/d/dev/bin/debug`),
- .NET SDK 10 oraz `dotnet-script` (`dotnet tool install -g dotnet-script`).

Gdy środowiska brak (np. planowanie koncepcyjne bez dostępu do buildu), wykonaj Etap 1 normalnie, a inwentaryzację danych zapisz jako **otwartą kwestię blokującą** dla Etapu 2 — nie zgaduj istniejących struktur.

## Jak prowadzić rozmowę

Proces jest interaktywny. **Nie generuj całego dokumentu naraz** — pracuj etap po etapie:

1. **Wczytaj etap** — gdy zaczynasz Etap N, przeczytaj `references/etap-N-*.md`. Plik zawiera pytania do zadania oraz szczegółową specyfikację sekcji tego etapu.
2. **Zbierz informacje** — zacznij od ogólnej idei modułu (co chce osiągnąć, dla kogo, jaki problem rozwiązuje), potem doprecyzowuj pytaniami z pliku etapu.
3. **Opracuj etap** — na podstawie odpowiedzi wygeneruj dokument etapu. Gdy czegoś brakuje, zadaj konkretne pytanie zamiast zgadywać (lub zapisz jako otwartą kwestię — patrz niżej).
4. **Poczekaj na zatwierdzenie** — przedstaw dokument i poczekaj na akceptację/uwagi. Nie przechodź dalej bez wyraźnej zgody.
5. **Iteruj i przejdź dalej** — po poprawkach i akceptacji przejdź do kolejnego etapu.

Prowadź rozmowę po polsku. Zadawaj pytania grupami tematycznymi (2–4 na raz) — nie zasypuj użytkownika listą 15 pytań naraz — i dostosowuj kolejne pytania do odpowiedzi.

## Zapis dokumentów

Każdy etap zapisz jako osobny plik Markdown w katalogu roboczym projektu (domyślnie podkatalog nazwany po module, np. `plan-<nazwa-modułu>/`), chyba że użytkownik wskaże inne miejsce:

- `etap-1-wizja.md`, `etap-2-architektura.md`, `etap-3-specyfikacja.md`
- `otwarte-kwestie.md` — prowadzona przez cały proces
- `todo.md` — na końcu

Przed utworzeniem katalogu upewnij się z użytkownikiem co do nazwy modułu i lokalizacji.

## Dane referencyjne — moduły i tabele platformy Soneta

Aby osadzić plan w istniejącym modelu danych, potrzebujesz aktualnej listy modułów i tabel platformy. **Nie używaj statycznych snapshotów** (starzeją się) — zinwentaryzuj strukturę na żywo z bibliotek narzędziem `scan-modules` ze skilla `/soneta-programming` (dokument `scan-modules.md`). Czyta metadane skompilowanych DLL-ek przez Roslyn, więc odzwierciedla dokładnie tę wersję platformy i dodatków, z którą pracuje użytkownik.

Uruchomienie (katalog z DLL-kami platformy — u użytkownika zwykle `~/d/dev/bin/debug`; jeśli nie znasz, zapytaj lub potraktuj jako otwartą kwestię):

```bash
dotnet script ~/.claude/skills/soneta-programming/scripts/scan-modules.csx -- <KatalogDll> > modules.md
```

Wynik zapisz do pliku roboczego (`modules.md`) i **czytaj selektywnie** — jest duży (kilkadziesiąt modułów, >1000 tabel). Namierzaj moduły przez `grep -n '^## ' modules.md`, potem czytaj tylko istotne sekcje. Kolumny wyniku:

| Kolumna | Znaczenie | Użycie w planie |
|---------|-----------|-----------------|
| `RowType` | klasa biznesowa (bez sufiksu `Row`) | obiekt, do którego się odwołujesz w kodzie/relacjach |
| `TableType` | nazwa tabeli (`Session.Tables.*`) | fizyczna tabela w bazie |
| `Guided` | `root` = korzeń drzewa obiektów; `child: Pole→TypRow` = tabela podrzędna; puste = subrow | wzorzec relacji nadrzędny-szczegółowy (inner) |
| `Konfig` | `konfig` = tabela konfiguracyjna | podział konfiguracyjne/operacyjne — stosuj ten sam w nowym module |
| `Interfaces` | relacje interfejsowe (`IXxx`) | punkty podpięcia do istniejących tabel |
| `Tytuł` / `Opis` | etykieta i przeznaczenie tabeli | zrozumienie, czy struktura pokrywa potrzebę |

Korzystaj z inwentaryzacji, aby:
- sprawdzić, czy potrzebne struktury już istnieją (unikanie duplikacji),
- wskazać konkretne `RowType`/`TableType`, do których nowy moduł będzie się odwoływać,
- rozpoznać wzorce projektowe (podział konfiguracyjne/operacyjne, korzenie `Guided` i datapacki, relacje interfejsowe),
- zidentyfikować moduły współpracujące.

Najbardziej przydaje się w **Etapie 2** (sekcje 2.3, 2.5) i **Etapie 3** (sekcje 3.1–3.3) — tam skanujesz DLL-ki i sięgasz do konkretnych modułów. Gdy użytkownik wspomni o integracji z istniejącymi danymi (pracownicy, kontrahenci, towary), zeskanuj strukturę i wskaż konkretne `RowType`/`TableType` po nazwach. Do drążenia pól wybranego rekordu użyj `scan-props` z tego samego skilla `/soneta-programming`.

## Otwarte kwestie

Otwarte kwestie to **jedno wspólne miejsce, w którym zbierane są wszystkie decyzje projektowe pozostające do podjęcia**. Dzięki niej użytkownik ma w każdym momencie jasny obraz tego, co blokuje przejście dalej. Prowadź tę listę przez cały proces — jest tak samo ważna jak same dokumenty etapów.

### Co trafia na listę

Dopisuj nową kwestię zawsze, gdy:
- pojawia się pytanie projektowe, na które nie znasz odpowiedzi — **zamiast zgadywać, zapisz je jako otwartą kwestię**,
- istnieje kilka alternatyw i wybór należy do użytkownika (np. wariant struktury danych, sposób integracji),
- brakuje informacji od osoby trzeciej (klient, inny zespół, dział prawny, licencjonowanie),
- decyzję świadomie odkładasz „na później", aby nie blokować bieżącego etapu,
- użytkownik mówi „zastanowię się", „dopytam", „nie wiem jeszcze" — to sygnał do założenia wpisu.

Nie zostawiaj nierozstrzygniętych założeń ukrytych w treści dokumentu — każde takie miejsce powinno mieć odpowiadający wpis na liście.

### Struktura tabeli

| Nr | Etap | Obszar | Kwestia | Wpływ | Blokująca | Status | Decyzja i uzasadnienie | Data |
|----|------|--------|---------|-------|-----------|--------|------------------------|------|
| 1 | 2 | Dane | [Opis problemu do rozstrzygnięcia] | Wysoki/Średni/Niski | Tak/Nie | Otwarta / W trakcie / Zamknięta | [Podjęta decyzja + dlaczego] | RRRR-MM-DD |

- **Obszar** — czego dotyczy (dane, UI, integracje, uprawnienia, wydajność, licencje, proces…).
- **Wpływ** — jak duże są konsekwencje decyzji dla projektu.
- **Blokująca** — czy kwestia uniemożliwia zatwierdzenie etapu lub rozpoczęcie implementacji.
- **Status** — cykl życia: *Otwarta* → *W trakcie* → *Zamknięta*.
- **Decyzja i uzasadnienie** — przy zamknięciu wpisz nie tylko *co* postanowiono, ale i *dlaczego*. Nigdy nie usuwaj zamkniętych kwestii — stanowią historię decyzji.

### Zasady prowadzenia

1. **Numeracja jest stała** — raz nadany numer nie zmienia się; zamknięte pozycje zostają na liście.
2. **Aktualizuj na bieżąco** — gdy zapadnie decyzja, od razu zmień status na *Zamknięta* i uzupełnij kolumnę decyzji.
3. **Prezentuj na końcu każdego etapu** — pokaż pełną listę i wyraźnie wskaż kwestie otwarte oraz **blokujące**.
4. **Bramka jakości** — nie przechodź do kolejnego etapu z otwartymi kwestiami *blokującymi* dla tego etapu. Kwestie nieblokujące można przenieść dalej, ale muszą pozostać widoczne.
5. **Powiązanie z TODO** — „Zamknięcie otwartych kwestii" jest pozycją TODO; do implementacji nie wchodzimy z otwartymi kwestiami blokującymi.

## Dokument TODO

Po zamknięciu wszystkich etapów wygeneruj dokument TODO z kolejnymi krokami:

### Uzupełnienie planu
- [ ] Weryfikacja i zatwierdzenie Etapu 1 przez interesariuszy
- [ ] Weryfikacja i zatwierdzenie Etapu 2 przez zespół projektowy
- [ ] Uzupełnienie specyfikacji szczegółowej (Etap 3) dla wszystkich obiektów
- [ ] Zamknięcie otwartych kwestii

### Implementacja
- [ ] Model danych — tabele, pola, relacje
- [ ] Plik business.xml (→ skill `/soneta-business-xml`)
- [ ] Struktura menu, listy, widoki
- [ ] Formularze i zakładki (→ skill `/soneta-form-xml`)
- [ ] Konfiguracja — słowniki, definicje, ustawienia
- [ ] Workery i czynności (→ skill `/soneta-programming`)
- [ ] Raporty i wydruki
- [ ] Procesy Workflow
- [ ] Wskaźniki i wykresy BI
- [ ] Uprawnienia i role
- [ ] Integracje z innymi systemami
- [ ] Baza Demo i dane demonstracyjne
- [ ] Testy integracyjne i interfejsowe
- [ ] Dokumentacja użytkownika i techniczna

## Powiązanie z innymi skillami

Już na etapie planowania (Etap 2 i 3) korzystasz z **`/soneta-programming`** — narzędzia `scan-modules` i `scan-props` inwentaryzują istniejący model danych platformy (patrz sekcja „Dane referencyjne").

Po zatwierdzeniu planu projektu:
1. **`/soneta-business-xml`** — generowanie pliku business.xml na podstawie modelu danych z Etapu 3 (sekcje 3.1–3.3).
2. **`/soneta-form-xml`** — generowanie formularzy i widoków UI na podstawie sekcji 3.4 i 3.5.
3. **`/soneta-programming`** — implementacja logiki biznesowej, workerów i czynności (sekcje 3.6, 3.8).

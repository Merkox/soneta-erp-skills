---
name: erp
description: >
  Mapa i przewodnik po skillach platformy Soneta (enova365, Triva): soneta:programming (ORM, kod
  biznesowy), soneta:addon-planning, soneta:business-xml, soneta:form-xml, soneta:repx (wydruki
  .repx), soneta:place-def-elementow, soneta:config (import/eksport XML, scan-folders,
  appsettings.json, rejestr konfiguracji *.reg.json), soneta:tools (dbmgr, buscall, SonetaFrame),
  soneta:containers (docker compose, Apple container, Helm/Kubernetes). Używaj gdy użytkownik: (1)
  rozpoczyna zadanie dla platformy Soneta i nie wiadomo, który skill wybrać; (2) pyta ogólnie o
  dodatki, moduły lub rozszerzenia Soneta ERP; (3) wspomina enova, Soneta Enterprise, Triva bez
  sprecyzowania warstwy (dane, UI, logika, płace); (4) chce poznać dostępne skille; (5) realizuje
  zadanie obejmujące wiele warstw platformy; (6) pracuje nad kodem samej platformy w repozytorium
  źródłowym Soneta (`Soneta.*`, moduły standardowe) — skille opisują publiczną
  bibliotekę platformy i obowiązują tak samo dla dodatków partnerów i kodu zespołu Soneta.
---

# Mapa skilli platformy Soneta (enova365, Triva)

Skille dokumentują publiczną bibliotekę platformy. Stosuj je przy tworzeniu kodu zarówno
dodatków partnerów, jak i modułów standardowych w repozytorium źródłowym Soneta. W obu
przypadkach obowiązują te same wzorce, checklisty i
[zasady bezpiecznego kodu](../programming/references/safe-code.md).

Wybierz skill według zadania i przeczytaj jego `SKILL.md`, a następnie tylko referencje
potrzebne do pracy. Przy zadaniu obejmującym kilka warstw korzystaj z kilku skilli.

| Zadanie | Skill |
|---|---|
| Plan nowego dodatku: wizja, architektura, specyfikacja i TODO | [addon-planning](../addon-planning/SKILL.md) |
| Model danych: tabele, kolumny, relacje, indeksy i pliki `business.xml` | [business-xml](../business-xml/SKILL.md) |
| Kod C#, ORM (`Row`, `Table`, `Module`), sesje, transakcje, workery, testy i szkielet dodatku; inwentaryzacja DLL | [programming](../programming/SKILL.md) |
| Formularze i listy `form.xml`, `pageform.xml`, `viewform.xml`, lookupy, wiązanie danych i widoczność | [form-xml](../form-xml/SKILL.md) |
| Wydruki DevExpress `.repx`: pasma, źródła danych, wiązania, podraporty, snippet i rejestracja | [repx](../repx/SKILL.md) |
| Wygląd aplikacji webowej w stylu Soneta: kolory, typografia, komponenty, ikony i motywy | [ui-style](../ui-style/SKILL.md) |
| Definicje elementów wynagrodzenia, kreator i kod C# algorytmów płacowych | [place-def-elementow](../place-def-elementow/SKILL.md) |
| Import/eksport XML, `appsettings.json`, rejestr konfiguracji `*.reg.json`, menu (`scan-folders`) | [config](../config/SKILL.md) |
| Bazy z CLI (`dbmgr`), sterowanie aplikacją i zrzuty (`buscall`), uruchamianie ramki (`SonetaFrame`) | [tools](../tools/SKILL.md) |
| Uruchomienie gotowego produktu: Docker Compose, Apple container, Helm/Kubernetes i wersje obrazów | [containers](../containers/SKILL.md) |

## Łączenie warstw

- Nowy dodatek: plan → model `business.xml` → kod i testy → formularze → weryfikacja w aplikacji.
- Formularz `form.xml` opisuje UI; kod jego `ViewInfo`, workera i kontekstu opisuje `programming`.
- Wydruk i `ReportSnippet` opisuje `repx`; logikę ORM dostarczającą dane — `programming`,
  a formularz parametrów — `form-xml`.
- XML importuje wskazane rekordy; rejestr konfiguracji porównuje i przenosi stan konfiguracji.
  Oba formaty opisuje `config`, kod `SessionReader`/`SessionWriter` — `programming`.
- `containers` opisuje uruchomienie i wdrożenie; składnię operacji na bazie przez `dbmgr` — `tools`.

## Korzystanie w różnych środowiskach agenta

Linki do plików są właściwym sposobem przechodzenia między skillami; użycie konkretnej
komendy aktywującej skill nie jest wymagane. Jeśli środowisko ma mechanizm ładowania skilli,
możesz go użyć. W przeciwnym razie przeczytaj wskazany plik dostępnym narzędziem odczytu.
Gdy celu linku brakuje, sprawdź dostępne skille po polu `name`; jeśli nadal go nie ma,
wskaż brakujący materiał i kontynuuj część zadania, która od niego nie zależy.

Linki rozwiązuj względem pliku, w którym występują. Ścieżki `scripts/`, `assets/` i `data/`
w przykładach poleceń odnoszą się do katalogu danego skilla, a pliki wynikowe do ustalonego
katalogu projektu. Ustal rzeczywistą lokalizację skilla zamiast zakładać katalog instalacji
konkretnego asystenta. Składnię powłoki i narzędzia odczytu, wyszukiwania oraz MCP dopasuj
do dostępnego środowiska; brak narzędzia opisz jako ograniczenie wykonania lub weryfikacji.

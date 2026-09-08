---
name: erp
description: >
  Mapa skilli platformy Soneta (enova365, enova, Soneta Enterprise, Triva). Używaj przy rozpoczynaniu zadania,
  gdy nie wiadomo, który skill wybrać, przy pytaniach o dostępne skille oraz przy
  zadaniach obejmujących kilka warstw: planowanie dodatku, model danych, kod ORM,
  formularze, wydruki, styl UI, płace, konfigurację, narzędzia CLI lub kontenery.
---

# Mapa skilli platformy Soneta (enova365, Triva)

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

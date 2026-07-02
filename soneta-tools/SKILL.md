---
name: soneta-tools
description: >
  Narzędzia deweloperskie wiersza poleceń używane w Soneta do programowania i
  zarządzania platformą (enova365, Triva). Używaj gdy użytkownik: (1) zarządza
  bazami danych przez `dbmgr` — tworzy, rejestruje, konwertuje, robi backup/restore,
  nakłada licencje, dodaje rozszerzenia (extensions), analizuje lub kompiluje bazę;
  (2) chce przygotować bazę testową/demo z wiersza poleceń albo zautomatyzować
  operacje na bazach w skrypcie/CI; (3) testuje działającą aplikację przez `buscall`
  — zdalnie steruje programem (nawigacja, formularze, gridy, edycja) i robi zrzuty
  ekranu do analizy wizualnej; (4) pyta o składnię, komendy lub opcje narzędzi CLI
  Soneta (`dbmgr`, `buscall`, `callmcp`); (5) wspomina „narzędzia Soneta",
  „zarządzanie bazą enova", „utwórz bazę demo", „konwersja bazy", „backup bazy",
  „testowanie na żywej aplikacji". Sięgnij też, gdy inny skill potrzebuje operacji
  na bazie lub weryfikacji zmian na uruchomionej aplikacji.
---

# Soneta Tools — narzędzia deweloperskie CLI

Skill dokumentuje **narzędzia wiersza poleceń** stosowane w Soneta do programowania
i zarządzania platformą (enova365, Triva). Każde narzędzie ma własny, dokładny
reference oparty na rzeczywistym interfejsie (`--help` + kod źródłowy).

## Mapa skilla — które narzędzie do czego

Każde narzędzie ma **referencję funkcji/parametrów** oraz osobny dokument o **konkretnym zastosowaniu**.

| Narzędzie | Dokument | Rodzaj | Co zawiera |
|---|---|---|---|
| **`dbmgr`** | [references/dbmgr.md](references/dbmgr.md) | referencja | Zarządzanie **bazami danych** z CLI: tworzenie/rejestracja/kasowanie, konwersja, backup/restore (`.bac`/`.zip`), licencje i klucz wirtualny, rozszerzenia, import XML, analiza, kompilacja. Wszystkie komendy i opcje. |
| **`dbmgr`** | [references/dbmgr-cli-menu.md](references/dbmgr-cli-menu.md) + [assets/dbmgr-menu.cs](assets/dbmgr-menu.cs) | zastosowanie | Wzorzec + gotowy szablon: owinięcie `dbmgr` w interaktywne menu CLI (Spectre.Console) na jednoplikowej aplikacji C# — wybór bazy z listy, tryby środowisk, gotowe akcje. |
| **`buscall`** | [references/buscall.md](references/buscall.md) | referencja | Zdalne wywoływanie metod aplikacji: tryby `call`/`callmcp`, składnia argumentów `klucz=wartość`, odkrywanie metod (`methods.list`), katalog metod Bundle (nawigacja, formularze, gridy, zrzuty), kody wyjścia. |
| **`buscall`** | [references/buscall-live-testing.md](references/buscall-live-testing.md) | zastosowanie | Wizualna **weryfikacja kodu na żywej aplikacji**: baza startująca z Twojego kodu, przeładowanie DLL, pułapki osieroconych procesów/portów, zrzuty ekranu do oceny wyglądu formularzy. |

## Wspólny kontekst

- **Binaria** znajdują się w katalogu wyjściowym buildu (`bin/Debug`) odpowiedniego projektu.
  Dokładna ścieżka zależy od Twojego układu repozytoriów — w przykładach piszemy krótko
  `dbmgr` / `buscall`, zakładając alias, wpis w `PATH` albo uruchamianie z katalogu buildu:
  - `dbmgr` → `dbmgr.exe` (Windows) lub `dotnet dbmgr.dll` (cross-platform),
  - `buscall` → `buscall` lub `dotnet BusCall.dll` (katalog buildu projektu BusCall).
- **Nazwa bazy** w obu narzędziach (`--db <Baza>` w `buscall`, `<database_name>` w `dbmgr`)
  odwołuje się do **wpisu w konfiguracji** (SonetaFrame / plik konfiguracji baz), a nie
  bezpośrednio do fizycznej nazwy bazy SQL. Szczegóły w referencjach.
- **Platforma .NET 10**, narzędzia działają cross-platform (macOS/Windows/Linux).

## Jak wybrać

- Operujesz **na strukturze/danych bazy** (utwórz, skonwertuj, backup, licencja, extension)
  → **`dbmgr`** ([references/dbmgr.md](references/dbmgr.md)).
- Chcesz **zweryfikować zachowanie kodu na uruchomionej aplikacji** (kliknięcia, formularze,
  zrzut ekranu) → **`buscall`** — składnia i metody w [references/buscall.md](references/buscall.md),
  a przepływ weryfikacji na żywo w [references/buscall-live-testing.md](references/buscall-live-testing.md).

## Powiązane skille

- **`/soneta-programming`** — warstwa ORM i kod biznesowy; `buscall` służy do weryfikacji
  napisanego tam kodu na żywej aplikacji.
- **`/soneta-erp`** — meta-skill z mapą wszystkich skilli platformy Soneta.

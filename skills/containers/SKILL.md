---
name: containers
description: >
  Kontenery Soneta (enova365, Triva). Używaj do uruchamiania i wdrażania server + web przez
  Docker Compose (`docker-compose.yaml`), Apple `container` / Container Desktop (`x-init`) lub
  Helm/Kubernetes (`helm repo add soneta`, `values.yaml`, `dblist`, `adminMode`); tworzenia baz
  w kontenerze (usługa init, `dbmgr create`, `--demo`, `--recreate`) oraz obsługi licencji i
  konwersji; wyboru obrazów (`soneta/*`, `server.standard`, `web.standard`) i tagów z Docker Hub
  lub `registry.soneta.pl`, wariantu alpine, architektury arm64/amd64 i logowania do registry;
  konfiguracji SQL Servera zewnętrznego (`host.docker.internal`, `host.containers.internal`) lub
  kontenera `mssql`. Pomaga diagnozować start usług, kolejność, zajęte porty, DNS między
  usługami Apple container i błędne host-aliasy.
---

# Soneta w kontenerach — uruchamianie i wdrażanie (enova365, Triva)

Skill dla **partnera**, który ma postawić i utrzymać środowisko Soneta w kontenerach
oraz założyć i zarządzać bazą — **bez dostępu do kodu programu**. Trzy ścieżki, wspólne
pojęcia. Składnię komend `dbmgr` opisuje `/soneta:tools` (nie duplikujemy jej tutaj).

## Którą ścieżką

| Ścieżka | Kiedy | Reference |
|---|---|---|
| **Docker Compose** | Domyślnie: lokalne środowisko test/demo, CI, jeden host. | [references/docker-compose.md](references/docker-compose.md) |
| **Apple `container` / Container Desktop** | macOS na Apple Silicon; wklejasz ten sam YAML do GUI. | [references/apple-container.md](references/apple-container.md) |
| **Helm / Kubernetes** | Wdrożenie na klaster (beta). | [references/helm-k8s.md](references/helm-k8s.md) |
| **Wybór wersji obrazów** | Zawsze — wspólne dla wszystkich ścieżek. | [references/obrazy-wersje.md](references/obrazy-wersje.md) |

## Wspólne pojęcia (dotyczą każdej ścieżki)

- **Obrazy:** `soneta/server.standard` (logika + serwer, ma w środku `dbmgr.dll`) oraz
  `soneta/web.standard` (aplikacja webowa). Rzadziej `web.api`, `web.wcf`.
- **Wersja = tag**, zawsze podawany jawnie (brak `latest`/`stable`). Docker Hub:
  `XXXX.X.X-alpine`; registry.soneta.pl (login): buildy alfa. Patrz `obrazy-wersje.md`.
- **SQL Server:** zewnętrzny (host lub osobny kontener) albo `mssql` w tym samym compose.
  Adres hosta: Docker → `host.docker.internal`, Apple container → `host.containers.internal`.
- **Baza powstaje raz** przez `dbmgr create <db> --mssql --sqlserver <host,port> --sqldb
  <db> --sqluser sa --sqlpwd <hasło> --demo gold --active --recreate` — jako usługa init
  reużywająca obrazu `server.standard`.
- **Licencja / dane:** `--demo silver|gold|platinum` (dane demo + licencja) lub `--licence`.

## Szybki start (Docker)

```bash
# 1. Skopiuj gotowy plik i podmień: tag wersji, hasło SA, host SQL.
cp assets/docker-compose.yaml ./docker-compose.yaml
# 2. Wystartuj (dbinit założy bazę, potem server, potem web):
docker compose up -d
# 3. Web: http://localhost:60000    Logi: docker compose logs -f
```

**Logowanie do web:** operatorem bazy demo (domyślny administrator). Hasło administratora
ustawisz przy tworzeniu (`dbmgr create --adminpwd`) albo zresetujesz później
(`dbmgr resetadminpwd`) — składnia w `/soneta:tools`.

**macOS / Container Desktop:** wklej **plik z kroku 1** (SQL zewnętrzny) do okna „Uruchom
Docker Compose", zmieniając host-alias (`host.docker.internal` → `host.containers.internal`) —
patrz [references/apple-container.md](references/apple-container.md). Wariantu z kontenerem
SQL (`docker-compose.mssql.yaml`) tam **nie używaj** (`x-init` nie doczeka się SQL).

Samowystarczalny wariant z kontenerem SQL (tylko Docker): `assets/docker-compose.mssql.yaml`.

## Checklisty

**Przed startem:** silnik działa (`docker`/`container`) · wybrany tag wersji · dostępny
SQL + znane hasło SA · wolne porty (np. 60000, 1433).

**Po starcie:** `dbinit` zakończony sukcesem (baza założona) · `server` wstał · `web`
odpowiada na porcie · nałożona licencja / dane `--demo`.

**Gdy nie działa:** port zajęty (zmień mapowanie) · zły host-alias (Docker vs Apple) ·
w Apple container brak DNS między usługami → wpisy `/etc/hosts` (robi to Container
Desktop) · `x-init` nie może zależeć od zwykłej usługi · brak `build:` w Apple container.

## Powiązane skille

- **`/soneta:tools`** — pełna składnia `dbmgr` (create/convert/backup/restore/licence/
  extensions) oraz źródło baz `docker:` w `SonetaFrame`. Tu tylko wołamy `dbmgr` w kontenerze.
- **`/soneta:config`** — znaczenie kluczy `appsettings.json`, domyślne porty i warstwy
  nadpisań przez zmienne `SONETA_...`
  ([appsettings.md](../config/references/appsettings.md)); import/eksport XML (role,
  uprawnienia, ustawienia) do bazy założonej w kontenerze.
- **`/soneta:programming`**, **`/soneta:addon-planning`** — kod i planowanie dodatku, który
  potem uruchomisz w tym środowisku.
- **`/soneta:erp`** — mapa wszystkich skilli platformy.

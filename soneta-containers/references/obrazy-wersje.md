# Obrazy i wybór wersji (wspólne dla wszystkich ścieżek)

Każda ścieżka (Docker, Apple container, Helm) potrzebuje **jawnego tagu wersji** — nie ma
`latest`/`stable`. Ten dokument mówi, jakie są obrazy, skąd je brać i jak dobrać tag.

## Obrazy

| Obraz | Rola |
|---|---|
| `soneta/server.standard` | logika biznesowa + serwer; **zawiera `dbmgr.dll`** (stąd usługa `dbinit`) |
| `soneta/web.standard` | aplikacja webowa |
| `soneta/web.api` | API (starszy) |
| `soneta/web.wcf` | web WCF (starszy) |

## Dwa źródła obrazów

- **Docker Hub `soneta/*`** — publiczne, główne źródło dla partnerów, bez logowania.
  Tagi **wydań** i **bet** (np. `...-beta.NNNNNN-alpine`).
- **`registry.soneta.pl/soneta/*`** — prywatne (wymaga logowania). Buildy **alfa** i
  wewnętrzne, z jawną architekturą w tagu.

## Schemat tagów

- **Docker Hub:** `XXXX.X.X-alpine` (Linux, **multi-arch** arm64/amd64 pod jednym tagiem)
  oraz `XXXX.X.X-windowsservercoreltsc2022` (Windows). Przykłady:
  `2606.0.1-alpine`, `2512.10.12-alpine`.
- **registry.soneta.pl:** buildy alfa z jawną architekturą, np.
  `2610.0.0-alfa.223483-alpine-arm64`.

`XXXX` to wersja główna (rok/wydanie), kolejne człony to numeracja poprawek.

## Listowanie dostępnych tagów

```bash
# Docker Hub (publiczne, bez logowania) — nazwy tagów jako JSON:
curl -s "https://hub.docker.com/v2/repositories/soneta/server.standard/tags?page_size=50&ordering=last_updated" \
  | grep -o '"name":"[^"]*"'

# registry.soneta.pl (prywatne) — najpierw logowanie:
docker login registry.soneta.pl                 # Docker
container registry login registry.soneta.pl     # Apple container
```

## Gdzie podstawić wybraną wersję

- **Docker / Apple container:** pole `image:` każdej usługi (`dbinit`, `server`, `web`) —
  ten **sam** tag we wszystkich. Publiczny: `soneta/server.standard:<tag>`; prywatny:
  `registry.soneta.pl/soneta/server.standard:<tag>`.
- **Helm:** `image.tag` + `image.serverTagPostfix`/`webTagPostfix` (np. `-alpine`);
  `image.repository` puste = Docker Hub `soneta/*`.

## Dobór wariantu

- **macOS Apple Silicon / Linux arm64** → `-alpine` (multi-arch obejmuje arm64).
- **Linux amd64** → `-alpine` (obejmuje też amd64).
- **Windows** → `-windowsservercoreltsc2022`.
- **Prywatny registry** gdy potrzebujesz buildu **alfa** (jawny `-arch` w tagu).

## Checklista

- [ ] wybrane źródło (Docker Hub publiczny vs registry.soneta.pl prywatny)
- [ ] zalogowano do prywatnego registry (jeśli używane)
- [ ] wybrany tag istnieje (sprawdzony przez listowanie)
- [ ] ten sam tag w `dbinit`/`server`/`web` (lub `image.tag` w Helm)
- [ ] wariant zgodny z architekturą hosta

Powiązane: [docker-compose.md](docker-compose.md) · [apple-container.md](apple-container.md) ·
[helm-k8s.md](helm-k8s.md).

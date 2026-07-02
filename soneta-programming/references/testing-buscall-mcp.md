# Testowanie aplikacji na żywo przez MCP `soneta_ui` (buscall)

Sprawdzony sposób end-to-end na **uruchomienie działającej aplikacji Soneta/enova365 i sterowanie
nią zdalnie** (nawigacja, otwieranie formularzy, odczyt gridów, edycja pól, **zrzuty ekranu**).
Idealny do weryfikacji zmian w kodzie biznesowym/UI na realnej bazie **bez** klikania ręcznego.

Wszystko poniżej zostało zweryfikowane w działaniu (baza Demo, formularz towaru, zakładka
„Cennik/Kontrahentów", metody `get_grid_rows` i `take_screenshot`).

## Wymaganie wstępne (jednorazowa konfiguracja)

Parametr `--db Demo` przekazywany do `buscall` odwołuje się do bazy o nazwie **`Demo`
zdefiniowanej wcześniej w aplikacji `SonetaFrame`**. Ta konfiguracja bazy musi być ustawiona tak,
aby **startowała z kodów źródłowych bieżącego projektu** (biblioteki z `~/d/dev/bin/Debug`). Bez tego
`buscall --db Demo mcp` albo nie znajdzie bazy, albo uruchomi frame na innym (nieaktualnym) kodzie.

Innymi słowy: nazwa po `--db` = nazwa połączenia bazy w SonetaFrame, a to połączenie decyduje, skąd
ładowany jest kod. Jeśli testujesz inny projekt/bazę, zdefiniuj analogiczne połączenie i podaj jego
nazwę w `--db`.

### Gdzie jest definicja bazy
Konfiguracja połączeń SonetaFrame (macOS):
`~/Library/Application Support/Soneta.Frame/Settings_Standard.json`, tablica **`Sources`**. Każdy wpis
to string z parametrami rozdzielonymi `;`. Przykład bazy `Demo` startującej kod z bieżącego projektu:

```json
"Sources": [
  "process:Demo;caption=dev;path=~/d/dev;user=Administrator;pwd="
]
```

Znaczenie pól:
- `process:Demo` — tryb `process` + **nazwa bazy** `Demo` (to jest wartość podawana w `buscall --db Demo`),
- `caption=dev` — etykieta połączenia w UI,
- `path=~/d/dev` — **katalog projektu, z którego ładowany jest kod** (biblioteki z `~/d/dev/bin/Debug`),
- `user` / `pwd` — poświadczenia logowania (tu operator `Administrator`, puste hasło).

Aby przetestować inny projekt: dodaj analogiczny wpis w `Sources` z własną nazwą bazy i `path`,
po czym wywołaj `buscall --db <nazwa> mcp`. Dodatkowo `IsDeveloperMode: true` w tym samym pliku
włącza tryb dewelopera.

## Architektura

```
klient MCP (stdio, JSON-RPC)
   │  spawn: buscall --db Demo mcp
   ▼
buscall  ── named pipe "SonetaFrameBridge" ──►  SonetaFrameNew (GUI)
(most MCP)                                        └── ładuje Soneta.*.dll z ~/d/dev/bin/Debug
```

- **MCP server** `soneta_ui` = proces **stdio**:
  `~/d/SonetaFrameNew/BusCall/bin/Debug/net10.0/buscall --db Demo mcp`
  (konfiguracja klienta: `~/Soneta/Db/Demo/.mcp.json`).
- `buscall` **tylko mostuje** wywołania przez named pipe do GUI **`SonetaFrameNew`**. To **frame**
  wykonuje metody (warstwa Bundle) i **ładuje biblioteki z `~/d/dev/bin/Debug`** (build z `~/d/dev`).
- Jeśli frame nie działa, `buscall` **sam go uruchamia** przy pierwszym wywołaniu narzędzia.

### Aby frame miał NOWY kod
1. Przebuduj DLL w dev:
   `dotnet build ~/d/dev/Soneta.Net.Business/Soneta.Net.Business.csproj` (lub właściwy projekt).
2. Upewnij się, że **nie działa stary frame** — inaczej podłączysz się do niego z poprzednim kodem:
   `ps ax | grep SonetaFrameNew | grep -v grep` → jeśli jest, zabij (`kill <pid>`).
3. Pierwsze wywołanie MCP uruchomi świeży frame z nowym DLL.

### Cache listy metod (ważne)
`buscall` cache'uje listę metod. **Pierwszy `tools/list` tuż po `initialize` zwraca starą/wstępną
listę** (frame startuje asynchronicznie). Dopiero **pierwsze realne wywołanie narzędzia** rozgrzewa
frame i odświeża cache, po czym `buscall` wysyła `notifications/tools/list_changed` (zadeklarowana
capability `tools.listChanged`). Weryfikując nową metodę w schemacie: najpierw wywołaj cokolwiek
(np. `navigate_to_folder`), potem `tools/list`.

## Kluczowe narzędzia (metody Bundle)

| Narzędzie | Do czego |
|---|---|
| `navigate_to_folder` | przejście do foldera programu, np. `{"programFolderPath":"Handel/Kartoteki/Towary i usługi"}` |
| `retrieve_list` | odczyt danych listy (stronicowane); zwraca `data.rows[{objectID,values}]` i oznacza wiersze jako „odwiedzone" (wymagane przez `open_form`) |
| `open_form` | otwarcie formularza obiektu: `{"tableName":"Towary","objectID":<id>}` |
| `search_object` | otwarcie formularza po warunku: `{"tableName":"...","objectSelector":"Kod=..."}` |
| `switch_form_page` | zmiana zakładki: `{"pageID":"TowarCennikKontrahentowPage"}` |
| `get_grid_rows` | pełny grid z formularza + filtr regex: `{"gridPath":"...","regexFilter":"...","regexOptions":"IgnoreCase"}` |
| `update_field_value` | zmiana pól: `{"fieldsValues":["Nazwa=Buciki"]}` |
| `edit_grid_rows` | edycja/dodanie/usunięcie wierszy grida in-place |
| `take_screenshot` | **zrzut ekranu bieżącego okna** (patrz niżej) |

Grid w danych formularza jest domyślnie **obcinany do kilku wierszy** (`data.truncated=true`); pełną
zawartość pobiera `get_grid_rows`.

## Zrzuty ekranu — analiza wizualna okien/formularzy

`take_screenshot` (bez parametrów) robi zrzut **bieżącego widoku** aplikacji — tego miejsca, w którym
jest teraz otwarta baza. Zapisuje go do pliku PNG w katalogu tymczasowym i zwraca **jeden blok `text`
ze ścieżką** do tego pliku (`/var/folders/.../T/soneta-screenshots/screenshot-<data>.png`). Obrazu nie
zwraca inline — modelowi wystarcza ścieżka. Pliki są efemeryczne: `buscall` czyści katalog przy starcie
i zamknięciu procesu.

Otwórz plik z podanej ścieżki i **obejrzyj go** (narzędziem czytającym obrazy) — pozwala wizualnie
zweryfikować layout formularza, wartości pól, widoczność kontrolek, motyw itp.
Wymaga prawa `Zrzuty ekranu` (`BundleRights.Screenshots`) w roli operatora.

## Minimalny klient stdio (skopiuj i uruchom)

Nie trzeba podłączać MCP do sesji — wystarczy sterować `buscall` po stdio (JSON-RPC, komunikaty
rozdzielane znakiem nowej linii). Handshake: `initialize` → `notifications/initialized` → `tools/call`.

```python
#!/usr/bin/env python3
import json, subprocess, threading, time, queue
BUSCALL = "/Users/marcin/d/SonetaFrameNew/BusCall/bin/Debug/net10.0/buscall"
CWD = "/Users/marcin/Soneta/Db/Demo"
p = subprocess.Popen([BUSCALL,"--db","Demo","mcp"], cwd=CWD,
    stdin=subprocess.PIPE, stdout=subprocess.PIPE, stderr=subprocess.DEVNULL, text=True, bufsize=1)
q=queue.Queue()
threading.Thread(target=lambda:[q.put(l.rstrip("\n")) for l in p.stdout] or q.put(None), daemon=True).start()
_id=0
def send(m,par=None,notif=False):
    global _id; msg={"jsonrpc":"2.0","method":m}
    if par is not None: msg["params"]=par
    if not notif: _id+=1; msg["id"]=_id
    p.stdin.write(json.dumps(msg)+"\n"); p.stdin.flush(); return None if notif else _id
def wait(tid,to=180):
    end=time.time()+to
    while time.time()<end:
        try: line=q.get(timeout=end-time.time())
        except queue.Empty: break
        if line is None: raise RuntimeError("closed")
        if not line.strip(): continue
        try: msg=json.loads(line)
        except: continue
        if msg.get("id")==tid and ("result" in msg or "error" in msg): return msg
    raise TimeoutError(tid)
def call(name,args,to=180):
    r=wait(send("tools/call",{"name":name,"arguments":args}),to)
    if "error" in r: return {"__error__":r["error"]}
    c=r["result"].get("content",[]); txt=next((b.get("text") for b in c if b.get("type")=="text"),None)
    try: return json.loads(txt) if txt else {}
    except: return {"__raw__":txt}

wait(send("initialize",{"protocolVersion":"2024-11-05","capabilities":{},"clientInfo":{"name":"drv","version":"0"}}))
send("notifications/initialized",{},notif=True)

call("navigate_to_folder",{"programFolderPath":"Handel/Kartoteki/Towary i usługi"})
lst=call("retrieve_list",{})
rid=next(r["objectID"] for r in lst["data"]["rows"] if any(isinstance(v,str) and "BUT_NAR_43" in v for v in r["values"]))
call("open_form",{"tableName":"Towary","objectID":rid})
call("switch_form_page",{"pageID":"TowarCennikKontrahentowPage"})

# pełny grid + filtr
full=call("get_grid_rows",{"gridPath":"new TowarCennikKontrahentowExtender.CennikKontrahentow()"})
print("rows:", len(full["grid"]["data"]["rows"]), "truncated:", full["grid"]["data"]["truncated"])

# zrzut ekranu bieżącego widoku -> zwraca ścieżkę do pliku PNG (otwórz go i obejrzyj)
shot=call("take_screenshot",{})
print("screenshot:", shot.get("__raw__", shot))   # tekst: "Zrzut ekranu zapisano do pliku PNG:\n/var/.../screenshot-<data>.png"
p.terminate()
```

Uwagi praktyczne:
- Pierwsze wywołanie po starcie bywa wolne (uruchomienie/logowanie frame'a) — dawaj timeout ~120–180 s.
- `retrieve_list` **musi** poprzedzać `open_form` (oznacza wiersze jako odwiedzone — inaczej „unsafe open").
- Wynik metody błędnej (np. złe `regexOptions`, brak prawa) wraca jako `{"kind":"error","error":"..."}`.
- Frame zostaje uruchomiony po teście — kolejne wywołania podłączą się do niego przez pipe
  (bez mnożenia procesów). Jeśli chcesz przeładować kod, zabij `SonetaFrameNew` przed kolejną turą.

## Weryfikacja jednostkowa tej samej warstwy
Metody Bundle mają też testy NUnit w projekcie `Soneta.Net.Test` (klasa `BundleTest`,
`namespace Soneta.Net.Test.Bundles`). Uruchamianie:
`dotnet test --project Soneta.Net.Test/Soneta.Net.Test.csproj --filter "FullyQualifiedName~BundleTest.<Nazwa>"`.
Wzorzec: `NavigateFolder` → `MarkVisited` → `HandleBundle<T>(nameof(...), new {...})`.
```

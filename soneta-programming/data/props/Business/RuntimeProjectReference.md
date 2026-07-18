# Pola i właściwości klasy biznesowej: `Soneta.Business.Compiler.RuntimeProjectReference`
Nazwa tabeli: `RuntimeProjRef`
Tytuł: Zależności projektów
Opis: Zależność projektu runtime od biblioteki lub innego projektu. Określa typ referencji i nazwę zależności wymaganej do kompilacji.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `RuntimeProject` → `RuntimeProject`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Reference | `string` | bazodanowe | Zależność |  |
| ReferenceType | `Compiler.ProjectReferenceType` (enum) | bazodanowe | Typ zależności |  |
| RoslynProjectReference | `Compiler.RuntimeProject` |  |  |  |
| RuntimeProject | `Compiler.RuntimeProject` | bazodanowe, tylko-odczyt, guided-parent | Projekt |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProjectReferenceType (`Compiler.ProjectReferenceType`)
- `RoslynProjectReference` = 10

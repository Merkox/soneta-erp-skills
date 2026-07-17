# Pola i właściwości klasy biznesowej: `Soneta.Business.Compiler.RuntimeProjectReference`
Nazwa tabeli: `RuntimeProjRef`
Tytuł: Zależności projektów
Opis: Zależność projektu runtime od biblioteki lub innego projektu. Określa typ referencji i nazwę zależności wymaganej do kompilacji.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `RuntimeProject` → `RuntimeProject`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Reference | `string` | bazodanowe | Zależność |  |
| ReferenceType | `Soneta.Business.Compiler.ProjectReferenceType` | bazodanowe, enum | Typ zależności |  |
| RoslynProjectReference | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| RuntimeProject | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe, guided-parent | Projekt |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProjectReferenceType (`Soneta.Business.Compiler.ProjectReferenceType`)
- `RoslynProjectReference` = 10

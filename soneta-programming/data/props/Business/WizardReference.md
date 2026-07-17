# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Wizard.WizardReference`
Nazwa tabeli: `WizardReferences`
Tytuł: Powiązania kreatorów
Opis: Powiązanie kreatora z obiektem biznesowym lub definicją zadania. Określa priorytet, tryb uruchamiania i ustawienia zachowania kreatora w kontekście obiektu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Host` → `IWizardReferenceHost`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Business.IWizardReferenceHost` | bazodanowe, guided-parent, iface-ref | Kreator dla |  |
| Identifier | `string` |  |  |  |
| Priority | `int` | bazodanowe |  |  |
| RefGuid | `System.Guid` | bazodanowe |  |  |
| Settings | `Soneta.Business.Db.Wizard.WizardReferenceSettings` | bazodanowe |  |  |
| Settings.Added | `bool` | bazodanowe |  |  |
| Settings.Code | `string` | bazodanowe |  |  |
| Settings.Edited | `bool` | bazodanowe |  |  |
| Settings.FirstTaskUser | `bool` | bazodanowe |  |  |
| Settings.ForApplication | `bool` |  |  |  |
| Settings.ForMobile | `bool` |  |  |  |
| Settings.ForWebUser | `bool` |  |  |  |
| Settings.Layout | `Soneta.Business.Db.Wizard.WizardLayouts` | bazodanowe, enum |  |  |
| Settings.ListAcceptance | `bool` | bazodanowe | Akceptacja z poziomu listy | Określa czy będzie możliwa akceptacja z poziomu listy mimo posiadania kreatora |
| Settings.Mode | `Soneta.Business.Db.Wizard.WizardReferenceMode` | bazodanowe, enum |  |  |
| Settings.NoTask | `bool` | bazodanowe |  |  |
| Settings.Readed | `bool` | bazodanowe |  |  |
| Settings.Reference | `Soneta.Business.Db.Wizard.WizardReference` |  |  |  |
| Settings.RowSettings | `bool` |  |  |  |
| Settings.TaskForm | `bool` | bazodanowe | Nieaktywne z poziomu listy | Określa czy kreatory zostaną uruchomione na wszystkich listach |
| Settings.TaskSettings | `bool` |  |  |  |
| Settings.TaskUser | `bool` | bazodanowe |  |  |
| TaskDefinition | `Soneta.Business.Db.TaskDefinition` | bazodanowe |  |  |
| WFDefinition | `Soneta.Business.IWFDefinition` | bazodanowe, iface-ref |  |  |
| Wizard | `Soneta.Business.Db.Wizard.WizardDefinition` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWizardReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition`, `WFDefinition` |
| WFDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WizardLayouts (`Soneta.Business.Db.Wizard.WizardLayouts`)
- `Application` = 1 — Podstawowy
- `WebUser` = 2 — Pulpity
- `Mobile` = 4 — Aplikacja mobilna

### WizardReferenceMode (`Soneta.Business.Db.Wizard.WizardReferenceMode`)
- `Creator` = 1 — Wbudowane opcje
- `Editor` = 2 — Algorytm

# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Wizard.WizardStepDefinition`
Nazwa tabeli: `WizardStepDefs`
Tytuł: Definicje kroków kreatorów
Opis: Definicja pojedynczego kroku kreatora. Określa typ zakładki, algorytm, uprawnienia operatora do wykonania kroku oraz parametry prezentacji.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 25
- pola kalkulowane (z klas biznesowych): 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AcceptedCode | `string` |  | Kod algorytmu metody Accepted | Kod algorytmu kalkulatora metody akceptacji kroku kreatora |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod algorytmu | Kod algorytmu kalkulatora kroku kreatora |
| Collection | `string` | bazodanowe | Kolekcja zakładek | Określa typ zakładki przechowującej kolekcję zakładek opisujących krok |
| DataType | `System.Type` |  |  |  |
| DefinedPageXML | `Soneta.Business.MemoText` | bazodanowe | Zakładka użytkownika | Określa typ zakładki definiowanej przez użytkownika opisującej krok (XML) |
| Description | `string` | bazodanowe | Opis | Opis kroku kreatora |
| DescriptionText | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis kroku kreatora |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Nazwa formatowana kroku kreatora |
| GetRowCode | `string` |  | Kod algorytmu metody GetRow | Kod algorytmu kalkulatora metody wyliczającej wiersz edytowany w kroku kreatora |
| GetViewForListStepCode | `string` |  | Kod algorytmu metody GetViewForListStep | Kod algorytmu kalkulatora metody wyliczającej listę dla kroku kreatora typu lista lub lista z edycją |
| Info | `string` |  |  |  |
| IsDbTuple | `bool` |  |  |  |
| IsListStep | `bool` |  | Zakładka typu lista | Określa czy zakładka jest listą (lista lub lista z edycją na liście) |
| IsPageVisible | `bool` |  |  |  |
| IsReadOnlyStep | `bool` | bazodanowe | Krok tylko do odczytu | Czy krok kreatora ma być ustawiony jako tylko do odczytu |
| IsReadOnlyStepCode | `string` |  | Kod algorytmu metody IsReadOnlyStep | Kod algorytmu kalkulatora metody wyliczającej czy krok kreatora jest tylko do odczytu |
| IsVisibleCode | `string` |  | Kod algorytmu metody IsVisible | Kod algorytmu kalkulatora metody widoczności kroku kreatora |
| Locked | `bool` | bazodanowe | Zablokowany | Czy krok kreatora zablokowany |
| Lp | `int` | bazodanowe | Lp. | Liczba porządkowa kroku kreatora |
| Name | `string` | bazodanowe | Nazwa | Nazwa kroku kreatora |
| OnlySubClasses | `bool` |  | Wyszukiwanie zakładek tylko dla klas dziedziczących | Określa czy wyszukiwać zakładeki tylko dla klas dziedziczących |
| Operator | `Soneta.Business.App.Operator` | bazodanowe | Operator | Operator, który może wykonać krok |
| OperatorType | `Soneta.Business.Db.Wizard.WizardStepOperatorType` | bazodanowe, enum | Typ operatora | Typ operatora wykonującego |
| Page | `string` | bazodanowe | Standardowa zakładka | Określa typ zakładki opisującej krok |
| PageDesc | `string` | bazodanowe | Dodatkowy opis standardowej zakładki | Określa dodatkowy opis standardowej zakładki |
| PageForCombo | `string` |  |  |  |
| PageType | `System.Type` |  | Typ standardowej zakładki | Określa typ standardowej zakładki |
| ParentType | `string` | bazodanowe | Typ obiektu kroku kreatora | Określa typ obiektu kroku kreatora |
| Path | `string` |  |  |  |
| PreviewMultiplier | `Soneta.Business.Db.Wizard.WizardPreviewMultiplier` | bazodanowe, enum | Wielkość podglądu | Określa wielkość podglądu załącznika |
| Report | `string` | bazodanowe | Raportowa zakładka | Określa typ zakładki raportującej opisującej krok |
| RichEditStepInfo | `Soneta.Business.MemoText` | bazodanowe | Opis kroku | Określa opis (informację) na kroku typu RichEdit |
| RoleGuid | `System.Guid` | bazodanowe | Rola | Rola, która może wykonać krok |
| RoleName | `string` |  |  |  |
| RowType | `Soneta.Business.IWizardRowType` | bazodanowe | Typ | Typ dla row dla dbtuple |
| Save | `bool` | bazodanowe | Zapis po kroku | Czy krok kreatora umożliwia zapis sesji |
| ShowPdfPreview | `bool` | bazodanowe | Pokaż podgląd załączników PDF | Czy krok kreatora umożliwia wyświetlenie podglądu załączników PDF |
| StepType | `Soneta.Business.Db.Wizard.WizardStepType` | bazodanowe, enum | Typ | Typ kroku kreatora |
| WizardDefinition | `Soneta.Business.Db.Wizard.WizardDefinition` | bazodanowe |  | Definicja kreatora powiązana z krokiem |
| WorkerTypesList | `System.Collections.Generic.List<Soneta.Business.Db.Wizard.ActionAttributeListViewItem>` |  |  |  |
| WorkersTypes | `Soneta.Business.MemoText` | bazodanowe | Typy czynności dla kroku | Typy czynności jakie zostały zarejestrowane dla kroku |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WizardPreviewMultiplier (`Soneta.Business.Db.Wizard.WizardPreviewMultiplier`)
- `Small` = 0 — Mały
- `Normal` = 1 — Normalny
- `Medium` = 2 — Średni
- `Large` = 3 — Duży

### WizardStepOperatorType (`Soneta.Business.Db.Wizard.WizardStepOperatorType`)
- `Current` = 0 — Aktualny
- `Selected` = 1 — Wybrany
- `Role` = 2 — Rola

### WizardStepType (`Soneta.Business.Db.Wizard.WizardStepType`)
- `Page` = 0 — Standardowa zakładka
- `Defined` = 1 — Zakładka użytkownika
- `Report` = 2 — Zakładka wydruku
- `List` = 3 — Zakładka z listą obiektów
- `Attachment` = 4 — Załączniki
- `EditInPlaceList` = 5 — Zakładka z listą obiektów (możliwość edycji na liście)
- `RichEdit` = 6 — Zakładka z opisem

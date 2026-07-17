# Pola i właściwości klasy biznesowej: `TestCentric.Metadata.FieldDefinition`
Nazwa tabeli: `FieldDefs`
Tytuł: Definicje pól
Opis: Element szczegółowy modelu danych (DataModel). Definiuje pole dostępne w modelu analitycznym — jego nazwę, typ bazodanowy i biznesowy, typ agregacji oraz powiązanie z przedziałami czasowymi. Pola stanowią wymiary i miary wykorzystywane w wizualizacjach BI.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 30

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AggregationType | `Soneta.BI.AggregationType` | bazodanowe, enum | Typ agregacji |  |
| Attributes | `TestCentric.Metadata.FieldAttributes` | enum |  |  |
| BIFieldType | `Soneta.BI.BIFieldType` | bazodanowe, enum | Typ(BI) |  |
| BusinessPath | `string` | bazodanowe | Ścieżka biznesowa |  |
| BusinessTypeName | `string` | bazodanowe | Typ biznesowy |  |
| CalculationText | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Constant | `object` |  |  |  |
| ContainsGenericParameter | `bool` |  |  |  |
| CustomAttributes | `TestCentric.Collections.Generic.Collection<TestCentric.Metadata.CustomAttribute>` |  |  |  |
| DeclaringType | `TestCentric.Metadata.TypeDefinition` |  |  |  |
| FieldType | `TestCentric.Metadata.TypeReference` | bazodanowe | Typ(DB) |  |
| FullName | `string` |  |  |  |
| HasConstant | `bool` |  |  |  |
| HasCustomAttributes | `bool` |  |  |  |
| HasDefault | `bool` |  |  |  |
| HasLayoutInfo | `bool` |  |  |  |
| InitialValue | `byte[]` |  |  |  |
| IsAssembly | `bool` |  |  |  |
| IsCompilerControlled | `bool` |  |  |  |
| IsDefinition | `bool` |  |  |  |
| IsFamily | `bool` |  |  |  |
| IsFamilyAndAssembly | `bool` |  |  |  |
| IsFamilyOrAssembly | `bool` |  |  |  |
| IsInitOnly | `bool` |  |  |  |
| IsLiteral | `bool` |  |  |  |
| IsNotSerialized | `bool` |  |  |  |
| IsPInvokeImpl | `bool` |  |  |  |
| IsPrivate | `bool` |  |  |  |
| IsPublic | `bool` |  |  |  |
| IsRuntimeSpecialName | `bool` |  |  |  |
| IsSpecialName | `bool` |  |  |  |
| IsStatic | `bool` |  |  |  |
| IsWindowsRuntimeProjection | `bool` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| MetadataToken | `TestCentric.Metadata.MetadataToken` |  |  |  |
| Model | `Soneta.Business.IRow` | bazodanowe | Model danych |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Offset | `int` |  |  |  |
| RVA | `int` |  |  |  |
| ReadableName | `string` | bazodanowe | Nazwa czytelna |  |
| SourceDefinition | `Soneta.Business.IRow` | bazodanowe |  |  |
| SourcePath | `string` | bazodanowe |  |  |
| TimeSpanSet | `Soneta.Business.IRow` | bazodanowe | Zestaw przedziałów |  |
| Translated | `bool` | bazodanowe | Pole tłumaczone |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AggregationType (`Soneta.BI.AggregationType`)
- `None` = 0 — Brak
- `Count` = 1 — Ilość
- `DistinctCount` = 2 — Ilość unikalnych
- `Sum` = 3 — Suma
- `Max` = 4 — Maksimum
- `Min` = 5 — Minimum
- `Average` = 6 — Średnia
- `StDev` = 7 — Odchylenie standardowe (próba)
- `StDevP` = 8 — Odchylenie standardowe (populacja)
- `Var` = 9 — Wariancja (próba)
- `VarP` = 10 — Wariancja (populacja)

### BIFieldType (`Soneta.BI.BIFieldType`)
- `None` = 0 — Brak
- `Dimension` = 1 — Wymiar
- `Measure` = 2 — Miara

### FieldAttributes (`TestCentric.Metadata.FieldAttributes`)
- `FieldAccessMask` = 7
- `CompilerControlled` = 0
- `Private` = 1
- `FamANDAssem` = 2
- `Assembly` = 3
- `Family` = 4
- `FamORAssem` = 5
- `Public` = 6
- `Static` = 16
- `InitOnly` = 32
- `Literal` = 64
- `NotSerialized` = 128
- `SpecialName` = 512
- `PInvokeImpl` = 8192
- `RTSpecialName` = 1024
- `HasFieldMarshal` = 4096
- `HasDefault` = 32768
- `HasFieldRVA` = 256

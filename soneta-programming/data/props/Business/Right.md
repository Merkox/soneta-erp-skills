# Pola i właściwości klasy biznesowej: `Soneta.Data.QueryDefinition.Right`
Nazwa tabeli: `Rights`
Tytuł: Prawo dostępu
Opis: Prawo dostępu przypisane do uprawnienia dla konkretnego źródła danych. Określa, czy operator może przeglądać lub modyfikować dane w danym kontekście.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Entitle` → `IEntitle`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Entitle | `Soneta.Business.IRow` | bazodanowe, guided-parent |  | Uprawienia, którym dane prawo zostało przypisane. |
| Expression | `Soneta.Data.QueryDefinition.Argument` |  |  |  |
| Length | `Soneta.Data.QueryDefinition.Argument` |  |  |  |
| Name | `string` |  |  |  |
| ReadOnlyRight | `bool` | bazodanowe |  | Określono prawo tylko do przeglądania danych. Nie można modyfikować zapisów. |
| Source | `Soneta.Business.IRow` | bazodanowe |  | Dane, dla których prawo jest określone. |

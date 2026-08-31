# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.Podzielniki.SchematPodzElem`
Nazwa tabeli: `SchematPodzElems`
Tytuł: Element schematu podziałowego
Opis: Element schematu podziałowego definiuje pojedynczy wymiar podziału w ramach podzielnika kosztów. Określa sposób podziału (kwotowy lub proporcjonalny), algorytm klucza podziałowego, cechy opisu analitycznego oraz opcję agregacji identycznych opisów.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Agregacja | `bool` | bazodanowe | Agregacja opisów analitycznych | Określa czy agregować tekie same opisy analityczne. |
| Algorytm | `bool` | bazodanowe | Określa, czy ma być edytowalny kod definicji | Określa, czy ma być edytowalny kod definicji, czy ma być generowany na podstawie innych property. |
| CechaKalkulatorClassNameInternal | `string` | tylko-odczyt |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| ExternalClass | `string` | tylko-odczyt |  |  |
| ExternalClassName | `string` | tylko-odczyt |  |  |
| FeatureExpressionPairs | `System.Collections.Generic.List<Soneta.Ksiega.Podzielniki.FeatureExpressionPair>` | podlista |  |  |
| FeaturesXML | `MemoText` | bazodanowe, podlista | Cechy i ich wyrażenia | Cechy i ich wyrażenia dla opisu analitycznego. |
| IsCopy | `bool` |  |  |  |
| KluczCode | `MemoText` | bazodanowe, podlista | Kod kalkulatora dla klucza | Kod klasy kalkulatora dla klucza. |
| KluczKalkulatorClassName | `string` | tylko-odczyt |  |  |
| KluczKalkulatorClassNameInternal | `string` | tylko-odczyt |  |  |
| KluczRowType | `System.Type` | tylko-odczyt |  |  |
| KluczTyp | `string` | bazodanowe | Określa typ zmiennej w liście kluczy | Określa typ zmiennej w liście kluczy. |
| Nazwa | `string` | bazodanowe | Nazwa projektu | Krótka nazwa definicji podzielnika. |
| PodzielnikCode | `MemoText` | bazodanowe, podlista | Kod kalkulatora dla podzielnika | Kod klasy kalkulatora dla podzielnika. |
| PodzielnikKalkulatorClassName | `string` | tylko-odczyt |  |  |
| PodzielnikKalkulatorClassNameInternal | `string` | tylko-odczyt |  |  |
| PodzielnikRowType | `System.Type` | tylko-odczyt |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SchematPodz | `Soneta.Ksiega.Podzielniki.SchematPodz` | bazodanowe |  | Schemata podziałowy, z którym powiązany jest element |
| SchematPodzElemWg | `Soneta.Ksiega.Podzielniki.SchematPodzElemWg` (enum) | bazodanowe | Podział elementu według. | Określa, czy podana kwota na pozycjach będzie od razu wyliczona, czy będzie przeliczana wg proporcji. |
| ZaokraglanieKwoty | `bool` | bazodanowe | Określa, czy dodać zaokrąglenie | Określa, czy dodać zaokrąglenie do ostatniej pozycji (gdy suma kwot na elementach nie jest równa dzielonej kwocie). |
| _GetBudzet | `string` |  |  |  |
| _GetCentrumKosztow | `string` |  |  |  |
| _GetData | `string` |  |  |  |
| _GetIlosc | `string` |  |  |  |
| _GetIloscKlucza | `string` |  |  |  |
| _GetKategoriaBudzetowa | `string` |  |  |  |
| _GetKluczeList | `string` |  |  |  |
| _GetKwota | `string` |  |  |  |
| _GetKwotaDodatkowaKlucza | `string` |  |  |  |
| _GetKwotaKlucza | `string` |  |  |  |
| _GetOpis | `string` |  |  |  |
| _GetProporcja | `string` |  |  |  |
| _GetRozliczenieElementu | `Soneta.Ksiega.Podzielniki.RodzajRozliczeniaElementu` (enum) |  |  |  |
| _GetSymbol | `string` |  |  |  |
| _GetSymbolPozycjiBudzetu | `string` |  |  |  |
| _GetWymiar | `string` |  |  |  |
| _IsEnable | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajRozliczeniaElementu (`Soneta.Ksiega.Podzielniki.RodzajRozliczeniaElementu`)
- `Brak` = 0
- `KwotaIloscWgRozliczajacego` = 1
- `KwotaProporcjonalnieWgIlosci` = 2

### SchematPodzElemWg (`Soneta.Ksiega.Podzielniki.SchematPodzElemWg`)
- `Kwoty` = 0 — Kwoty
- `Proporcji` = 1

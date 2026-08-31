# Pola i właściwości klasy biznesowej: `Soneta.Kalend.CzytnikRCP`
Nazwa tabeli: `CzytnikiRCP`
Tytuł: Czytniki RCP
Opis: Konfigurowalna definicja czytnika rejestracji czasu pracy (RCP). Określa format danych, ścieżki importu, typy operacji wejścia/wyjścia oraz katalogi plików dla urządzeń rejestrujących obecność pracowników.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Format | `string` | bazodanowe |  |  |
| KatalogImport | `string` | bazodanowe |  |  |
| KatalogKopia | `string` | bazodanowe |  |  |
| KodyZdarzenRCP | `SubTable<Soneta.Kalend.KodZdarzeniaRCP>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RozszerzenieNazwyPliku | `string` | bazodanowe |  |  |
| Sciezka | `string` | bazodanowe |  | Ścieżka do programu obsługującego import z RCP |
| Wejscia | `string` | bazodanowe |  |  |
| WejsciaPrywatne | `string` | bazodanowe |  |  |
| WejsciaSluzbowe | `string` | bazodanowe |  |  |
| Wyjscia | `string` | bazodanowe |  |  |
| WyjsciaPrywatne | `string` | bazodanowe |  |  |
| WyjsciaSluzbowe | `string` | bazodanowe |  |  |
| Zablokowany | `bool` | bazodanowe |  |  |

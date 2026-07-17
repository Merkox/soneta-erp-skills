# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ZleDlugiPozycjaKorekty`
Nazwa tabeli: `ZDPozycjeKorekty`
Tytuł: Korekty cząstkowe ZD
Opis: Element szczegółowy pozycji złych długów (ZleDlugiPozycja). Przechowuje korektę cząstkową powiązaną z konkretnym zapisem księgowym, umożliwiając rozbicie korekty złych długów na poszczególne kwoty z identyfikacją źródła i opisem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Korekta` → `ZleDlugiPozycja`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Korekta | `Soneta.Ksiega.ZleDlugiPozycja` | bazodanowe, guided-parent |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  | Kwota korekty |
| Opis | `string` | bazodanowe |  | Opis korekty |
| Symbol | `string` | bazodanowe |  | Symbol źródła korekty |
| ZapisPowiazany | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe | Zapis powiązany | Zapis powiązany z korektą |

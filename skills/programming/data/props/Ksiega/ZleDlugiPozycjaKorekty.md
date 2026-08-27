# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ZleDlugiPozycjaKorekty`
Nazwa tabeli: `ZDPozycjeKorekty`
Tytuł: Korekty cząstkowe ZD
Opis: Element szczegółowy pozycji złych długów (ZleDlugiPozycja). Przechowuje korektę cząstkową powiązaną z konkretnym zapisem księgowym, umożliwiając rozbicie korekty złych długów na poszczególne kwoty z identyfikacją źródła i opisem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Korekta` → `ZleDlugiPozycja`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Korekta | `Soneta.Ksiega.ZleDlugiPozycja` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Kwota | `Currency` | bazodanowe |  | Kwota korekty |
| Opis | `string` | bazodanowe |  | Opis korekty |
| Symbol | `string` | bazodanowe |  | Symbol źródła korekty |
| ZapisPowiazany | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe | Zapis powiązany | Zapis powiązany z korektą |

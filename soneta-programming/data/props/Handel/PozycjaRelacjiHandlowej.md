# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaRelacjiHandlowej`
Nazwa tabeli: `PozRelHandlowej`
Tytuł: Pozycja relacji handlowej
Opis: Element szczegółowy relacji handlowej (RelacjaHandlowa). Wiąże pozycje dokumentu nadrzędnego z pozycjami podrzędnego, przechowując ilość, wartość i dane rozliczeniowe przeniesione między dokumentami.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Relacja` → `RelacjaHandlowa`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dodatkowa | `bool` | bazodanowe |  | Pozycja dodatkowa dodana ręcznie do listy relacji. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość relacji | Ilość towaru przenoszonego do pozycji podrzędnej. |
| IloscMagazynu | `Soneta.Towary.Quantity` | bazodanowe | Ilość magazynowa relacji | Ilość towaru przenoszonego do pozycji podrzędnej wyrażona w jednostkach magazynowych. |
| IlośćWartość | `Soneta.Handel.IlośćWartość` |  |  |  |
| Nadrzedna | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| NadrzednaIdent | `int` | bazodanowe |  |  |
| NadrzednyDok | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument nadrzędny | Nadrzędny dokumenty relacji handlowej |
| Podrzedna | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| PodrzednaIdent | `int` | bazodanowe |  |  |
| PodrzednyDok | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument podrzędny | Podrzędny dokument relacji handlowej |
| ProdukcjaInfo | `Soneta.Handel.ProdukcjaInfo` | bazodanowe |  |  |
| ProdukcjaInfo.IdentyfikatorElementuPowiazanego | `System.Guid` | bazodanowe | Identyfikator elementu powiązanego | Dla pozycji GUID pozycji technologii (dla ZP i PWP - produkt, dla RWP - surowiec). |
| ProdukcjaInfo.PozycjaTechnologii | `Soneta.Produkcja.PozycjaTechn` |  |  |  |
| ProdukcjaInfo.Technologia | `Soneta.Produkcja.Technologia` |  |  |  |
| ProdukcjaInfo.WgIdentyfikatorElementuPowiazanego | `Soneta.Business.Key` |  |  |  |
| Relacja | `Soneta.Handel.RelacjaHandlowa` | bazodanowe, guided-parent |  | Relacja zawierająca tę pozycje |
| Suma | `Soneta.Handel.BruttoNetto` | bazodanowe |  | Przeliczone na PLN i odpowiednio policzone wartości Netto, Brutto i VAT dla tej pozycji relacji. |
| Suma.Brutto | `decimal` | bazodanowe |  | Wartość brutto. |
| Suma.BruttoCy | `Soneta.Types.Currency` |  |  | Wartość brutto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.JestZero | `bool` |  |  |  |
| Suma.Netto | `decimal` | bazodanowe |  | Wartość netto. |
| Suma.NettoCy | `Soneta.Types.Currency` |  |  | Wartość netto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.VAT | `decimal` | bazodanowe |  | Kwota podatku VAT. |
| Suma.VATCy | `Soneta.Types.Currency` |  |  | Wartość podatku VAT wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość relacji | Wartość towaru przenoszonego do pozycji podrzędnej. |

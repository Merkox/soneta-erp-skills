# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaRelacjiHandlowej`
Nazwa tabeli: `PozRelHandlowej`
Tytuł: Pozycja relacji handlowej
Opis: Element szczegółowy relacji handlowej (RelacjaHandlowa). Wiąże pozycje dokumentu nadrzędnego z pozycjami podrzędnego, przechowując ilość, wartość i dane rozliczeniowe przeniesione między dokumentami.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Relacja` → `RelacjaHandlowa`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dodatkowa | `bool` | bazodanowe, tylko-odczyt |  | Pozycja dodatkowa dodana ręcznie do listy relacji. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość relacji | Ilość towaru przenoszonego do pozycji podrzędnej. |
| IloscMagazynu | `Soneta.Towary.Quantity` | bazodanowe | Ilość magazynowa relacji | Ilość towaru przenoszonego do pozycji podrzędnej wyrażona w jednostkach magazynowych. |
| IlośćWartość | `Soneta.Handel.IlośćWartość` |  |  |  |
| Nadrzedna | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  |  |
| NadrzednaIdent | `int` | bazodanowe, tylko-odczyt |  |  |
| NadrzednyDok | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument nadrzędny | Nadrzędny dokumenty relacji handlowej |
| Podrzedna | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  |  |
| PodrzednaIdent | `int` | bazodanowe, tylko-odczyt |  |  |
| PodrzednyDok | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument podrzędny | Podrzędny dokument relacji handlowej |
| ProdukcjaInfo | `Soneta.Handel.ProdukcjaInfo` (subrow) | bazodanowe |  |  |
| ProdukcjaInfo.IdentyfikatorElementuPowiazanego | `System.Guid` | bazodanowe | Identyfikator elementu powiązanego | Dla pozycji GUID pozycji technologii (dla ZP i PWP - produkt, dla RWP - surowiec). |
| ProdukcjaInfo.PozycjaTechnologii | `Soneta.Produkcja.PozycjaTechn` | tylko-odczyt |  |  |
| ProdukcjaInfo.Technologia | `Soneta.Produkcja.Technologia` |  |  |  |
| ProdukcjaInfo.WgIdentyfikatorElementuPowiazanego | `Key` | podlista |  |  |
| Relacja | `Soneta.Handel.RelacjaHandlowa` | bazodanowe, tylko-odczyt, guided-parent |  | Relacja zawierająca tę pozycje |
| Suma | `Soneta.Handel.BruttoNetto` (subrow) | bazodanowe |  | Przeliczone na PLN i odpowiednio policzone wartości Netto, Brutto i VAT dla tej pozycji relacji. |
| Suma.Brutto | `decimal` | bazodanowe |  | Wartość brutto. |
| Suma.BruttoCy | `Currency` | tylko-odczyt |  | Wartość brutto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.JestZero | `bool` | tylko-odczyt |  |  |
| Suma.Netto | `decimal` | bazodanowe |  | Wartość netto. |
| Suma.NettoCy | `Currency` | tylko-odczyt |  | Wartość netto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.VAT | `decimal` | bazodanowe |  | Kwota podatku VAT. |
| Suma.VATCy | `Currency` | tylko-odczyt |  | Wartość podatku VAT wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Wartosc | `Currency` | bazodanowe | Wartość relacji | Wartość towaru przenoszonego do pozycji podrzędnej. |

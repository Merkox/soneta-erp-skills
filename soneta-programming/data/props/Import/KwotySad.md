# Pola i właściwości klasy biznesowej: `Soneta.Import.KwotySad`
Nazwa tabeli: `KwotySadow`
Tytuł: Kwoty SAD
Opis: Element szczegółowy dokumentu ewidencji (DokEwidencji). Przechowuje kwoty z dokumentu celnego SAD (Single Administrative Document) związane z importem towarów: wartość faktury, koszty transportu, ubezpieczenia, opakowań, cło, akcyzę, VAT i opłatę manipulacyjną, zarówno w walucie obcej, jak i systemowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ewidencja` → `DokEwidencji`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Currency` | bazodanowe |  |  |
| Clo | `Currency` | bazodanowe |  |  |
| DataNotowania | `Date` | bazodanowe |  | Data notowania |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| KosztOpakowan | `Currency` | bazodanowe |  | Koszty opakowań w walucie systemowej |
| KosztOpakowanW | `Currency` | bazodanowe |  | Koszty opakowań w walucie |
| KosztTransportuKrajowego | `Currency` | bazodanowe |  | Koszt transportu krajowego |
| KosztTransportuZagranicznego | `Currency` | bazodanowe |  | Koszty transportu zagranicznego w walucie systemowej |
| KosztTransportuZagranicznegoW | `Currency` | bazodanowe |  | Koszty transportu zagranicznego w walucie |
| KosztUbezpieczen | `Currency` | bazodanowe |  | Koszty ubezpieczeń w walucie systemowej |
| KosztUbezpieczenW | `Currency` | bazodanowe |  | Koszty ubezpieczeń w walucie |
| Kurs | `double` | bazodanowe |  | Kurs waluty |
| OplataManipulacyjna | `Currency` | bazodanowe |  | Opłata manipulacyjna |
| PodstawaVAT | `Currency` | tylko-odczyt |  |  |
| Proforma | `Currency` | bazodanowe |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  | Tabela kursowa |
| Vat | `Currency` | bazodanowe, tylko-odczyt |  |  |
| WartoscCelna | `Currency` | tylko-odczyt |  |  |
| WartoscFaktury | `Currency` | bazodanowe |  | Wartość faktury w walucie systemowej |
| WartoscFakturyW | `Currency` | bazodanowe |  | Wartość faktury w walucie |
| WartoscTowaru | `Currency` | tylko-odczyt |  |  |

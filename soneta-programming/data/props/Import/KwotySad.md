# Pola i właściwości klasy biznesowej: `Soneta.Import.KwotySad`
Nazwa tabeli: `KwotySadow`
Tytuł: Kwoty SAD
Opis: Element szczegółowy dokumentu ewidencji (DokEwidencji). Przechowuje kwoty z dokumentu celnego SAD (Single Administrative Document) związane z importem towarów: wartość faktury, koszty transportu, ubezpieczenia, opakowań, cło, akcyzę, VAT i opłatę manipulacyjną, zarówno w walucie obcej, jak i systemowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ewidencja` → `DokEwidencji`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Soneta.Types.Currency` | bazodanowe |  |  |
| Clo | `Soneta.Types.Currency` | bazodanowe |  |  |
| DataNotowania | `Soneta.Types.Date` | bazodanowe |  | Data notowania |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe, guided-parent |  |  |
| KosztOpakowan | `Soneta.Types.Currency` | bazodanowe |  | Koszty opakowań w walucie systemowej |
| KosztOpakowanW | `Soneta.Types.Currency` | bazodanowe |  | Koszty opakowań w walucie |
| KosztTransportuKrajowego | `Soneta.Types.Currency` | bazodanowe |  | Koszt transportu krajowego |
| KosztTransportuZagranicznego | `Soneta.Types.Currency` | bazodanowe |  | Koszty transportu zagranicznego w walucie systemowej |
| KosztTransportuZagranicznegoW | `Soneta.Types.Currency` | bazodanowe |  | Koszty transportu zagranicznego w walucie |
| KosztUbezpieczen | `Soneta.Types.Currency` | bazodanowe |  | Koszty ubezpieczeń w walucie systemowej |
| KosztUbezpieczenW | `Soneta.Types.Currency` | bazodanowe |  | Koszty ubezpieczeń w walucie |
| Kurs | `double` | bazodanowe |  | Kurs waluty |
| OplataManipulacyjna | `Soneta.Types.Currency` | bazodanowe |  | Opłata manipulacyjna |
| PodstawaVAT | `Soneta.Types.Currency` |  |  |  |
| Proforma | `Soneta.Types.Currency` | bazodanowe |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  | Tabela kursowa |
| Vat | `Soneta.Types.Currency` | bazodanowe |  |  |
| WartoscCelna | `Soneta.Types.Currency` |  |  |  |
| WartoscFaktury | `Soneta.Types.Currency` | bazodanowe |  | Wartość faktury w walucie systemowej |
| WartoscFakturyW | `Soneta.Types.Currency` | bazodanowe |  | Wartość faktury w walucie |
| WartoscTowaru | `Soneta.Types.Currency` |  |  |  |

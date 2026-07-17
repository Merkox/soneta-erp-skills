# Pola i właściwości klasy biznesowej: `Soneta.Core.DefXmlElem`
Nazwa tabeli: `DefsXmlElem`
Tytuł: Elementy definicji XML
Opis: Element szczegółowy definicji XML (DefXmlNag). Reprezentuje pojedynczy element (pole, atrybut, sekcję) w strukturze szablonu XML z hierarchią, kolejnością, typem, mapowaniem na właściwości obiektów oraz algorytmem eksportu/importu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BazowyLp | `int` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Pozostały kod | Pozostały kod. |
| CodeExport | `Soneta.Business.MemoText` | bazodanowe | Kod eksportu | Kod dla eksportu. |
| CodeImport | `Soneta.Business.MemoText` | bazodanowe | Kod importu | Kod dla importu. |
| CodeVisible | `Soneta.Business.MemoText` | bazodanowe | Kod widoczności | Kod widoczności elementu. |
| DefXmlElemCode | `string` |  |  |  |
| DefXmlNag | `Soneta.Core.DefXmlNag` | bazodanowe |  | Definicja XML, z którą powiązany jest element |
| Definicja | `Soneta.Core.DefXmlNag` |  |  |  |
| DlugoscDanych | `int` | bazodanowe | Długość danych | Określa dozwoloną długość danych. |
| Element | `string` | bazodanowe | Nazwa elementu | Nazwa elementu. |
| FullClassName | `string` |  |  |  |
| HasPodrzedne | `bool` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Nadrzedny | `Soneta.Core.DefXmlElem` | bazodanowe | Nadrzędny | Określa nadrzędny element. |
| OcrBusinessMappingElements | `Soneta.Business.SubTable` |  |  |  |
| Opcjonalne | `Soneta.Core.OpcjonalnoscDefXmlElem` | bazodanowe, enum | Pole opcjonalne | Określa czy pole jest opcjonalne. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis elementu definicji. |
| Path | `string` |  |  |  |
| Podrzedne | `Soneta.Business.SubTable<Soneta.Core.DefXmlElem>` |  |  |  |
| RowType | `System.Type` |  |  |  |
| Specjalne | `Soneta.Core.PoleSpecjalne` | bazodanowe, enum | Przeznaczenie elementu | Określa specjalne przeznaczenie danego elementu. |
| TableName | `string` | bazodanowe | Tabela danych | Klasa obiektu. |
| Type | `Soneta.Core.ElementType` | bazodanowe, enum | Typ | Określa typ obiektu tworzonego przy przekształcaniu elementu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ElementType (`Soneta.Core.ElementType`)
- `Empty` = 0 — Brak
- `Property` = 1 — Właściwość
- `Object` = 2 — Obiekt
- `List` = 3 — Lista
- `ListWithoutNode` = 4 — Lista bez węzła

### OpcjonalnoscDefXmlElem (`Soneta.Core.OpcjonalnoscDefXmlElem`)
- `Nie` = 0
- `Tak` = 1

### PoleSpecjalne (`Soneta.Core.PoleSpecjalne`)
- `None` = 0
- `Kategoria` = 1
- `NIPKontrahenta` = 2
- `NazwaKontrahenta` = 3
- `WartoscDokumentu` = 4 — Wartość dokumentu
- `WalutaDokumentu` = 5
- `DataDokumentu` = 6
- `RodzajDokumentu` = 7
- `NumerDokumentu` = 8
- `WartoscNettoZeStawkaPodstawowa` = 9 — Wartość netto ze stawką podstawową
- `WartoscNettoZeStawkaObnizonaPierwsza` = 10 — Wartość netto ze stawką obniżoną pierwszą
- `WartoscNettoZeStawkaObnizonaDruga` = 11 — Wartość netto ze stawką obniżoną drugą
- `WartoscNettoZeStawkaObnizonaTrzecia` = 12 — Wartość netto ze stawką obniżoną trzecią
- `WartoscNettoNP` = 13 — Wartość netto NP
- `WartoscNettoWStawce0BezWDTIEksportu` = 14 — Wartość netto w stawce 0% bez WDT i eksportu
- `WartoscNettoWStawce0WDT` = 15 — Wartość netto w stawce 0% WDT
- `WartoscNettoWStawce0Eksport` = 16 — Wartość netto w stawce 0% eksport
- `WartoscNettoZwolniona` = 17 — Wartość netto zwolniona
- `WartoscNettoSprzedazyPozaKraj` = 18 — Wartość netto sprzedaży poza terytorium kraju
- `WartoscNettoSwiadczeniaUslug` = 19 — Wartość netto świadczenia usług
- `WartoscNettoOdwrotneObciazenie` = 20 — Wartość netto odwrotne obciążenie
- `WartoscNettoWProcedurzeMarzy` = 21 — Wartość netto w procedurze marży
- `SposobZaplaty` = 22 — Sposób zapłaty
- `TerminPlatnosci` = 23 — Termin płatności
- `OpisPlatnosci` = 24 — Opis płatności
- `NIPKontrahenta2` = 25
- `PrzyczynaKorekty` = 26 — Przyczyna korekty
- `WartoscVatZeStawkaPodstawowa` = 27 — Wartość VAT dla stawki podstawowej
- `WartoscVatZeStawkaPodstawowaPln` = 28 — Wartość VAT dla stawki podstawowej w PLN
- `WartoscVatZeStawkaObnizonaPierwsza` = 29 — Wartość VAT ze stawką obniżoną pierwszą
- `WartoscVatZeStawkaObnizonaPierwszaPln` = 30 — Wartość VAT ze stawką obniżoną pierwszą w PLN
- `WartoscVatZeStawkaObnizonaDruga` = 31 — Wartość VAT ze stawką obniżoną drugą
- `WartoscVatZeStawkaObnizonaDrugaPln` = 32 — Wartość VAT ze stawką obniżoną drugą w PLN
- `WartoscVatZeStawkaObnizonaTrzecia` = 33 — Wartość VAT ze stawką obniżoną trzecią
- `WartoscVatZeStawkaObnizonaTrzeciaPln` = 34 — Wartość VAT ze stawką obniżoną trzecią w PLN
- `WartoscVatSprzedazyPozaKraj` = 35 — Wartość VAT sprzedaży poza terytorium kraju
- `DataZPolaP6` = 36 — Data dokonania lub zakończenia dostawy towarów lub wykonania usługi
- `DataZPolaP6Od` = 37 — Data początkowa okresu, którego dotyczy faktura
- `DataZPolaP6Do` = 38 — Data końcowa okresu, którego dotyczy faktura
- `NazwaKontrahenta2` = 39
- `WartoscNettoNPI` = 40 — Wartość netto NP I
- `WartoscNettoNPII` = 41 — Wartość netto NP II
- `NumerWZ` = 42 — Numer WZ
- `NumerZamowienia` = 43 — Numer zamówienia

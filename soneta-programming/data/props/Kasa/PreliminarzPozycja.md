# Pola i właściwości klasy biznesowej: `Soneta.Kasa.PreliminarzPozycja`
Nazwa tabeli: `PreliminarzPoz`
Tytuł: Pozycje preliminarza
Opis: Element szczegółowy dokumentu preliminarza (IDokumentPreliminarza). Reprezentuje pojedynczą planowaną operację pieniężną z kwotą, kierunkiem (wpłata/wypłata), terminem realizacji oraz powiązaniem z podmiotem i ewidencją ŚP. Podlega rozliczeniu z faktycznymi płatnościami i zapłatami.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `IDokumentPreliminarza`

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 5
- subrowy: 0
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowana | `bool` | bazodanowe |  | Czy pozycja jest anulowana |
| Bufor | `bool` | bazodanowe, tylko-odczyt |  | Pozycja w buforze |
| Dokument | `Soneta.Kasa.IDokumentPreliminarza` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| Kierunek | `Soneta.Kasa.PreliminarzKierunek` (enum) | bazodanowe |  | Kierunek operacji |
| Kwota | `Currency` | bazodanowe |  |  |
| KwotaPLN | `Currency` | bazodanowe |  |  |
| Nieaktywna | `bool` | bazodanowe |  | Czy pozycja jest nieaktywna |
| NumerDodatkowy | `string` | bazodanowe |  |  |
| NumerDokumentu | `string` | bazodanowe, tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `string` | bazodanowe |  | Opis pozycji preliminarza |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rozliczenia | `Soneta.Kasa.RozliczeniePreliminarzaList` | podlista |  |  |
| RozliczeniePlatnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| RozliczenieZaplaty | `SubTable<Soneta.Kasa.Zaplata>` | podlista |  |  |
| Termin | `Date` | bazodanowe |  |  |
| TypPozycji | `Soneta.Kasa.PreliminarzTypPozycji` (enum) | bazodanowe |  | Typ pozycji preliminarza |
| VirtualEx | `MemoText` | bazodanowe, podlista |  |  |
| Wielowalutowy | `bool` | bazodanowe |  | Plan okresowy jest wielowalutowy |
| Zatwierdzona | `bool` | tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IDokumentPreliminarza` | `PreliminarzDokument` |
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PreliminarzKierunek (`Soneta.Kasa.PreliminarzKierunek`)
- `Naleznosc` = 1 — Należność
- `Zobowiazanie` = 2 — Zobowiązanie

### PreliminarzTypPozycji (`Soneta.Kasa.PreliminarzTypPozycji`)
- `Szczegolowa` = 0 — Szczegółowa
- `Okresowa` = 1

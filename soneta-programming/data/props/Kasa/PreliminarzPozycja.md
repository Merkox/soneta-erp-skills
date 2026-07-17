# Pola i właściwości klasy biznesowej: `Soneta.Kasa.PreliminarzPozycja`
Nazwa tabeli: `PreliminarzPoz`
Tytuł: Pozycje preliminarza
Opis: Element szczegółowy dokumentu preliminarza (IDokumentPreliminarza). Reprezentuje pojedynczą planowaną operację pieniężną z kwotą, kierunkiem (wpłata/wypłata), terminem realizacji oraz powiązaniem z podmiotem i ewidencją ŚP. Podlega rozliczeniu z faktycznymi płatnościami i zapłatami.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `IDokumentPreliminarza`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowana | `bool` | bazodanowe |  | Czy pozycja jest anulowana |
| Bufor | `bool` | bazodanowe |  | Pozycja w buforze |
| Dokument | `Soneta.Kasa.IDokumentPreliminarza` | bazodanowe, guided-parent, iface-ref |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| Kierunek | `Soneta.Kasa.PreliminarzKierunek` | bazodanowe, enum |  | Kierunek operacji |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaPLN | `Soneta.Types.Currency` | bazodanowe |  |  |
| Nieaktywna | `bool` | bazodanowe |  | Czy pozycja jest nieaktywna |
| NumerDodatkowy | `string` | bazodanowe |  |  |
| NumerDokumentu | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  | Opis pozycji preliminarza |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rozliczenia | `Soneta.Kasa.RozliczeniePreliminarzaList` |  |  |  |
| RozliczeniePlatnosci | `Soneta.Business.SubTable<Soneta.Kasa.Platnosc>` |  |  |  |
| RozliczenieZaplaty | `Soneta.Business.SubTable<Soneta.Kasa.Zaplata>` |  |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| TypPozycji | `Soneta.Kasa.PreliminarzTypPozycji` | bazodanowe, enum |  | Typ pozycji preliminarza |
| VirtualEx | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Wielowalutowy | `bool` | bazodanowe |  | Plan okresowy jest wielowalutowy |
| Zatwierdzona | `bool` |  |  |  |

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

# Pola i właściwości klasy biznesowej: `Soneta.Kadry.MetrykaWydziału`
Nazwa tabeli: `MetrykiWydzialow`
Tytuł: Wpisy do metryki jednostek organizacyjnych
Opis: Element szczegółowy wydziału (Wydzial). Wpis do metryki jednostki organizacyjnej dokumentujący zdarzenia takie jak zmiany organizacyjne, z podaniem daty, rodzaju wpisu i przyczyny zmiany.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wydzial` → `Wydzial`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data zmiany |  |
| Host | `Soneta.Kadry.IMetrykaWydziałuHost` | bazodanowe, iface-ref |  |  |
| Przyczyna | `string` | bazodanowe | Przyczyna zmiany |  |
| Rodzaj | `Soneta.Kadry.RodzajMetryki` | bazodanowe, enum | Rodzaj wpisu |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, guided-parent |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IMetrykaWydziałuHost` | `HistoriaDanychWydziału`, `WydzialRef` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajMetryki (`Soneta.Kadry.RodzajMetryki`)
- `UtworzenieJednoski` = 1
- `ZmianaDanych` = 10
- `ZmianaNadrzędnego` = 11
- `InneZdarzenie` = 12
- `LikwidacjaJednostki` = 20

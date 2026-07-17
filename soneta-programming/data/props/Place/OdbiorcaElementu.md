# Pola i właściwości klasy biznesowej: `Soneta.Place.OdbiorcaElementu`
Nazwa tabeli: `OdbElementow`
Opis: Element szczegółowy definicji elementu wynagrodzenia (DefinicjaElementu). Wskazuje odbiorcę płatności (np. komornika, instytucję) i rachunek bankowy, na który ma być przekazywana kwota z danego składnika.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Definicja` → `DefinicjaElementu`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe, guided-parent |  |  |
| Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Odbiorca | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

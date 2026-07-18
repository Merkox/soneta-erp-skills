# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieDietZagr`
Nazwa tabeli: `ZestawDietZagr`
Tytuł: Zestawienia diet pracowników za granicą
Opis: Element szczegółowy hosta zestawienia diet zagranicznych (IZestawienieDietZagrHost). Okresowe zestawienie diet pracownika delegowanego za granicę, przechowujące okres i liczbę przysługujących diet.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IZestawienieDietZagrHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Diety | `int` | bazodanowe |  |  |
| Host | `Soneta.Kalend.IZestawienieDietZagrHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| OddelegowanyDo | `Soneta.Kadry.IKrajDelegacji` | tylko-odczyt, iface-ref |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IZestawienieDietZagrHost` | `Pracownik`, `Umowa` |
| OddelegowanyDo | `IKrajDelegacji` | `KrajDelegacji` |

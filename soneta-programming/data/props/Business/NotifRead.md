# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.NotifRead`
Nazwa tabeli: `NotifsRead`
Tytuł: Powiadomienia odczytane
Opis: Rejestr odczytanych powiadomień. Przechowuje informację o tym, który użytkownik odczytał dane powiadomienie (zadanie).
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Task | `Db.Task` | bazodanowe | Powiadomienie | Odczytane powiadomienie |
| TaskUser | `ITaskUser` | bazodanowe, iface-ref | Odczytane przez | Odczytane przez |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

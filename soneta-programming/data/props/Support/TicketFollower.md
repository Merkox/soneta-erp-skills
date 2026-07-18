# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.TicketFollower`
Nazwa tabeli: `TicketFollowers`
Tytuł: Obserwowane zgłoszenia
Opis: Rejestr obserwatorów zgłoszeń serwisowych. Umożliwia operatorom i użytkownikom subskrybowanie powiadomień o zmianach w wybranych zgłoszeniach, co pozwala na śledzenie postępu ich realizacji bez bezpośredniego przypisania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| TaskUser | `ITaskUser` | bazodanowe, iface-ref | Operator |  |
| Ticket | `Soneta.Support.Support.Ticket` | bazodanowe | Zgłoszenie |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

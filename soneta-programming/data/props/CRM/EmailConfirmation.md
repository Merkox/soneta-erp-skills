# Pola i właściwości klasy biznesowej: `Soneta.CRM.EmailConfirmation`
Nazwa tabeli: `EmailConfs`
Tytuł: Potwierdzenie wiadomości
Opis: Rejestr potwierdzeń odczytu i dostarczenia wiadomości e-mail. Przechowuje datę, typ potwierdzenia i użytkownika, umożliwiając śledzenie, czy odbiorca otworzył lub otrzymał wiadomość.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `System.DateTime` | bazodanowe |  |  |
| Message | `Soneta.CRM.WiadomoscEmail` | bazodanowe |  |  |
| Type | `Soneta.CRM.EmailConfirmationType` | bazodanowe, enum |  |  |
| User | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| User | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EmailConfirmationType (`Soneta.CRM.EmailConfirmationType`)
- `Reading` = 0 — Odczytana
- `Delivery` = 1 — Dostarczona

# Pola i właściwości klasy biznesowej: `Soneta.CRM.EmailConfirmation`
Nazwa tabeli: `EmailConfs`
Tytuł: Potwierdzenie wiadomości
Opis: Rejestr potwierdzeń odczytu i dostarczenia wiadomości e-mail. Przechowuje datę, typ potwierdzenia i użytkownika, umożliwiając śledzenie, czy odbiorca otworzył lub otrzymał wiadomość.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
| Message | `Soneta.CRM.WiadomoscEmail` | bazodanowe, tylko-odczyt |  |  |
| Type | `Soneta.CRM.EmailConfirmationType` (enum) | bazodanowe, tylko-odczyt |  |  |
| User | `ITaskUser` | bazodanowe, tylko-odczyt, iface-ref |  |  |

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

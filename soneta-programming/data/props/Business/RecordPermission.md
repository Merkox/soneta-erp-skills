# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Permissions.RecordPermission`
Nazwa tabeli: `RecordPerms`
Tytuł: Prawa rekordów
Opis: Uprawnienie na poziomie pojedynczego rekordu. Przypisuje rodzaj dostępu (odczyt, zapis) konkretnemu użytkownikowi lub grupie do wybranego obiektu biznesowego.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Authorised | `Soneta.Business.Db.Permissions.IAuthorised` | bazodanowe, iface-ref | Uprawniony | Określa upawnionego |
| Permission | `Soneta.Business.AccessRights` | bazodanowe, enum | Uprawnienie | Określa rodzaj uprawnienia |
| PermissionClient | `Soneta.Business.Db.Permissions.IPermissionClient` | bazodanowe, iface-ref | Klient uprawnienia | Określa klienta uprawnienia |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Authorised | `IAuthorised` | `Operator`, `UserGroup` |
| PermissionClient | `IPermissionClient` | `Attachment`, `BasicDocument`, `ChronoOrder`, `ChronoOrderLoc`, `ElementStrukturyOrganizacyjnej`, `Matter`, `Teczka`, `WiadomoscEmail` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`Soneta.Business.AccessRights`)
- `Denied` = 0 — Zakaz dostępu
- `ReadOnly` = 1 — Tylko odczyt
- `Granted` = 2 — Pełne prawo
- `NoInit` = 3 — Niezainicjowane

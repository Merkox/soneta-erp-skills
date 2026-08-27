# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Notifications.SysNotificationRef`
Nazwa tabeli: `SysNotRefs`
Tytuł: Referencje do powiadomień
Opis: Powiązanie powiadomienia systemowego z definicją procesu lub zadania. Określa kontekst, w którym powiadomienie jest aktywne.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Notification` → `SysNotification`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Notification | `Db.Notifications.SysNotification` | bazodanowe, tylko-odczyt, guided-parent | Powiadomienie |  |
| Reference | `Db.Notifications.ISysNotificationReference` | bazodanowe, tylko-odczyt, iface-ref | Dla | Określa definicję procesu lub zadania |
| TaskDefinition | `Db.TaskDefinition` |  |  |  |
| WfDefinition | `IWFDefinition` | iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Reference | `ISysNotificationReference` | `TaskDefinition`, `WFDefinition` |
| WfDefinition | `IWFDefinition` | `WFDefinition` |

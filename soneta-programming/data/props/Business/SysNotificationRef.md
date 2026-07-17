# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Notifications.SysNotificationRef`
Nazwa tabeli: `SysNotRefs`
Tytuł: Referencje do powiadomień
Opis: Powiązanie powiadomienia systemowego z definicją procesu lub zadania. Określa kontekst, w którym powiadomienie jest aktywne.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Notification` → `SysNotification`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Notification | `Soneta.Business.Db.Notifications.SysNotification` | bazodanowe, guided-parent | Powiadomienie |  |
| Reference | `Soneta.Business.Db.Notifications.ISysNotificationReference` | bazodanowe, iface-ref | Dla | Określa definicję procesu lub zadania |
| TaskDefinition | `Soneta.Business.Db.TaskDefinition` |  |  |  |
| WfDefinition | `Soneta.Business.IWFDefinition` | iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Reference | `ISysNotificationReference` | `TaskDefinition`, `WFDefinition` |
| WfDefinition | `IWFDefinition` | `WFDefinition` |

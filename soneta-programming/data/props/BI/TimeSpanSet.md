# Pola i właściwości klasy biznesowej: `Soneta.BI.TimeSpanSet`
Nazwa tabeli: `TimeSpanSets`
Tytuł: Zestawy przedziałów czasowych
Opis: Nazwany zestaw przedziałów czasowych używany w polach modeli danych BI. Grupuje powiązane definicje przedziałów (np. miesiące, kwartały) w logiczną całość, którą można przypisać do pola typu data w modelu analitycznym.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 1
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Items | `Soneta.Business.LpSubTable<Soneta.BI.TimeSpanItem>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |

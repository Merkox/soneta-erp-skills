# Pola i właściwości klasy biznesowej: `Soneta.BI.TimeSpanSet`
Nazwa tabeli: `TimeSpanSets`
Tytuł: Zestawy przedziałów czasowych
Opis: Nazwany zestaw przedziałów czasowych używany w polach modeli danych BI. Grupuje powiązane definicje przedziałów (np. miesiące, kwartały) w logiczną całość, którą można przypisać do pola typu data w modelu analitycznym.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Items | `LpSubTable<Soneta.BI.TimeSpanItem>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa |  |

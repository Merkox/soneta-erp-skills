# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PrzetwarzanieZgloszeniaSygnalisty`
Nazwa tabeli: `PrzetwarzZglSyg`
Tytuł: Przetwarzanie naruszeń
Opis: Wpis dokumentujący etap przetwarzania zgłoszenia sygnalisty. Rejestruje datę, opis czynności podjętych w ramach rozpatrywania naruszenia oraz opis podjętego działania naprawczego.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data dokumentu |  |
| Operator | `Soneta.Business.App.Operator` |  |  |  |
| Opis | `string` | bazodanowe | Opis |  |
| PodjeteDzialanie | `string` | bazodanowe | Podjęte działanie |  |
| ReadOnlyPodjeteDzialanie | `bool` |  |  |  |
| StatusZadania | `string` |  |  |  |
| Zadanie | `Soneta.Business.Db.Task` |  |  |  |
| Zgloszenie | `Soneta.Kadry.ZgloszenieSygnalisty` | bazodanowe | Przetwarzanie zgloszeń sygnalisty |  |

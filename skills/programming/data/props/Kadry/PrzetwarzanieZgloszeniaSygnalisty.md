# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PrzetwarzanieZgloszeniaSygnalisty`
Nazwa tabeli: `PrzetwarzZglSyg`
Tytuł: Przetwarzanie naruszeń
Opis: Wpis dokumentujący etap przetwarzania zgłoszenia sygnalisty. Rejestruje datę, opis czynności podjętych w ramach rozpatrywania naruszenia oraz opis podjętego działania naprawczego.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Data dokumentu |  |
| Operator | `App.Operator` | tylko-odczyt |  |  |
| Opis | `string` | bazodanowe | Opis |  |
| PodjeteDzialanie | `string` | bazodanowe | Podjęte działanie |  |
| ReadOnlyPodjeteDzialanie | `bool` | tylko-odczyt |  |  |
| StatusZadania | `string` | tylko-odczyt |  |  |
| Zadanie | `Db.Task` | tylko-odczyt |  |  |
| Zgloszenie | `Soneta.Kadry.ZgloszenieSygnalisty` | bazodanowe | Przetwarzanie zgloszeń sygnalisty |  |

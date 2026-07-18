# Pola i właściwości klasy biznesowej: `Soneta.Core.KomunikatAPI`
Nazwa tabeli: `KomunikatyAPI`
Tytuł: KomunikatyAPI
Opis: Rejestr komunikatów wymienianych z systemami zewnętrznymi przez API. Przechowuje identyfikatory dokumentów i komunikatów nadane przez API, typ dokumentu oraz powiązanie z systemem zewnętrznym.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| documentID | `string` | bazodanowe |  | ID nadane przez api |
| documentType | `int` | bazodanowe |  | Typ dokumentu. |
| msgID | `string` | bazodanowe |  | ID komunikatu nadane przez api |
| systemZewn | `Soneta.Core.SystemZewn` | bazodanowe |  | System Zewnętrzny. |

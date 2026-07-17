# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.StanowiskoPracy`
Nazwa tabeli: `StanowiskaPracy`
Tytuł: Stanowisko pracy
Opis: Kartoteka stanowisk pracy przypisanych do pomieszczeń w nieruchomościach. Służy do zarządzania fizycznym rozmieszczeniem miejsc pracy, ich rezerwacją oraz powiązaniem ze środkami trwałymi takimi jak meble czy sprzęt IT.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywne | `bool` | bazodanowe | Określa, czy stanowisko pracy jest aktywne | Określa, czy stanowisko pracy jest aktywne |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanowiska pracy |
| NieruchomoscGuid | `System.Guid` | bazodanowe | Id pomieszczenia w nieruchomości | Identifikator pomieszczenia w nieruchomości |
| Opis | `string` | bazodanowe | Opis | Opis stanowiska pracy |
| Rezerwacje | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.RezerwacjaStanowiskaPracy>` |  |  |  |
| Room | `Soneta.RealEstate.Models.Database.Nieruchomosc` |  |  |  |
| RoomAndLocation | `string` |  |  |  |
| SerializedDiagram | `Soneta.Business.MemoText` | bazodanowe | Serializowane dane diagramu | Określa serializowane dane diagramu |
| SrodkiTrwale | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.StnPracSrTrwalyRel>` |  |  |  |

# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.StanowiskoPracy`
Nazwa tabeli: `StanowiskaPracy`
Tytuł: Stanowisko pracy
Opis: Kartoteka stanowisk pracy przypisanych do pomieszczeń w nieruchomościach. Służy do zarządzania fizycznym rozmieszczeniem miejsc pracy, ich rezerwacją oraz powiązaniem ze środkami trwałymi takimi jak meble czy sprzęt IT.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywne | `bool` | bazodanowe | Określa, czy stanowisko pracy jest aktywne | Określa, czy stanowisko pracy jest aktywne |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanowiska pracy |
| NieruchomoscGuid | `System.Guid` | bazodanowe, tylko-odczyt | Id pomieszczenia w nieruchomości | Identifikator pomieszczenia w nieruchomości |
| Opis | `string` | bazodanowe | Opis | Opis stanowiska pracy |
| Rezerwacje | `SubTable<Soneta.RealEstate.Models.Database.RezerwacjaStanowiskaPracy>` | podlista |  |  |
| Room | `Soneta.RealEstate.Models.Database.Nieruchomosc` |  |  |  |
| RoomAndLocation | `string` | tylko-odczyt |  |  |
| SerializedDiagram | `MemoText` | bazodanowe, podlista | Serializowane dane diagramu | Określa serializowane dane diagramu |
| SrodkiTrwale | `SubTable<Soneta.RealEstate.Models.Database.StnPracSrTrwalyRel>` | podlista |  |  |

# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.MiejsceUzytkowania`
Nazwa tabeli: `MiejscaUzytk`
Tytuł: Miejsca użytkowania
Opis: Słownik miejsc użytkowania środków trwałych i wyposażenia. Pozwala przypisać środek trwały do konkretnej lokalizacji w firmie oraz powiązać ją z oddziałem. Służy do kontroli rozmieszczenia majątku oraz wspiera proces inwentaryzacji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CtxOddziałFirmy | `Soneta.Core.OddzialFirmy` |  |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa miejsca użytkowania srodka trwałego |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  | Opis miejsca użytkowania srodka trwałego |

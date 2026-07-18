# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.KosztDelegacji`
Nazwa tabeli: `KosztyDelegacji`
Tytuł: Koszty etapu delegacji
Opis: Element szczegółowy EtapDelegacji (EtapDelegacji). Rejestruje pojedynczy koszt poniesiony podczas etapu delegacji, taki jak nocleg, przejazd, bilet komunikacyjny lub inny wydatek. Umożliwia powiązanie kosztu z dokumentem przejazdu samochodem lub dokumentem ewidencji oraz oznaczenie go jako korektę.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data poniesienia kosztu |
| DokEwidencja | `Soneta.Core.DokEwidencji` | bazodanowe |  | Podpięty dokument ewidencji. |
| DokPrzejazd | `Soneta.Samochodowka.Przejazd` | bazodanowe |  | Podpięta informacja o przejeździe samochodem. |
| Etap | `Soneta.Delegacje.EtapDelegacji` | bazodanowe, tylko-odczyt |  | Etap delegacji, do którego należy koszty |
| Korekta | `bool` | bazodanowe |  | Czy dane mają być traktowane jako korekta - czyli z odwrotnym znakiem |
| Koszt | `Currency` | bazodanowe |  | Wartość kosztu do rozliczenia w delegacji |
| Lp | `int` | bazodanowe |  |  |
| NumerDokumentuKSeF | `string` | bazodanowe |  | Numer dokumentu nadany przez KSeF |
| Opis | `string` | bazodanowe |  | Opis poniesionego kosztu |
| Rodzaj | `Soneta.Delegacje.RodzajKosztuDelegacji` (enum) | bazodanowe |  | Klasyfikacja kosztu delegacji |
| ZgloszenieZakupu | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Zgłoszenie zakupu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajKosztuDelegacji (`Soneta.Delegacje.RodzajKosztuDelegacji`)
- `Inny` = 0 — Inne koszty
- `Hotel` = 1 — Hotel/Zakwaterowanie
- `TransportSamochod` = 2 — Przejazd samochodem
- `SrodekTransportu` = 3 — Środek transportu
- `InnyNierozliczany` = 4 — Inne koszty (nierozliczane)

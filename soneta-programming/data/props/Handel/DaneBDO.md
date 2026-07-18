# Pola i właściwości klasy biznesowej: `Soneta.Handel.DaneBDO`
Nazwa tabeli: `DaneDokBDO`
Tytuł: Dane dokumentów BDO
Opis: Dane BDO (Baza Danych o Odpadach) powiązane z dokumentem handlowym. Zawiera informacje o transporcie odpadów, pochodzeniu i statusie dokumentu w systemie BDO.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataTransportu | `System.DateTime` | bazodanowe | Data transportu | Planowana data transportu |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument handlowy |  |
| NrRejestracyjnyPojazdu | `string` | bazodanowe | Numer rejestracyjny środka transportu |  |
| Pochodzenie | `Soneta.Handel.PochodzenieBDO` (enum) | bazodanowe | Pochodzenie odpadu |  |
| StatusDokumentu | `Soneta.Handel.BDOStatus` (enum) | bazodanowe | Status dokumentu w systemie BDO |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BDOStatus (`Soneta.Handel.BDOStatus`)
- `None` = 0
- `Planowana` = 1
- `Zatwierdzona` = 2
- `PotwierdzenieWygenerowane` = 3 — Potwierdzenie wygenerowane
- `PotwierdzeniePrzejecia` = 4 — Potwierdzenie przejęcia
- `PotwierdzenieTransportu` = 5 — Potwierdzenie transportu
- `Wycofana` = 6
- `Odrzucona` = 7

### PochodzenieBDO (`Soneta.Handel.PochodzenieBDO`)
- `ZInstalacji` = 0
- `SpozaInstalacji` = 1

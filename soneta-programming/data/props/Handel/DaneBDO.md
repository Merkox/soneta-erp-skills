# Pola i właściwości klasy biznesowej: `Soneta.Handel.DaneBDO`
Nazwa tabeli: `DaneDokBDO`
Tytuł: Dane dokumentów BDO
Opis: Dane BDO (Baza Danych o Odpadach) powiązane z dokumentem handlowym. Zawiera informacje o transporcie odpadów, pochodzeniu i statusie dokumentu w systemie BDO.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataTransportu | `System.DateTime` | bazodanowe | Data transportu | Planowana data transportu |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument handlowy |  |
| ID_BDO | `System.Guid` | bazodanowe | Id nadane przez system BDO |  |
| NrRejestracyjnyPojazdu | `string` | bazodanowe | Numer rejestracyjny środka transportu |  |
| Pochodzenie | `Soneta.Handel.PochodzenieBDO` | bazodanowe, enum | Pochodzenie odpadu |  |
| StatusDokumentu | `Soneta.Handel.BDOStatus` | bazodanowe, enum | Status dokumentu w systemie BDO |  |

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

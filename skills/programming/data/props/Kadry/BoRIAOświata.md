# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BoRIAOświata`
Nazwa tabeli: `BosRIAOswiata`
Tytuł: Okresy wykonywania pracy nauczycieskiej
Opis: Bilans otwarcia rocznej informacji o zatrudnieniu (RIA) w zakresie pracy nauczycielskiej. Rejestruje okresy wykonywania pracy pedagogicznej, wymiar etatu i informację o szkołach specjalnych, wymagane przy sporządzaniu ZUS RIA.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| SzkSpecjalne | `bool` | bazodanowe |  |  |
| Wersja | `Soneta.Kadry.WersjaBoRIAOświata` (enum) | bazodanowe |  |  |
| WersjaTxt | `string` | tylko-odczyt |  |  |
| Wymiar | `Fraction` | bazodanowe |  |  |
| Zatwierdzony | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WersjaBoRIAOświata (`Soneta.Kadry.WersjaBoRIAOświata`)
- `Ustawa1982` = 1 — art.1 ustawy z 26.01.1982 karta nauczyciela (Dz.U.z 2018r.poz.967,z poź.zm) - od 01.01.1999do31.12.2008
- `Ustawa2009` = 2 — w art.2 pkt 1 ustawy z 22.05.2009 o nauczycielskich świadczeniach kompensacyjnych (Dz.U.z 2018r.poz.128) - od 01.01.1999 do 31.12.2018

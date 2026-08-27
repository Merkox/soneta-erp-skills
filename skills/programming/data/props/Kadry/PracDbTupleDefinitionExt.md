# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PracDbTupleDefinitionExt`
Nazwa tabeli: `PracTupleDefExts`
Tytuł: Rozszerzenia definicji krotek dla tabeli Pracownicy
Opis: Element szczegółowy definicji krotki (DbTupleDefinition). Rozszerzenie pola dynamicznego o konfigurację specyficzną dla kartoteki pracowników – zapis do dokumentów, katalog, powiązanie z procesem workflow i poświadczenie odbioru.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DbTupleDefinition` → `DbTupleDefinition`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaProcesu | `IDependentWfDefinition` | bazodanowe |  |  |
| DodawanyNaDokumentach | `bool` | bazodanowe |  |  |
| DodawanyNaWnioskach | `bool` | bazodanowe |  |  |
| FolderPath | `Soneta.Kadry.PracDbTupleDefinitionExt.FolderPathsExt` (enum) |  |  |  |
| Katalog | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| PoswiadczenieOdbioru | `Soneta.Core.DefinicjaPoświadczeniaOdbioru` | bazodanowe |  |  |
| UstawKatalog | `bool` | bazodanowe |  |  |
| ZapisDoDokumentow | `Soneta.Kadry.RodzajZapisuDoDokumentów` (enum) | bazodanowe |  |  |
| ZmianaKatalogu | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FolderPathsExt (`Soneta.Kadry.PracDbTupleDefinitionExt.FolderPathsExt`)
- `Domyślny` = 0
- `PracownikKadry` = 1 — Inne kadrowe
- `PracownikPłace` = 2 — Inne płacowe
- `NieWyświetlaj` = 3

### RodzajZapisuDoDokumentów (`Soneta.Kadry.RodzajZapisuDoDokumentów`)
- `Zabroniony` = 0 — Zabroniony
- `Dopuszczalny` = 1
- `Wymagany` = 2
- `TylkoPodrzędne` = 3

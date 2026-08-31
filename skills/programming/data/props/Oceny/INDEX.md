# Moduł `Oceny` — tabele biznesowe

- Opis: Moduł ocen pracowniczych. Zawiera definicje arkuszy ocen, kryteria oceniania, skale oraz mechanizmy przeprowadzania i raportowania ocen okresowych.
- Tabel: **19**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| ArkuszDefinicjiOceny | Arkusze definicji oceny | `ArkuszeDefOcen` | konfig | child: DefinicjaOceny→DefinicjaOceny |  |  | TypOceny (2) | [ArkuszDefinicjiOceny.md](ArkuszDefinicjiOceny.md) |
| ArkuszOdpowiedz |  | `ArkuszeOdp` |  |  |  |  |  | [ArkuszOdpowiedz.md](ArkuszOdpowiedz.md) |
| DefinicjaArkuszaOceny | Definicje arkuszy ocen | `DefArkuszyOcen` | konfig | root |  |  | TypOceny (2) | [DefinicjaArkuszaOceny.md](DefinicjaArkuszaOceny.md) |
| DefinicjaElementuOceny | Definicje elementów ocen | `DefElementowOcen` | konfig | root |  |  | RodzajeElementuOceny (5) | [DefinicjaElementuOceny.md](DefinicjaElementuOceny.md) |
| DefinicjaOceny | Definicje ocen | `DefinicjeOcen` | konfig | root |  |  | TypOceny (2) | [DefinicjaOceny.md](DefinicjaOceny.md) |
| DefinicjaSekcjiDokumentu | Definicja sekcji dokumentów | `DefSekcjiDok` | konfig | root |  |  |  | [DefinicjaSekcjiDokumentu.md](DefinicjaSekcjiDokumentu.md) |
| ElementSkaliOcen | Elementy skal ocen | `ElementySkalOcen` | konfig | root |  |  |  | [ElementSkaliOcen.md](ElementSkaliOcen.md) |
| KategoriaElementuOceny | Kategorie elementów ocen | `KatElementowOcen` | konfig | root |  |  | TypOceny (2) | [KategoriaElementuOceny.md](KategoriaElementuOceny.md) |
| OcenaArkusz | Arkusze oceny | `OcenyArkusze` |  | root |  |  | TypOceny (2) | [OcenaArkusz.md](OcenaArkusz.md) |
| OcenaKategoriaArkusza | Kategorie arkusza oceny | `OcenyKatArkuszy` |  | child: Arkusz→OcenaArkusz |  |  |  | [OcenaKategoriaArkusza.md](OcenaKategoriaArkusza.md) |
| OcenaOceniający | Oceniający | `OcenyOceniajacy` |  | child: Ocena→OcenaRealizacja |  |  | TypOceny (2) | [OcenaOceniający.md](OcenaOceniający.md) |
| OcenaOceniany | Oceniani | `OcenyOceniani` |  | child: Ocena→OcenaRealizacja |  |  | TypOceny (2) | [OcenaOceniany.md](OcenaOceniany.md) |
| OcenaPowiaz | Powiązanie z ankietą | `OcenyPowiaz` |  | root |  | IOceniany, IŹródłoOceny |  | [OcenaPowiaz.md](OcenaPowiaz.md) |
| OcenaPozycjaArkusza | Pozycje arkuszy ocen | `OcenyPozArkuszy` |  | root |  |  | TypOceny (2) | [OcenaPozycjaArkusza.md](OcenaPozycjaArkusza.md) |
| OcenaRealizacja | Oceny | `OcenyRealizacje` |  | root |  | IŹródłoPowiązaniaStrukturyOrganizacyjnej | TypOceny (2) | [OcenaRealizacja.md](OcenaRealizacja.md) |
| PozycjaDefinicjiArkuszaOceny | Pozycje definicji arkusza oceny | `PozDefArkuszOcen` | konfig | child: DefinicjaArkusza→DefinicjaArkuszaOceny |  |  | TypOceny (2) | [PozycjaDefinicjiArkuszaOceny.md](PozycjaDefinicjiArkuszaOceny.md) |
| SkalaOcen | Skale ocen | `SkaleOcen` | konfig | root |  |  | RodzajeSkalOcen (3) | [SkalaOcen.md](SkalaOcen.md) |
| UzasadnienieOceny | Uzasadnienia oceny | `OcenyUzas` | konfig | root |  |  |  | [UzasadnienieOceny.md](UzasadnienieOceny.md) |
| ZakresWartości | Zakresy wartości | `ZakresyWartosci` | konfig | root |  |  |  | [ZakresWartości.md](ZakresWartości.md) |


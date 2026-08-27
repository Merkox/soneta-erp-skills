# Moduł `Delegacje` — tabele biznesowe

- Opis: Moduł obsługujący delegacje służbowe. Zawiera definicje delegacji, etapy podróży, diety, koszty przejazdów, noclegi oraz rozliczenia delegacji pracowników.
- Tabel: **9**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| Delegacja | Delegacje PWS | `Delegacje` |  | root |  | IZrodloOpisuAnalitycznego |  | [Delegacja.md](Delegacja.md) |
| EtapDelegacji | Etapy delegacji | `EtapyDelegacji` |  | child: Delegacja→Delegacja |  |  |  | [EtapDelegacji.md](EtapDelegacji.md) |
| KosztDelegacji | Koszty etapu delegacji | `KosztyDelegacji` |  | root |  |  |  | [KosztDelegacji.md](KosztDelegacji.md) |
| KrajDelegacji | Kraje delegacji | `KrajeDelegacji` | konfig | root | historyczna → StawkaDelegacji | IRowWithHistory, IKrajDelegacji |  | [KrajDelegacji.md](KrajDelegacji.md) |
| KwotaNaliczeniaDelegacji | Kwoty naliczenia delegacji | `KwotaNalDeleg` |  | child: Naliczenie→NaliczenieDelegacji |  |  |  | [KwotaNaliczeniaDelegacji.md](KwotaNaliczeniaDelegacji.md) |
| NaliczenieDelegacji | Naliczenia pośrednie delegacji | `NalDelegacji` |  | child: Delegacja→Delegacja |  |  |  | [NaliczenieDelegacji.md](NaliczenieDelegacji.md) |
| StawkaDelegacji | Stawki delegacji | `StawkiDelegacji` | konfig | child: Kraj→KrajDelegacji | historia → KrajDelegacji |  |  | [StawkaDelegacji.md](StawkaDelegacji.md) |
| ZakupWalutDoDelegacji | Pozyskanie | `ZakupyWalutDeleg` |  | child: Delegacja→Delegacja |  |  |  | [ZakupWalutDoDelegacji.md](ZakupWalutDoDelegacji.md) |
| ZaliczkaDelegacji | Zaliczki do delegacji | `ZaliczkiDeleg` |  | child: Delegacja→Delegacja |  |  |  | [ZaliczkaDelegacji.md](ZaliczkaDelegacji.md) |


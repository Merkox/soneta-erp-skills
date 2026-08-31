# Moduł `Deklaracje` — tabele biznesowe

- Opis: Moduł obsługujący deklaracje podatkowe i sprawozdawcze. Zawiera szablony deklaracji, formularze XML, mechanizmy generowania i wysyłki deklaracji do urzędów.
- Tabel: **3**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| Deklaracja |  | `Deklaracje` |  | root |  | IDeklaracja, IDokumentPlatny, IDokumentKsiegowalny, IBazaZrodlaWyplaty, IEmailElement, IZrodloOpisuAnalitycznego | WersjaDeklaracji (429) | [Deklaracja.md](Deklaracja.md) |
| EDeklaracja | eDeklaracja | `EDeklaracje` |  |  |  |  |  | [EDeklaracja.md](EDeklaracja.md) |
| ETransmisja | eTransmisja | `ETransmisje` |  |  |  |  |  | [ETransmisja.md](ETransmisja.md) |


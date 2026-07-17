# Pola i właściwości klasy biznesowej: `Soneta.Place.DodatekAutomatyczny`
Nazwa tabeli: `DodAutomatyczne`
Tytuł: Dodatki automatyczne
Opis: Dodatek do wynagrodzenia naliczany automatycznie w zadanym okresie. Wiąże pracownika z definicją elementu wynagrodzenia, który jest dodawany do wypłaty bez ręcznej interwencji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| Nazwa | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |

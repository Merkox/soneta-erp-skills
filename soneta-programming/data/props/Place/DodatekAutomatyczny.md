# Pola i właściwości klasy biznesowej: `Soneta.Place.DodatekAutomatyczny`
Nazwa tabeli: `DodAutomatyczne`
Tytuł: Dodatki automatyczne
Opis: Dodatek do wynagrodzenia naliczany automatycznie w zadanym okresie. Wiąże pracownika z definicją elementu wynagrodzenia, który jest dodawany do wypłaty bez ręcznej interwencji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe, tylko-odczyt |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| Nazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |

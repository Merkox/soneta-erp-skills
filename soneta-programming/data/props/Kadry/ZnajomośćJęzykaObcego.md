# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZnajomośćJęzykaObcego`
Nazwa tabeli: `ZnJezykowObcych`
Tytuł: Znajomość języków obcych
Opis: Element szczegółowy pracownika (Pracownik). Ewidencja znajomości języka obcego z oceną poziomu mowy i pisma, informacją o zaświadczeniu (certyfikacie) i dacie jego wydania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataWydaniaZaswiadczenia | `Date` | bazodanowe | Data wydania zaświadczenia |  |
| Jezyk | `Soneta.Kadry.DefinicjaJęzykaObcego` | bazodanowe |  |  |
| Mowa | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe |  |  |
| Pismo | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| TypPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia` | bazodanowe | Typ potwierdzenia |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| Zaswiadczenie | `string` | bazodanowe | Zaświadczenie |  |

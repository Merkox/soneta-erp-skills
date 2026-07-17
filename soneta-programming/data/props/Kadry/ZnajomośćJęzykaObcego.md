# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZnajomośćJęzykaObcego`
Nazwa tabeli: `ZnJezykowObcych`
Tytuł: Znajomość języków obcych
Opis: Element szczegółowy pracownika (Pracownik). Ewidencja znajomości języka obcego z oceną poziomu mowy i pisma, informacją o zaświadczeniu (certyfikacie) i dacie jego wydania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataWydaniaZaswiadczenia | `Soneta.Types.Date` | bazodanowe | Data wydania zaświadczenia |  |
| Jezyk | `Soneta.Kadry.DefinicjaJęzykaObcego` | bazodanowe |  |  |
| Mowa | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe |  |  |
| Pismo | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| TypPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia` | bazodanowe | Typ potwierdzenia |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zaswiadczenie | `string` | bazodanowe | Zaświadczenie |  |

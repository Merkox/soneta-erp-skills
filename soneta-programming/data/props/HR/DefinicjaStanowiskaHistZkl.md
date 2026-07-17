# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaStanowiskaHistZkl`
Nazwa tabeli: `ZklDefStanHist`
Tytuł: Dane ZKL historii definicji stanowisk
Opis: Rozszerzenie ZKL zapisu historii definicji stanowiska (DefinicjaStanowiskaHist). Zawiera pola dostępne wyłącznie przy włączonej obsłudze ZKL definicji stanowisk.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiskaHist` → `DefinicjaStanowiskaHist`

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CelStanowiska | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DefinicjaStanowiskaHist | `Soneta.HR.DefinicjaStanowiskaHist` | bazodanowe, guided-parent |  |  |
| IloscWakatow | `Soneta.Types.Fraction` | bazodanowe | Ilość wakatów | Planowana ilość wakatów (etatów) dla zapisu historii definicji stanowiska w kontekście ZKL definicji stanowisk. |
| InformacjeDodatkowe | `Soneta.Business.MemoText` | bazodanowe | Informacje dodatkowe |  |
| OdpowiedzialnoscKierownicza | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OdpowiedzialnoscMaterialna | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OdpowiedzialnoscPracownicza | `Soneta.Business.MemoText` | bazodanowe |  |  |
| RaportPlacowyDolnyKwartylWynagrodzeniaBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| RaportPlacowyGornyKwartylWynagrodzeniaBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| RaportPlacowyKod | `string` | bazodanowe |  |  |
| RaportPlacowyMaksymalneWynagrodzenieBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| RaportPlacowyMedianaWynagrodzeniaBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| RaportPlacowyMinimalneWynagrodzenieBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| RaportPlacowyNazwaStanowiska | `string` | bazodanowe |  |  |
| RaportPlacowyStawka | `string` | bazodanowe |  |  |
| RaportujeDo | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| StanowiskoKluczowe | `bool` | bazodanowe |  |  |
| SymbolZKL | `string` |  |  |  |
| UprawnieniaPracownicze | `Soneta.Business.MemoText` | bazodanowe |  |  |
| WspolpracaZewnetrzna | `string` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna | Jednostka organizacyjna przypisana do zapisu historii definicji stanowiska w kontekście ZKL definicji stanowisk. |
| ZakresObowiazkow | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ZastepstwoAktywne | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |

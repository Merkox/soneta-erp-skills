# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaStanowiskaHistZkl`
Nazwa tabeli: `ZklDefStanHist`
Tytuł: Dane ZKL historii definicji stanowisk
Opis: Rozszerzenie ZKL zapisu historii definicji stanowiska (DefinicjaStanowiskaHist). Zawiera pola dostępne wyłącznie przy włączonej obsłudze ZKL definicji stanowisk.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiskaHist` → `DefinicjaStanowiskaHist`

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 7
- subrowy: 0
- razem: 23

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CelStanowiska | `MemoText` | bazodanowe, podlista |  |  |
| DefinicjaStanowiskaHist | `Soneta.HR.DefinicjaStanowiskaHist` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| IloscWakatow | `Fraction` | bazodanowe | Ilość wakatów | Planowana ilość wakatów (etatów) dla zapisu historii definicji stanowiska w kontekście ZKL definicji stanowisk. |
| InformacjeDodatkowe | `MemoText` | bazodanowe, podlista | Informacje dodatkowe |  |
| OdpowiedzialnoscKierownicza | `MemoText` | bazodanowe, podlista |  |  |
| OdpowiedzialnoscMaterialna | `MemoText` | bazodanowe, podlista |  |  |
| OdpowiedzialnoscPracownicza | `MemoText` | bazodanowe, podlista |  |  |
| RaportPlacowyDolnyKwartylWynagrodzeniaBrutto | `Currency` | bazodanowe |  |  |
| RaportPlacowyGornyKwartylWynagrodzeniaBrutto | `Currency` | bazodanowe |  |  |
| RaportPlacowyKod | `string` | bazodanowe |  |  |
| RaportPlacowyMaksymalneWynagrodzenieBrutto | `Currency` | bazodanowe |  |  |
| RaportPlacowyMedianaWynagrodzeniaBrutto | `Currency` | bazodanowe |  |  |
| RaportPlacowyMinimalneWynagrodzenieBrutto | `Currency` | bazodanowe |  |  |
| RaportPlacowyNazwaStanowiska | `string` | bazodanowe |  |  |
| RaportPlacowyStawka | `string` | bazodanowe |  |  |
| RaportujeDo | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| StanowiskoKluczowe | `bool` | bazodanowe |  |  |
| SymbolZKL | `string` | tylko-odczyt |  |  |
| UprawnieniaPracownicze | `MemoText` | bazodanowe, podlista |  |  |
| WspolpracaZewnetrzna | `string` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna | Jednostka organizacyjna przypisana do zapisu historii definicji stanowiska w kontekście ZKL definicji stanowisk. |
| ZakresObowiazkow | `MemoText` | bazodanowe, podlista |  |  |
| ZastepstwoAktywne | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |

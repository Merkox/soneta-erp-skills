# Pola i właściwości klasy biznesowej: `Soneta.Kalend.KodZdarzeniaRCP`
Nazwa tabeli: `KodyZdarzenRCP`
Tytuł: Kody zdarzeń RCP
Opis: Element szczegółowy czytnika RCP (CzytnikRCP). Mapowanie kodu zdarzenia odczytywanego z czytnika na definicję zdarzenia RCP w systemie, umożliwiające interpretację surowych danych z urządzenia rejestrującego.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `CzytnikRCP` → `CzytnikRCP`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzytnikRCP | `Soneta.Kalend.CzytnikRCP` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaZdarzenia | `Soneta.Kalend.DefinicjaZdarzeniaRCP` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |

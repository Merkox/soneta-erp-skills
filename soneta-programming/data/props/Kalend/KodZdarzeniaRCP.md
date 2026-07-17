# Pola i właściwości klasy biznesowej: `Soneta.Kalend.KodZdarzeniaRCP`
Nazwa tabeli: `KodyZdarzenRCP`
Tytuł: Kody zdarzeń RCP
Opis: Element szczegółowy czytnika RCP (CzytnikRCP). Mapowanie kodu zdarzenia odczytywanego z czytnika na definicję zdarzenia RCP w systemie, umożliwiające interpretację surowych danych z urządzenia rejestrującego.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `CzytnikRCP` → `CzytnikRCP`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzytnikRCP | `Soneta.Kalend.CzytnikRCP` | bazodanowe, guided-parent |  |  |
| DefinicjaZdarzenia | `Soneta.Kalend.DefinicjaZdarzeniaRCP` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |

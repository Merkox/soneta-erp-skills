# Pola i właściwości klasy biznesowej: `Soneta.Kalend.KodZdarzeniaRCP`
Nazwa tabeli: `KodyZdarzenRCP`
Tytuł: Kody zdarzeń RCP
Opis: Element szczegółowy czytnika RCP (CzytnikRCP). Mapowanie kodu zdarzenia odczytywanego z czytnika na definicję zdarzenia RCP w systemie, umożliwiające interpretację surowych danych z urządzenia rejestrującego.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `CzytnikRCP` → `CzytnikRCP`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzytnikRCP | `Soneta.Kalend.CzytnikRCP` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaZdarzenia | `Soneta.Kalend.DefinicjaZdarzeniaRCP` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |

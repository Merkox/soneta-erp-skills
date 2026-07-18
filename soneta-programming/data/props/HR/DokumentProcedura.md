# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.ZasobyINarzedzia.DokumentProcedura`
Nazwa tabeli: `ZklDokProc`
Tytuł: Dokumenty i procedury
Opis: Zawiera listę dokumentów, instrukcji i procedur, z którymi pracownik musi być zaznajomiony na danym stanowisku. Jest używany w opisie ogólnym stanowiska do określenia obowiązków formalnych i organizacyjnych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |

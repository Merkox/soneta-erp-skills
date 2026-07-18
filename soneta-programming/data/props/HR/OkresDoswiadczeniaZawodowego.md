# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.OkresDoswiadczeniaZawodowego`
Nazwa tabeli: `ZklOkrDosZwd`
Tytuł: Okresy doświadczenia zawodowego
Opis: Słownik określa przedziały doświadczenia zawodowego, np. 0–6 miesięcy. W profilu kwalifikacji umożliwia standaryzację wymagań doświadczenia na stanowisku.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |

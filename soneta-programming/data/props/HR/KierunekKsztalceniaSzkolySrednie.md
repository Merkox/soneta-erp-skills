# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.KierunekKsztalceniaSzkolySrednie`
Nazwa tabeli: `ZklKierKszSre`
Tytuł: Kierunki kształcenia szkoły średnie
Opis: Zawiera listę kierunków kształcenia realizowanych na poziomie szkół średnich. W profilu kwalifikacji pozwala jednoznacznie określić wymagane lub preferowane wykształcenie na stanowisku.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |

# Pola i właściwości klasy biznesowej: `Soneta.EwidencjaVat.DefinicjaPowstaniaObowiazkuVAT`
Nazwa tabeli: `DefinicjePOVAT`
Tytuł: Definicje powstania obowiązku VAT
Opis: Definicja momentu powstania obowiązku podatkowego VAT. Określa zasady rozliczania (memoriałowe, kasowe), warunki powstania obowiązku oraz termin prawa do odliczenia. Służy do automatycznego ustalania daty obowiązku VAT na dokumentach zakupu i sprzedaży.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PowstanieObowiazku | `Soneta.EwidencjaVat.PowstanieObowiazkuVAT` | bazodanowe |  |  |
| PowstanieObowiazku.IloscDniWarunku | `int` | bazodanowe |  |  |
| PowstanieObowiazku.Kasowe | `Soneta.EwidencjaVat.RozliczenieKasoweVAT` | bazodanowe, enum |  |  |
| PowstanieObowiazku.Memorialowe | `Soneta.EwidencjaVat.RozliczenieMemorialoweVAT` | bazodanowe, enum |  |  |
| PowstanieObowiazku.Warunek | `Soneta.EwidencjaVat.WarunekRozliczeniaVAT` | bazodanowe, enum |  |  |
| PowstanieObowiazku.WarunekPrawoOdliczenia | `bool` | bazodanowe | Prawo odliczenia | Prawo odliczenia VAT, jeżeli rozliczony przez wypełnienie warunku |
| PowstanieObowiazku.Zasada | `Soneta.EwidencjaVat.ZasadaRozliczaniaVAT` | bazodanowe, enum |  |  |
| Typ | `Soneta.EwidencjaVat.TypTytułuObowiązkuVAT` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RozliczenieKasoweVAT (`Soneta.EwidencjaVat.RozliczenieKasoweVAT`)
- `CząstkowoPrzyRozliczeniach` = 0 — Cząstkowo Przy Rozliczeniach
- `PoCałkowitymRozliczeniu` = 1 — Po Całkowitym Rozliczeniu

### RozliczenieMemorialoweVAT (`Soneta.EwidencjaVat.RozliczenieMemorialoweVAT`)
- `WgDatyZaewidencjonowania` = 0 — Wg Daty Zaewidencjonowania
- `WgDatyWplywu` = 1 — Wg Daty Wpływu
- `WgDatyWystawienia` = 2 — Wg Daty Wystawienia
- `WgDatyOperacji` = 3 — Wg Daty Operacji
- `WgTerminuPłatności` = 4 — Wg Terminu Płatności
- `WgDowolnejDaty` = 5 — Wg Dowolnej Daty

### TypTytułuObowiązkuVAT (`Soneta.EwidencjaVat.TypTytułuObowiązkuVAT`)
- `Sprzedaż` = 0 — Sprzedaż
- `Zakup` = 1 — Zakup
- `SprzedażAkcyza` = 2 — Sprzedaż akcyza
- `ZakupAkcyza` = 3 — Zakup akcyza

### WarunekRozliczeniaVAT (`Soneta.EwidencjaVat.WarunekRozliczeniaVAT`)
- `Brak` = 0 — Brak
- `DniOdDatyWplywu` = 1 — Dni Od Daty Wpływu
- `DniOdDatyWystawienia` = 2 — Dni Od Daty Wystawienia
- `DniOdDatyOperacji` = 3 — Dni Od Daty Operacji
- `DniOdDatyZaewidencjonowania` = 4 — Dni Od Daty Zaewidencjonowania
- `TerminPłatności` = 5 — Termin Płatności
- `DowolnaData` = 6 — Dowolna Data
- `DniaNastępnegoMiesiącaWgDatyOperacji` = 7 — Dnia Następnego Miesiąca Wg Daty Operacji

### ZasadaRozliczaniaVAT (`Soneta.EwidencjaVat.ZasadaRozliczaniaVAT`)
- `Memoriałowa` = 0 — Memoriałowa
- `Kasowa` = 1 — Kasowa

# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.WynikZestKS`
Nazwa tabeli: `WynikiZestKS`
Tytuł: Wyniki zestawień księgowych
Opis: Zapisany wynik obliczenia zestawienia księgowego. Przechowuje nazwę, datę utworzenia, parametry wywołania (okres obrachunkowy, zakres dat, bufor, firmy) oraz wygenerowane dane w formacie XML. Wyniki mogą być publikowane w pulpicie klienta biura rachunkowego.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| CzasModyfikacji | `System.DateTime?` | bazodanowe |  |  |
| CzasUtworzenia | `System.DateTime` | bazodanowe |  |  |
| DlaPulpituKB | `bool` | bazodanowe | Pulpit BR |  |
| Firmy | `string` |  |  |  |
| InCorrectionMode | `bool` |  |  |  |
| Kolumny | `Soneta.Business.SubTable<Soneta.Ksiega.KolumnaWynikuZestKS>` |  |  |  |
| Komorki | `Soneta.Business.SubTable<Soneta.Ksiega.KomorkaWynikuZestKS>` |  |  |  |
| KorektaReczna | `bool` |  | Wykonana korekta ręczna |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział |  |
| Pozycje | `Soneta.Business.SubTable<Soneta.Ksiega.PozycjaWynikuZestKS>` |  |  |  |
| PrmBufor | `bool` | bazodanowe |  |  |
| PrmDekretyZamkniecia | `bool` | bazodanowe |  |  |
| PrmFirmy | `Soneta.Core.OddzialFirmy[]` |  | Firmy |  |
| PrmFirmyMemo | `Soneta.Business.MemoText` | bazodanowe |  |  |
| PrmOkres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PrmOkresKS | `string` | bazodanowe |  |  |
| PrmTypObrotu | `Soneta.Ksiega.TypObrotu` | bazodanowe, enum |  |  |
| XML | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zatwierdzony | `bool` |  |  |  |
| Zestawienie | `Soneta.Ksiega.ZestawienieKS` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypObrotu (`Soneta.Ksiega.TypObrotu`)
- `Księgowy` = 0 — Księgowy
- `Podatkowy` = 1

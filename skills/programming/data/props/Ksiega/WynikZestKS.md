# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.WynikZestKS`
Nazwa tabeli: `WynikiZestKS`
Tytuł: Wyniki zestawień księgowych
Opis: Zapisany wynik obliczenia zestawienia księgowego. Przechowuje nazwę, datę utworzenia, parametry wywołania (okres obrachunkowy, zakres dat, bufor, firmy) oraz wygenerowane dane w formacie XML. Wyniki mogą być publikowane w pulpicie klienta biura rachunkowego.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| CzasModyfikacji | `System.DateTime?` | bazodanowe, tylko-odczyt |  |  |
| CzasUtworzenia | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
| DlaPulpituKB | `bool` | bazodanowe | Pulpit BR |  |
| Firmy | `string` | tylko-odczyt |  |  |
| InCorrectionMode | `bool` | tylko-odczyt |  |  |
| Kolumny | `SubTable<Soneta.Ksiega.KolumnaWynikuZestKS>` | podlista |  |  |
| Komorki | `SubTable<Soneta.Ksiega.KomorkaWynikuZestKS>` | podlista |  |  |
| KorektaReczna | `bool` | tylko-odczyt | Wykonana korekta ręczna |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział |  |
| Pozycje | `SubTable<Soneta.Ksiega.PozycjaWynikuZestKS>` | podlista |  |  |
| PrmBufor | `bool` | bazodanowe, tylko-odczyt |  |  |
| PrmDekretyZamkniecia | `bool` | bazodanowe, tylko-odczyt |  |  |
| PrmFirmy | `Soneta.Core.OddzialFirmy[]` | podlista | Firmy |  |
| PrmFirmyMemo | `MemoText` | bazodanowe, podlista |  |  |
| PrmOkres | `FromTo` | bazodanowe, podlista |  |  |
| PrmOkresKS | `string` | bazodanowe, tylko-odczyt |  |  |
| PrmTypObrotu | `Soneta.Ksiega.TypObrotu` (enum) | bazodanowe, tylko-odczyt |  |  |
| XML | `MemoText` | bazodanowe, podlista |  |  |
| Zatwierdzony | `bool` |  |  |  |
| Zestawienie | `Soneta.Ksiega.ZestawienieKS` | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypObrotu (`Soneta.Ksiega.TypObrotu`)
- `Księgowy` = 0 — Księgowy
- `Podatkowy` = 1

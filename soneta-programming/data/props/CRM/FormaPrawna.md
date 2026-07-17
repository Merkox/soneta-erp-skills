# Pola i właściwości klasy biznesowej: `Soneta.CRM.FormaPrawna`
Nazwa tabeli: `FormyPrawne`
Tytuł: Formy prawne
Opis: Słownik form prawnych podmiotów gospodarczych (np. spółka z o.o., osoba fizyczna, spółka akcyjna). Określa status podmiotu, domyślność formy oraz powiązanie z kodami GUS i sprawozdawczością finansową.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Określa widoczność formy prawnej na listach |
| Domyslna | `bool` | bazodanowe | Domyślna | Oznaczenie domyślnej formy prawnej w obrębie statusu podmiotu |
| Kod | `string` | bazodanowe | Kod | Kod formy prawnej |
| KodyGUS | `string` | bazodanowe | Kody GUS | Lista kodów GUS odpowiadających formie prawnej |
| KodySF | `string` | bazodanowe | Kod formy prawnej sprawozdania finansowego | Kody odpowiadających formie prawnej dla sprawozdania finansowego |
| LogujReferencje | `bool` | bazodanowe | Loguj referencje | Logowanie referencji do podmiotu |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa formy prawnej |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` | bazodanowe, enum | Status podmiotu | Uszczegółowienie formy prawnej |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusPodmiotu (`Soneta.Core.StatusPodmiotu`)
- `PodmiotGospodarczy` = 0
- `Finalny` = 1

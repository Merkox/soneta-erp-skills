# Pola i właściwości klasy biznesowej: `Soneta.Core.ZestawPodzielnikowKosztow`
Nazwa tabeli: `ZestPodzKosztow`
Tytuł: Zestawy podzielników kosztów
Opis: Zestaw grupujący podzielniki kosztów. Pozwala organizować podzielniki kosztów w nazwane zestawy wykorzystywane do rozdziału kosztów na centra kosztów lub inne elementy słownikowe.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZrodloPodzielnikaKosztow`

- pola bazodanowe: 1
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe | Ogólne |  |
| Podzielniki | `Soneta.Business.SubTable<Soneta.Core.PodzielnikKosztow>` |  |  |  |

# Pola i właściwości klasy biznesowej: `Soneta.Handel.DokumentHandlowyKoszt`
Nazwa tabeli: `DokHandloweKoszt`
Tytuł: Koszty dodatkowe
Opis: Koszt dodatkowy przypisany do dokumentu handlowego (np. transport, ubezpieczenie). Określa kwotę oraz rodzaj kosztu: fakturowy, magazynowy lub statystyczny.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywność kosztu | Określa, czy koszt dodatkowy jest aktywny. |
| Data | `Date` | tylko-odczyt |  |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  |  |
| Fakturowy | `bool` | bazodanowe | Koszt fakturowy | Wartość doliczana do kosztu fakturowego. |
| KosztNadrzedny | `Soneta.Handel.DokumentHandlowyKoszt` | bazodanowe | Koszt nadrzędny | Koszt nadrzędny. |
| Kwota | `Currency` | bazodanowe | Kwota kosztu | Kwota kosztu dodatkowego. |
| Magazynowy | `bool` | bazodanowe | Koszt magazynowy | Wartość doliczana do kosztu magazynowgo. |
| Opis | `string` | bazodanowe | Opis | Opis kosztu. |
| Statystyczny | `bool` | bazodanowe | Koszt statystyczny | Wartość doliczana do kosztu statystycznego. |
| ZrodloKosztu | `Soneta.Core.IZrodloKosztuDodatkowego` | bazodanowe |  |  |

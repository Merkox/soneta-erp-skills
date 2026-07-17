# Pola i właściwości klasy biznesowej: `Soneta.Handel.DokumentHandlowyKoszt`
Nazwa tabeli: `DokHandloweKoszt`
Tytuł: Koszty dodatkowe
Opis: Koszt dodatkowy przypisany do dokumentu handlowego (np. transport, ubezpieczenie). Określa kwotę oraz rodzaj kosztu: fakturowy, magazynowy lub statystyczny.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywność kosztu | Określa, czy koszt dodatkowy jest aktywny. |
| Data | `Soneta.Types.Date` |  |  |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  |  |
| Fakturowy | `bool` | bazodanowe | Koszt fakturowy | Wartość doliczana do kosztu fakturowego. |
| KosztNadrzedny | `Soneta.Handel.DokumentHandlowyKoszt` | bazodanowe | Koszt nadrzędny | Koszt nadrzędny. |
| Kwota | `Soneta.Types.Currency` | bazodanowe | Kwota kosztu | Kwota kosztu dodatkowego. |
| Magazynowy | `bool` | bazodanowe | Koszt magazynowy | Wartość doliczana do kosztu magazynowgo. |
| Opis | `string` | bazodanowe | Opis | Opis kosztu. |
| Statystyczny | `bool` | bazodanowe | Koszt statystyczny | Wartość doliczana do kosztu statystycznego. |
| ZrodloKosztu | `Soneta.Core.IZrodloKosztuDodatkowego` | bazodanowe |  |  |

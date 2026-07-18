# Pola i właściwości klasy biznesowej: `Soneta.Handel.UslDodPrzesyl`
Nazwa tabeli: `UslDodPrzesylek`
Tytuł: Usługi dodatkowe przesyłki
Opis: Usługa dodatkowa przypisana do przesyłki kurierskiej na dokumencie handlowym (np. ubezpieczenie, pobranie). Zawiera kwotę i godzinę usługi.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokumentHandlowy | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument handlowy |  |
| Godzina | `Time` | bazodanowe | Godzina | Godzina przypisana do usługi. |
| Kwota | `Currency` | bazodanowe | Kwota | Kwota przypisana do usługi dodatkowej. |
| PrzesylkaSpedytor | `Soneta.Handel.PrzesylkaSpedyt` | bazodanowe | Przesyłka kurierska |  |
| UslugaDodatkowa | `Soneta.Core.SlownikElem` | bazodanowe | Usługa dodatkowa |  |

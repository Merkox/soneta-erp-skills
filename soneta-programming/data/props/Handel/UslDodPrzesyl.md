# Pola i właściwości klasy biznesowej: `Soneta.Handel.UslDodPrzesyl`
Nazwa tabeli: `UslDodPrzesylek`
Tytuł: Usługi dodatkowe przesyłki
Opis: Usługa dodatkowa przypisana do przesyłki kurierskiej na dokumencie handlowym (np. ubezpieczenie, pobranie). Zawiera kwotę i godzinę usługi.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokumentHandlowy | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument handlowy |  |
| Godzina | `Soneta.Types.Time` | bazodanowe | Godzina | Godzina przypisana do usługi. |
| Kwota | `Soneta.Types.Currency` | bazodanowe | Kwota | Kwota przypisana do usługi dodatkowej. |
| PrzesylkaSpedytor | `Soneta.Handel.PrzesylkaSpedyt` | bazodanowe | Przesyłka kurierska |  |
| UslugaDodatkowa | `Soneta.Core.SlownikElem` | bazodanowe | Usługa dodatkowa |  |

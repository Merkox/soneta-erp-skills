# Pola i właściwości klasy biznesowej: `Soneta.Towary.WariantTowaru`
Nazwa tabeli: `WariantyTowaru`
Tytuł: Warianty towaru
Opis: Element szczegółowy towaru (Towar). Definiuje warianty towaru bazowego, np. różne rozmiary, kolory lub konfiguracje. Każdy wariant wskazuje na inny towar z kartoteki, co pozwala grupować powiązane artykuły pod jednym towarem nadrzędnym.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt | Towar | Towar, do którego przypisany jest wariant. |
| Wariant | `Soneta.Towary.Towar` | bazodanowe | Wariant | Wariant towaru. |

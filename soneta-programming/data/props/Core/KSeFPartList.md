# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFPartList`
Nazwa tabeli: `KSeFPartLists`
Tytuł: KSeFZapytaniaOFaktury
Opis: Pakiet (część) danych zwróconych z KSeF w odpowiedzi na zapytanie o faktury. Zawiera numer referencyjny pakietu, nazwę, zakres dat, datę ważności, rozmiar, algorytm szyfrowania, kodowanie, URL do pobrania oraz status pobrania.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| HttpMethod | `string` | bazodanowe | Metoda HTTP | Metoda HTTP, której należy użyć przy pobieraniu pliku. |
| PartRange | `Soneta.Types.FromTo` |  |  |  |
| Pobrane | `bool` | bazodanowe | Pobrane | Informacja mówi czy część została pobrana |
| Url | `Soneta.Business.MemoText` | bazodanowe | Adres URL | Adres URL, pod który należy wysłać żądanie pobrania. |
| algorithm | `string` | bazodanowe | Algorytm | Algorytm szyfrowania |
| encoding | `string` | bazodanowe | Kodowanie | Kodowanie danych w pakiecie |
| fileSize | `int` | bazodanowe | Rozmiar | Rozmiar pakietu |
| partExpiration | `string` | bazodanowe | Ważny do | Data i godzina ważności pakietu |
| partName | `string` | bazodanowe | Wysłano | Data i godzina wykonania zapytania |
| partNumber | `int` | bazodanowe | Numer pakietu | Numer pakietu |
| partRangeFrom | `string` | bazodanowe | Data od | Data od |
| partRangeTo | `string` | bazodanowe | Data do | Data do |
| partReferenceNumber | `string` | bazodanowe | Numer referencyjny | Numer referencyjny pakietu |
| queryElementReferenceNumber | `string` | bazodanowe |  | Numer referencyjny elementu |
| queryReferenceNumber | `string` | bazodanowe | Numer referencyjny | Numer referencyjny zapytania |
| value | `string` | bazodanowe | Zawartość | Zawartość binarna pakietu |

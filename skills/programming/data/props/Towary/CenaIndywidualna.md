# Pola i właściwości klasy biznesowej: `Soneta.Towary.CenaIndywidualna`
Nazwa tabeli: `CenyIndywidualne`
Opis: Element szczegółowy towaru (Towar). Przechowuje cenę indywidualną towaru przypisaną do konkretnego kontrahenta lub grupy kontrahentów. Umożliwia negocjowanie indywidualnych warunków cenowych i rabatowych, w tym progów ilościowych, dla poszczególnych odbiorców lub dostawców.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Brutto | `DoubleCy` | bazodanowe |  | Kwota brutto ceny kontrahenta |
| Grupa | `Db.DictionaryItem` | bazodanowe, tylko-odczyt |  | Wartość słownika, dla którego jest przypisana cena grupowa. |
| Jednostka | `Soneta.Towary.Jednostka` |  |  |  |
| KodTowaru | `string` |  |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt |  | Kontrahent, dla którego jest przypisana cena kontrahenta. |
| MarżaOstatniejCeny | `DoubleCy` | tylko-odczyt |  | Marża wyliczona w stosunku do ostatniej ceny zakupu (netto) |
| NazwaTowaru | `string` | bazodanowe |  | Indywidualna nazwa kontrahenta dla towaru. |
| Netto | `DoubleCy` | bazodanowe |  | Kwota netto ceny kontrahenta |
| Polacz | `bool` | bazodanowe | Połącz | Wymusza wzajemne przeliczanie ceny netto i brutto. |
| ProcentMarżyOstatniejCeny | `Percent` | tylko-odczyt |  | Procent marży liczony od tej ceny (wstecz) w stosunku do ostatniej ceny zakupu. |
| ProcentNarzutuOstatniejCeny | `Percent` | tylko-odczyt |  | Procent narzutu dodawany do ostatniej ceny zakupu. |
| Prog | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Próg minimalny rabatu ilościowego. |
| Rabat | `Percent` | bazodanowe |  | Procent rabatu towaru dla kontrahenta lub grupy. |
| RabatZdefiniowany | `bool` | bazodanowe |  | Określa, czy rabat został wprowadzony. |
| StandardowaIlosc | `Soneta.Towary.Quantity` | bazodanowe |  |  |
| StandardowaIlość | `double` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt, guided-parent |  | Towar, któremu przyporządkowana jest cena indywidualna. |
| Zdefiniowana | `bool` | bazodanowe |  | Czy cena kontrahenta została określona. |

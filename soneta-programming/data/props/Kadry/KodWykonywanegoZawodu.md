# Pola i właściwości klasy biznesowej: `Soneta.Kadry.KodWykonywanegoZawodu`
Nazwa tabeli: `KodyWykZawodow`
Tytuł: Kody GUS zawodów
Opis: Słownik kodów zawodów zgodnych z klasyfikacją GUS. Każdy wpis zawiera kod numeryczny i nazwę zawodu, wykorzystywany przy zgłoszeniach do ZUS oraz sprawozdawczości statystycznej.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| KodGUS | `string` | bazodanowe | Kod GUS | Kod GUS zawodu. |
| Nazwa | `string` | bazodanowe |  | Nazwa zawodu. |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |

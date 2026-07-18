# Pola i właściwości klasy biznesowej: `Soneta.Towary.KodCN`
Nazwa tabeli: `KodyCN`
Opis: Słownik kodów Nomenklatury Scalonej (CN) stosowanych w obrocie międzynarodowym i deklaracjach Intrastat. Każdy kod posiada ośmiocyfrowy symbol, opis, opcjonalną jednostkę uzupełniającą oraz informację o wymagalności masy netto i powiązanej stawce VAT.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStawkiVAT | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe | Definicja stawki VAT |  |
| JednostkaUzupelniajaca | `Soneta.Towary.Jednostka` | bazodanowe | Jednostka uzupełniająca |  |
| Kod | `string` | bazodanowe | Kod |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| WymagaMasyNetto | `bool` | bazodanowe |  |  |

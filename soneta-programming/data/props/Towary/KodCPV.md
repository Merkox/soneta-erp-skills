# Pola i właściwości klasy biznesowej: `Soneta.Towary.KodCPV`
Nazwa tabeli: `KodyCPV`
Opis: Słownik kodów CPV (Wspólny Słownik Zamówień) stosowanych w zamówieniach publicznych do klasyfikacji przedmiotu zamówienia. Kody mają strukturę hierarchiczną z relacją nadrzędny-podrzędny, co umożliwia wielopoziomowe grupowanie towarów i usług.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `string` | bazodanowe |  |  |
| Nadrzedny | `Soneta.Towary.KodCPV` | bazodanowe, tylko-odczyt | Nadrzędny |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Podrzedne | `SubTable<Soneta.Towary.KodCPV>` | podlista |  |  |

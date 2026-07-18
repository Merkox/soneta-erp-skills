# Pola i właściwości klasy biznesowej: `Soneta.Towary.CenaGrupowa`
Nazwa tabeli: `CenyGrupowe`
Opis: Cena grupowa przypisana na przecięciu grupy towarowej, kontrahenta (lub grupy kontrahentów) i definicji cennika. Umożliwia masowe ustalanie rabatów i warunków cenowych dla kategorii towarów bez konieczności definiowania cen na poziomie poszczególnych artykułów.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaCeny | `Soneta.Towary.DefinicjaCeny` | bazodanowe |  | Definicja ceny wykorzystywana do wyliczeń. |
| Grupa | `Db.DictionaryItem` | bazodanowe, tylko-odczyt |  | Wartość słownika, dla którego jest przypisana cena grupowa. |
| GrupaTowarowa | `Db.DictionaryItem` | bazodanowe, tylko-odczyt |  | Grupa towarowa, której przyporządkowana jest cena. |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt |  | Kontrahent, dla którego jest przypisana cena kontrahenta. |
| Rabat | `Percent` | bazodanowe |  | Procent rabatu towaru dla kontrahenta lub grupy. |
| RabatZdefiniowany | `bool` | bazodanowe |  | Określa, czy rabat został wprowadzony. |
| RabatujPromocje | `bool` | bazodanowe |  |  |

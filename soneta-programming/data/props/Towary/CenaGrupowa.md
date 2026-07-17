# Pola i właściwości klasy biznesowej: `Soneta.Towary.CenaGrupowa`
Nazwa tabeli: `CenyGrupowe`
Opis: Cena grupowa przypisana na przecięciu grupy towarowej, kontrahenta (lub grupy kontrahentów) i definicji cennika. Umożliwia masowe ustalanie rabatów i warunków cenowych dla kategorii towarów bez konieczności definiowania cen na poziomie poszczególnych artykułów.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaCeny | `Soneta.Towary.DefinicjaCeny` | bazodanowe |  | Definicja ceny wykorzystywana do wyliczeń. |
| Grupa | `Soneta.Business.Db.DictionaryItem` | bazodanowe |  | Wartość słownika, dla którego jest przypisana cena grupowa. |
| GrupaTowarowa | `Soneta.Business.Db.DictionaryItem` | bazodanowe |  | Grupa towarowa, której przyporządkowana jest cena. |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  | Kontrahent, dla którego jest przypisana cena kontrahenta. |
| Rabat | `Soneta.Types.Percent` | bazodanowe |  | Procent rabatu towaru dla kontrahenta lub grupy. |
| RabatZdefiniowany | `bool` | bazodanowe |  | Określa, czy rabat został wprowadzony. |
| RabatujPromocje | `bool` | bazodanowe |  |  |

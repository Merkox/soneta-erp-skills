# Pola i właściwości klasy biznesowej: `Soneta.Business.Runtime.RuntimeRowRelation`
Nazwa tabeli: `RuntimeRowRels`
Tytuł: Relacje wierszy runtime
Opis: Powiązanie wiersza dynamicznego (runtime) z rekordem biznesowym. Umożliwia tworzenie relacji między zdarzeniami a obiektami z modułów programu.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `Runtime.RuntimeFieldDefinition` | bazodanowe, tylko-odczyt | Definicja | Definicja pola dokumentu |
| Host | `IGuidedRow` | bazodanowe | Rekord powiązany | Rekord powiązany |
| Primary | `bool` | bazodanowe, tylko-odczyt | Podstawowa | Relacja podstawowa |
| RuntimeRowHost | `Runtime.IRuntimeRow` | bazodanowe, tylko-odczyt | Wiersz runtime | Wiersz runtime |

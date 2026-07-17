# Pola i właściwości klasy biznesowej: `Soneta.Kasa.BankowoscElektroniczna.SerwisBankowy`
Nazwa tabeli: `SerwisyBankowe`
Tytuł: Serwis bankowy
Opis: Definicja serwisu bankowości elektronicznej online umożliwiającego bezpośrednią komunikację z bankiem. Identyfikuje usługę bankową po unikalnym identyfikatorze i nazwie, z możliwością przypisania do oddziału firmy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IsActive | `bool` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa usługi |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Parametry | `Soneta.Business.SubTable<Soneta.Kasa.BankowoscElektroniczna.ParametrySerwisuBankowego>` |  |  |  |
| ServiceId | `System.Guid` | bazodanowe |  |  |
| ServiceUri | `string` |  |  |  |

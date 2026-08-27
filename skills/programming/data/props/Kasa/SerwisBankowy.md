# Pola i właściwości klasy biznesowej: `Soneta.Kasa.BankowoscElektroniczna.SerwisBankowy`
Nazwa tabeli: `SerwisyBankowe`
Tytuł: Serwis bankowy
Opis: Definicja serwisu bankowości elektronicznej online umożliwiającego bezpośrednią komunikację z bankiem. Identyfikuje usługę bankową po unikalnym identyfikatorze i nazwie, z możliwością przypisania do oddziału firmy.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IsActive | `bool` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe, tylko-odczyt | Nazwa usługi |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt |  |  |
| Parametry | `SubTable<Soneta.Kasa.BankowoscElektroniczna.ParametrySerwisuBankowego>` | podlista |  |  |
| ServiceId | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| ServiceUri | `string` | tylko-odczyt |  |  |

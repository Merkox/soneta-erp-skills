# Pola i właściwości klasy biznesowej: `Soneta.Core.DaneKontaktowe`
Nazwa tabeli: `DaneKnt`
Tytuł: Dane kontaktowe
Opis: Element szczegółowy hosta danych kontaktowych (IDaneKontaktoweHost). Przechowuje konkretną daną kontaktową (numer telefonu, adres e-mail itp.) z rodzajem kontaktu, opisem, flagą domyślności i opcjonalnym powiązaniem z adresem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IDaneKontaktoweHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresExt | `Soneta.Core.AdresExt` | bazodanowe | Adres |  |
| CeleKontaktu | `SubTable<Soneta.Core.CelKontaktu>` | podlista |  |  |
| Domyslny | `bool` | bazodanowe | Domyślny | Określa domyślny kontakt. |
| Host | `Soneta.Core.IDaneKontaktoweHost` | bazodanowe, guided-parent, iface-ref | Host kontaktu |  |
| Kontakt | `string` | bazodanowe | Kontakt | Kontakt. |
| Opis | `string` | bazodanowe | Opis | Krótki opis kontaktu. |
| Rodzaj | `Soneta.Core.RodzajKontaktu` | bazodanowe | Rodzaj kontaktu | Rodzaj kontaktu. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IDaneKontaktoweHost` | `Bank`, `DaneKontrahenta`, `InstytucjaFinansowaPPK`, `KontaktOsoba`, `Kontrahent`, `Lokalizacja`, `OddzialFirmy`, `PracHistoria`, `SupportOperator`, `Team`, `UrzadCelny`, `UrzadSkarbowy`, `WizytowkaFirmy` |

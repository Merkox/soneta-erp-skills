# Pola i właściwości klasy biznesowej: `Soneta.Core.AdresWWW`
Nazwa tabeli: `AdresyWWW`
Tytuł: Adresy WWW
Opis: Element szczegółowy hosta adresów WWW (IAdresyWWWHost). Przechowuje adresy stron internetowych przypisane do obiektów w systemie (kontrahentów, oddziałów firmy itp.) z oznaczeniem adresu domyślnego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zapis` → `IAdresyWWWHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `string` | bazodanowe | Adres WWW | Adres WWW skojarzony z danym zapisem. |
| Domyslny | `bool` | bazodanowe | Domyślny | Czy dany adres WWW jest domyślny dla danego zapisu. |
| Zapis | `Soneta.Core.IAdresyWWWHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  | Zapis, do którego przypisany jest dany adres WWW |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zapis | `IAdresyWWWHost` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `OddzialFirmy`, `Towar`, `UrzadCelny`, `UrzadSkarbowy` |

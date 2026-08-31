# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PUERaportNieobecnosci`
Nazwa tabeli: `PUERptNb`
Tytuł: Raport nieobecności importowany z PUE
Opis: Raport nieobecności importowany z platformy PUE ZUS. Przechowuje datę wygenerowania, dane płatnika (NIP, nazwa), typ raportu oraz liczbę dokumentów e-ZLA i e-ZLA korekty.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresEmail | `string` | bazodanowe |  |  |
| DataWygenerowania | `Date` | bazodanowe |  |  |
| DokumentyEZLA | `SubTable<Soneta.Kalend.PUEDokumentEZLA>` | podlista |  |  |
| LiczbaDokumentowEzla | `int` | bazodanowe |  |  |
| LiczbaDokumentowEzlaK | `int` | bazodanowe |  |  |
| PlatnikNazwaSkrocona | `string` | bazodanowe |  |  |
| PlatnikNip | `string` | bazodanowe |  |  |
| TypRaportu | `string` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt | Jednostka organizacyjna |  |

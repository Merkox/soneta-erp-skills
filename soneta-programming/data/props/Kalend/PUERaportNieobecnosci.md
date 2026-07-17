# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PUERaportNieobecnosci`
Nazwa tabeli: `PUERptNb`
Tytuł: Raport nieobecności importowany z PUE
Opis: Raport nieobecności importowany z platformy PUE ZUS. Przechowuje datę wygenerowania, dane płatnika (NIP, nazwa), typ raportu oraz liczbę dokumentów e-ZLA i e-ZLA korekty.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresEmail | `string` | bazodanowe |  |  |
| DataWygenerowania | `Soneta.Types.Date` | bazodanowe |  |  |
| DokumentyEZLA | `Soneta.Business.SubTable<Soneta.Kalend.PUEDokumentEZLA>` |  |  |  |
| LiczbaDokumentowEzla | `int` | bazodanowe |  |  |
| LiczbaDokumentowEzlaK | `int` | bazodanowe |  |  |
| PlatnikNazwaSkrocona | `string` | bazodanowe |  |  |
| PlatnikNip | `string` | bazodanowe |  |  |
| TypRaportu | `string` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |

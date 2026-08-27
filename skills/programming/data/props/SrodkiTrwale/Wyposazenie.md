# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.Wyposazenie`
Nazwa tabeli: `EwidWyposazenia`
Tytuł: Ewidencja wyposażenia
Opis: Kartoteka wyposażenia firmy (elementy niskocenne niebędące środkami trwałymi). Przechowuje dane identyfikacyjne, dokumenty pozyskania i zbycia oraz przypisanie do miejsca użytkowania. Umożliwia prowadzenie ewidencji ilościowej i inwentaryzacji wyposażenia.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `WyposazenieHistoria`
Implementuje interfejsy: `IInwentarz`, `IKodowany`, `IZasobCRM`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataRejestracji | `Date` | tylko-odczyt |  |  |
| Historia | `HistorySubTable<Soneta.SrodkiTrwale.WyposazenieHistoria>` | podlista |  |  |
| KodZasobu | `string` | tylko-odczyt |  |  |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| Last | `Soneta.SrodkiTrwale.WyposazenieHistoria` | tylko-odczyt |  |  |
| MiejsceUzytkowania | `Soneta.SrodkiTrwale.MiejsceUzytkowania` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa wyposażenia |
| NazwaZasobu | `string` | tylko-odczyt |  |  |
| NumerFabryczny | `string` | bazodanowe |  | Numer fabryczny wyposażenia |
| NumerInwentarzowy | `string` | bazodanowe |  | Numer inwentarzowy środka trwałego |
| Opis | `string` | bazodanowe |  | Opis środka wyposażenia |
| PozyskanieData | `Date` | bazodanowe | Data pozyskania |  |
| PozyskanieDokIdent | `System.Guid` | bazodanowe |  |  |
| PozyskanieDokument | `Soneta.Core.DokEwidencji` |  |  |  |
| PozyskanieNrDokumentu | `string` | bazodanowe | Nr dokumentu pozyskania |  |
| Terminarz | `SubTable<Soneta.SrodkiTrwale.PozycjaTerminarzaInw>` | podlista |  |  |
| TypZasobu | `string` | tylko-odczyt |  |  |
| ZasobyCRM | `SubTable` | podlista |  |  |
| ZbycieData | `Date` | bazodanowe | Data zbycia |  |
| ZbycieDokIdent | `System.Guid` | bazodanowe |  |  |
| ZbycieDokument | `Soneta.Core.DokEwidencji` |  |  |  |
| ZbycieNrDokumentu | `string` | bazodanowe | Nr dokumentu zbycia |  |

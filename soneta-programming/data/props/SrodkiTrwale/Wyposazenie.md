# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.Wyposazenie`
Nazwa tabeli: `EwidWyposazenia`
Tytuł: Ewidencja wyposażenia
Opis: Kartoteka wyposażenia firmy (elementy niskocenne niebędące środkami trwałymi). Przechowuje dane identyfikacyjne, dokumenty pozyskania i zbycia oraz przypisanie do miejsca użytkowania. Umożliwia prowadzenie ewidencji ilościowej i inwentaryzacji wyposażenia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IInwentarz`, `IKodowany`, `IZasobCRM`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataRejestracji | `Soneta.Types.Date` |  |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` |  |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.SrodkiTrwale.WyposazenieHistoria>` |  |  |  |
| KodZasobu | `string` |  |  |  |
| KodyKreskowe | `Soneta.Business.SubTable<Soneta.Core.KodKreskowy>` |  |  |  |
| Last | `Soneta.SrodkiTrwale.WyposazenieHistoria` |  |  |  |
| MiejsceUzytkowania | `Soneta.SrodkiTrwale.MiejsceUzytkowania` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa wyposażenia |
| NazwaZasobu | `string` |  |  |  |
| NumerFabryczny | `string` | bazodanowe |  | Numer fabryczny wyposażenia |
| NumerInwentarzowy | `string` | bazodanowe |  | Numer inwentarzowy środka trwałego |
| Opis | `string` | bazodanowe |  | Opis środka wyposażenia |
| PozyskanieData | `Soneta.Types.Date` | bazodanowe | Data pozyskania |  |
| PozyskanieDokIdent | `System.Guid` | bazodanowe |  |  |
| PozyskanieDokument | `Soneta.Core.DokEwidencji` |  |  |  |
| PozyskanieNrDokumentu | `string` | bazodanowe | Nr dokumentu pozyskania |  |
| Terminarz | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.PozycjaTerminarzaInw>` |  |  |  |
| TypZasobu | `string` |  |  |  |
| ZasobyCRM | `Soneta.Business.SubTable` |  |  |  |
| ZbycieData | `Soneta.Types.Date` | bazodanowe | Data zbycia |  |
| ZbycieDokIdent | `System.Guid` | bazodanowe |  |  |
| ZbycieDokument | `Soneta.Core.DokEwidencji` |  |  |  |
| ZbycieNrDokumentu | `string` | bazodanowe | Nr dokumentu zbycia |  |

# Pola i właściwości klasy biznesowej: `Soneta.Core.Teczka`
Nazwa tabeli: `Teczki`
Tytuł: Teczki
Opis: Teczka (sprawa, akt) grupująca powiązane dokumenty i obiekty. Zawiera numer, nazwę, opis, stan, definicję typu, właściciela oraz flagę aktywności. Umożliwia organizację pracy i śledzenie postępu spraw.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy teczka w tym stanie jest aktywna (otwarta). |
| Data | `Soneta.Types.Date` |  |  |  |
| Definicja | `Soneta.Core.DefTeczki` | bazodanowe |  | Definicja teczki |
| Elementy | `Soneta.Business.LpSubTable<Soneta.Core.ElemTeczki>` |  |  |  |
| ElementyTeczki | `Soneta.Business.View` |  |  |  |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| IsPageVisible | `bool` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa teczki | Krótka nazwa teczki, na podstawie której będzie można ją wyszukiwać |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis teczki |
| Permissions | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.RecordPermission>` |  |  |  |
| Stan | `Soneta.Core.StanTeczki` | bazodanowe |  | Stan teczki. |
| UseIndividualAccessRights | `bool` |  |  |  |
| Wlasciciel | `Soneta.Business.App.Operator` | bazodanowe |  | Właściciel teczki |

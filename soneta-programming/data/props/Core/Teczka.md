# Pola i właściwości klasy biznesowej: `Soneta.Core.Teczka`
Nazwa tabeli: `Teczki`
Tytuł: Teczki
Opis: Teczka (sprawa, akt) grupująca powiązane dokumenty i obiekty. Zawiera numer, nazwę, opis, stan, definicję typu, właściciela oraz flagę aktywności. Umożliwia organizację pracy i śledzenie postępu spraw.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 6
- podlisty: 6
- subrowy: 1
- razem: 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe, tylko-odczyt | Aktywny | Wskazuje, czy teczka w tym stanie jest aktywna (otwarta). |
| Data | `Date` | tylko-odczyt |  |  |
| Definicja | `Soneta.Core.DefTeczki` | bazodanowe |  | Definicja teczki |
| Elementy | `LpSubTable<Soneta.Core.ElemTeczki>` | podlista |  |  |
| ElementyTeczki | `View` | podlista |  |  |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| IsPageVisible | `bool` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa teczki | Krótka nazwa teczki, na podstawie której będzie można ją wyszukiwać |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis teczki |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| Stan | `Soneta.Core.StanTeczki` | bazodanowe |  | Stan teczki. |
| UseIndividualAccessRights | `bool` | tylko-odczyt |  |  |
| Wlasciciel | `App.Operator` | bazodanowe |  | Właściciel teczki |

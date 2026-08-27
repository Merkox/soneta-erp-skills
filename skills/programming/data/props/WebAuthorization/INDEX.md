# Moduł `WebAuthorization` — tabele biznesowe

- Opis: Moduł autoryzacji webowej. Zawiera definicje uprawnień, tokenów dostępu oraz mechanizmy uwierzytelniania użytkowników aplikacji webowych enova365.
- Tabel: **4**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| WebProfile |  | `WebProfiles` |  | root |  |  |  | [WebProfile.md](WebProfile.md) |
| WebReport |  | `WebReports` |  | root |  |  |  | [WebReport.md](WebReport.md) |
| WebReportRole | Role raportu | `WebReportRoles` |  | child: Report→WebReport |  |  |  | [WebReportRole.md](WebReportRole.md) |
| WebUser |  | `WebUsers` |  | root |  | INoticeRecipient, IMfaOperator |  | [WebUser.md](WebUser.md) |


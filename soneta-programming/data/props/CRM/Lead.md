# Pola i właściwości klasy biznesowej: `Soneta.Data.QueryDefinition.Lead`
Nazwa tabeli: `Leady`
Opis: Lead sprzedażowy CRM reprezentujący potencjalną szansę biznesową. Rejestruje zainteresowanie klienta od pierwszego kontaktu, śledząc stan kwalifikacji, temperaturę, priorytet, wartość oraz powiązanie z kontrahentami i projektami aż do konwersji w transakcję.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`, `IElementSlownika`

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Argument | `Soneta.Data.QueryDefinition.Argument` |  |  |  |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Planowana data zakończenia. |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia. |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe | Data zamknięcia | Data faktycznego zamknięcia |
| Default | `Soneta.Data.QueryDefinition.Argument` |  |  |  |
| Definicja | `Soneta.Business.IRow` | bazodanowe |  | Definicja leada |
| Kontrahent | `Soneta.Business.IRow` | bazodanowe |  | Kontrahent podpięty do leada. |
| Koszt | `Soneta.Types.Currency` | bazodanowe | Koszt | Zakładany koszt. |
| Marza | `Soneta.Types.Percent` | bazodanowe | Marża | Marża podawana w procentach wykorzystywana do wyliczania kosztu. |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa leada |  |
| Numer | `Soneta.Core.CoreModule.NumerDokumentuRecord` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| OffsetValue | `int` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis leada. |
| OrderBy | `Soneta.Data.QueryDefinition.OrderBy` |  |  |  |
| PartitionBy | `Soneta.Data.QueryDefinition.PartitionBy` |  |  |  |
| Priorytet | `Soneta.Business.IRow` | bazodanowe |  | Priorytet leada. |
| Projekt | `Soneta.Business.IRow` | bazodanowe |  | Projekt, z którym powiązany jest lead. |
| Prowadzacy | `Soneta.Business.IRow` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie leada. |
| Przedstawiciel | `Soneta.Business.IRow` | bazodanowe | Przedstawiciel | Osoba kontaktowa ze strony kontrahenta. |
| Przychod | `Soneta.Types.Currency` | bazodanowe | Przychód | Zakładany przychód. |
| StanData | `Soneta.Types.Date` | bazodanowe |  | Data zmiany stanu. |
| StanLeada | `Soneta.Business.IRow` | bazodanowe |  | Stan leada. |
| Temperatura | `Soneta.Business.IRow` | bazodanowe |  | Temperatura leada. |
| Zrodlo | `Soneta.Business.IRow` | bazodanowe |  | Źródło kontaktu. |

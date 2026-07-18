# Pola i właściwości klasy biznesowej: `Soneta.Data.QueryDefinition.Lead`
Nazwa tabeli: `Leady`
Opis: Lead sprzedażowy CRM reprezentujący potencjalną szansę biznesową. Rejestruje zainteresowanie klienta od pierwszego kontaktu, śledząc stan kwalifikacji, temperaturę, priorytet, wartość oraz powiązanie z kontrahentami i projektami aż do konwersji w transakcję.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`, `IElementSlownika`

- pola bazodanowe (zapisywalne): 19
- pola kalkulowane (zapisywalne): 7
- pola tylko-odczyt: 1
- podlisty: 3
- subrowy: 1
- razem: 31

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Argument | `Soneta.Data.QueryDefinition.Argument` |  |  |  |
| DataDo | `Date` | bazodanowe | Data zakończenia | Planowana data zakończenia. |
| DataOd | `Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia. |
| DataZamkniecia | `Date` | bazodanowe | Data zamknięcia | Data faktycznego zamknięcia |
| Default | `Soneta.Data.QueryDefinition.Argument` |  |  |  |
| Definicja | `IRow` | bazodanowe |  | Definicja leada |
| Kontrahent | `IRow` | bazodanowe |  | Kontrahent podpięty do leada. |
| Koszt | `Currency` | bazodanowe | Koszt | Zakładany koszt. |
| Marza | `Percent` | bazodanowe | Marża | Marża podawana w procentach wykorzystywana do wyliczania kosztu. |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa leada |  |
| Numer | `Soneta.Core.CoreModule.NumerDokumentuRecord` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| OffsetValue | `int` |  |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis leada. |
| OrderBy | `Soneta.Data.QueryDefinition.OrderBy` |  |  |  |
| PartitionBy | `Soneta.Data.QueryDefinition.PartitionBy` |  |  |  |
| Priorytet | `IRow` | bazodanowe |  | Priorytet leada. |
| Projekt | `IRow` | bazodanowe |  | Projekt, z którym powiązany jest lead. |
| Prowadzacy | `IRow` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie leada. |
| Przedstawiciel | `IRow` | bazodanowe | Przedstawiciel | Osoba kontaktowa ze strony kontrahenta. |
| Przychod | `Currency` | bazodanowe | Przychód | Zakładany przychód. |
| StanData | `Date` | bazodanowe |  | Data zmiany stanu. |
| StanLeada | `IRow` | bazodanowe |  | Stan leada. |
| Temperatura | `IRow` | bazodanowe |  | Temperatura leada. |
| Zrodlo | `IRow` | bazodanowe |  | Źródło kontaktu. |

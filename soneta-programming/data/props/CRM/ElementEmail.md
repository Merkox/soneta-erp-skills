# Pola i właściwości klasy biznesowej: `Soneta.CRM.ElementEmail`
Nazwa tabeli: `ElementyEmail`
Tytuł: Elementy powiązane
Opis: Powiązanie wiadomości e-mail z elementami systemu (kontrahentami, dokumentami, transakcjami). Umożliwia przypisywanie korespondencji do obiektów biznesowych, zarówno ręcznie jak i automatycznie, tworząc spójną historię komunikacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Element | `IEmailElement` | bazodanowe, iface-ref | Element powiązany | Element, który powiązany jest z wiadomością |
| PowiazanieAutomatyczne | `bool` | bazodanowe | Powiązanie automatyczne | Określa, czy powiązanie zostało utworzone automatycznie |
| WiadomoscEmail | `Soneta.CRM.WiadomoscEmail` | bazodanowe | Wiadomość email | Wiadomość, do której powiązany jest element |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Element | `IEmailElement` | `Bank`, `BasicDocument`, `DamageEvent`, `Deklaracja`, `DokEwidencji`, `DokRozliczBase`, `DokumentHandlowy`, `GrupaSzkol`, `InstytucjaFinansowaPPK`, `Insurance`, `KontaktOsoba`, `Kontrahent`, `Korespondencja`, `Lead`, `Lokalizacja`, `Matter`, `Pracownik`, `Projekt`, `Reservation`, `SprawaWindykacyjna`, `Transakcja`, `UczestnikBase`, `UrzadCelny`, `UrzadSkarbowy`, `WizytowkaFirmy`, `Zadanie`, `ZgloszenieUczestnik` |

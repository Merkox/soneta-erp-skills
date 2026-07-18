# Pola i właściwości klasy biznesowej: `Soneta.Kalend.NieobecnośćIdx`
Nazwa tabeli: `NieobecnosciIdx`
Opis: Indeks nieobecności umożliwiający szybkie wyszukiwanie nieobecności pracownika po okresie i definicji. Tabela pomocnicza łącząca nieobecność z pracownikiem i definicją nieobecności w celu optymalizacji zapytań.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| Nieobecnosc | `Soneta.Kalend.Nieobecnosc` | bazodanowe, tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | tylko-odczyt |  |  |
| Zrodlo | `Soneta.Kalend.IZrodloNieobecnosci` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IZrodloNieobecnosci` | `Nieobecnosc`, `Pracownik`, `Umowa`, `UmowaZewnetrzna` |

# Pola i właściwości klasy biznesowej: `Soneta.Core.CRUApiKey`
Nazwa tabeli: `CRUApiKeys`
Tytuł: Klucz API CRU
Opis: Zarządzanie tokenami dostępowymi dla Centralnego Rejestru Umów. Pozwala na dodawanie, aktywację i dezaktywację kluczy API.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ApiKey | `string` | bazodanowe | Klucz API CRU | Klucz API CRU |
| ApiKeyDescription | `string` | bazodanowe | Opis | Opis |
| IsActive | `bool` | bazodanowe | Aktywna | Aktywność klucza API |
| IsProd | `bool` | bazodanowe | Produkcja | Konfiguracja dla środowiska produkcyjnego |
| IsReadOnlyTaskUser | `bool` | tylko-odczyt |  |  |
| TaskUser | `ITaskUser` | bazodanowe, iface-ref | Właściciel konfiguracji | Właściciel konfiguracji |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

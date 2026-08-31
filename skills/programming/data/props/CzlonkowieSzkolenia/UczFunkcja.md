# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.UczFunkcja`
Nazwa tabeli: `UczFunkcje`
Tytuł: Funkcje z wyboru
Opis: Rejestr funkcji pełnionych z wyboru przez członków organizacji. Przechowuje informacje o funkcjach takich jak przewodniczący, skarbnik czy sekretarz, wraz z okresem ich sprawowania.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataDo | `Date` | bazodanowe |  | Data pełnienia funkcji do |
| DataOd | `Date` | bazodanowe |  | Data pełnienia funkcji od |
| Nazwa | `string` | bazodanowe | Funkcja | Funkcja pełniona przez członka. |
| Opis | `string` | bazodanowe | Opis | Opis funkcji przez członka. |
| Uczestnik | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe |  |  |

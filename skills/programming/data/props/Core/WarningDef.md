# Pola i właściwości klasy biznesowej: `Soneta.Core.WarningDef`
Nazwa tabeli: `WarningDefs`
Tytuł: Definicje warningów
Opis: Definicja ostrzeżenia (warningu) wyświetlanego użytkownikowi. Określa nazwę kodu, tabelę i pole, którego dotyczy ostrzeżenie, nazwę konfiguracyjną oraz flagę podlegania konfiguracji przez użytkownika.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Column | `string` | bazodanowe | Pole | Pole w tabeli, którego dotyczy warning |
| Description | `string` | bazodanowe | Nazwa konfiguracyjna | Nazwa konfiguracyjna |
| IsConfigurable | `bool` | bazodanowe | Podlega konfiguracji | Podlega konfiguracji |
| Name | `string` | bazodanowe | Nazwa kod | Pełna nazwa warningu w kodzie |
| TableName | `string` | bazodanowe | Obiekt | Nazwa tabeli, której dotyczy warning |

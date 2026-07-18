# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RemoteFile`
Nazwa tabeli: `RemoteFiles`
Tytuł: Informacje o plikach zdalnych
Opis: Metadane pliku przechowywanego w zdalnym magazynie. ŝączy plik załącznika z zewnętrznym identyfikatorem i uchwytem w chmurze lub innym zdalnym storage.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AttachmentFile | `Db.AttachmentFile` | bazodanowe, tylko-odczyt | Plik załącznika |  |
| ExternalID | `string` | bazodanowe, tylko-odczyt | Zewnętrzny identyfikator | Identyfikator w zdalnym magazynie plików. |
| Handle | `MemoText` | bazodanowe, podlista | Uchwyt do pliku zdalnego | Metadane pliku zapisanego w zdalnym magazynie plików. |
| RelatedField | `string` | bazodanowe, tylko-odczyt | Pole w tabeli AttachmentFiles | Powiązane pole binarne w tabeli AttachmentFiles. |

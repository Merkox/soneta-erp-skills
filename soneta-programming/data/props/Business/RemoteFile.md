# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RemoteFile`
Nazwa tabeli: `RemoteFiles`
Tytuł: Informacje o plikach zdalnych
Opis: Metadane pliku przechowywanego w zdalnym magazynie. ŝączy plik załącznika z zewnętrznym identyfikatorem i uchwytem w chmurze lub innym zdalnym storage.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AttachmentFile | `Soneta.Business.Db.AttachmentFile` | bazodanowe | Plik załącznika |  |
| ExternalID | `string` | bazodanowe | Zewnętrzny identyfikator | Identyfikator w zdalnym magazynie plików. |
| Handle | `Soneta.Business.MemoText` | bazodanowe | Uchwyt do pliku zdalnego | Metadane pliku zapisanego w zdalnym magazynie plików. |
| RelatedField | `string` | bazodanowe | Pole w tabeli AttachmentFiles | Powiązane pole binarne w tabeli AttachmentFiles. |

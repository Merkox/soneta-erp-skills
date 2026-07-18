# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFTokenIdentWewnRel`
Nazwa tabeli: `KSeFTokIdWewRels`
Tytuł: Powiązanie tokenu systemu zewnętrznego z identyfikatorem wewnętrznym KSeF
Opis: Tabela przechowuje powiązania między tokenami systemów zewnętrznych a wewnętrznymi identyfikatorami w Krajowym Systemie e-Faktur. Umożliwia mapowanie tokenów autoryzacyjnych KSeF na identyfikatory wewnętrzne podmiotu. Służy do zarządzania uprawnieniami dostępu do KSeF w kontekście wielu podmiotów i tokenów.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IdentyfikatorWewnetrzny | `Soneta.Core.KSeFIdentWewn` | bazodanowe | Identyfikator wewnętrzny KSeF | Identyfikator wewnętrzny KSeF |
| Token | `Soneta.Core.SysZewToken` | bazodanowe | Token KSeF | Token KSeF |

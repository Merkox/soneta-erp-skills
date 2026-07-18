# Pola i właściwości klasy biznesowej: `Soneta.Core.PIM.RelacjaOpisPIM`
Nazwa tabeli: `RelacjeOpisowPIM`
Opis: Definicja relacji wiążącej obiekt Host z OpisemPIM. Określa przypisanie opisu do wskazanego elementu oraz powiązania między danymi systemowymi.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Domyslny | `bool` | bazodanowe |  |  |
| Host | `Soneta.Core.IOpisPIMHost` | bazodanowe | Obiekt opisu | Obiekt do którego przypisany jest opis |
| Opis | `Soneta.Core.PIM.OpisPIM` | bazodanowe | Opis PIM | Opis PIM |
| Szablon | `Soneta.Core.PIM.SzablonPIM` | bazodanowe |  |  |

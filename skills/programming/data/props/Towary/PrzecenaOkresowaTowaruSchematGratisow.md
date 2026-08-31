# Pola i właściwości klasy biznesowej: `Soneta.Towary.PrzecenaOkresowaTowaruSchematGratisow`
Nazwa tabeli: `PrzOkresTwrSchGr`
Opis: Pozycja promocji okresowej przypisująca konkretny towar ze schematem gratisów do przeceny. Określa schemat gratisów dla danego towaru w ramach aktywnej promocji.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| PrzecenaOkresowa | `Soneta.Towary.PrzecenaOkresowa` | bazodanowe |  |  |
| Schemat | `Soneta.Towary.SchemOpakowan` | bazodanowe | Schemat gratisów | Schemat gratisów. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar, do którego przypisany jest schemat gratisów dla danej przeceny okresowej. |

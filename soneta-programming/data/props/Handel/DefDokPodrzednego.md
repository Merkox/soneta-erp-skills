# Pola i właściwości klasy biznesowej: `Soneta.Handel.RelacjeDokumentow.DefDokPodrzednego`
Nazwa tabeli: `DefDokPodrzedne`
Opis: Element szczegółowy definicji relacji handlowej (DefRelacjiHandlowej). Wiąże definicję dokumentu nadrzędnego z podrzędnym w ramach relacji handlowej.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefRelacjiHandlowej`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Handel.DefRelacjiHandlowej` | bazodanowe, guided-parent |  |  |
| Index | `int` | bazodanowe |  |  |
| Nadrzedna | `Soneta.Handel.DefDokHandlowego` | bazodanowe |  |  |
| Podrzedna | `Soneta.Handel.DefDokHandlowego` | bazodanowe |  |  |

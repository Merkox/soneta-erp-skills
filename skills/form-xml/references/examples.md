# Kompletne przykłady plików formularzy

Gotowe, minimalne pliki każdego typu — do skopiowania i przerobienia. Składnię elementów
opisuje [../SKILL.md](../SKILL.md), pełną specyfikację [ELEMENTS.md](ELEMENTS.md).

## pageform.xml — zakładka formularza obiektu

Plik: `MojObiekt.Ogolne.pageform.xml`

```xml
<?xml version="1.0" encoding="utf-8"?>
<DataForm xmlns="http://www.enova.pl/schema/form.xsd"
          xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema"
          xsi:schemaLocation="http://www.enova.pl/schema/ https://www.enova.pl/schema/form.xsd"
          Priority="10">
  <Page CaptionHtml="Ogólne" DataContext="{DataSource}">
    <Group CaptionHtml="Dane podstawowe">
      <Field CaptionHtml="Kod" Width="20" EditValue="{Kod}" />
      <Field CaptionHtml="Nazwa" Width="*" EditValue="{Nazwa}" />
    </Group>
    <Group CaptionHtml="Pozycje">
      <Grid Width="*" Height="*" EditValue="{Pozycje}" IsToolbarVisible="true">
        <Field CaptionHtml="Lp" Width="5" EditValue="{Lp}" />
        <Field CaptionHtml="Wartość" Width="15" EditValue="{Wartosc}" Footer="Sum" />
      </Grid>
    </Group>
  </Page>
</DataForm>
```

## Config.*.pageform.xml — strona okna Opcji (konfiguracja)

Plik: `Config.MojeDefinicje.pageform.xml` (projekt `.UI`). Człony `CaptionHtml` rozdzielone `/`
budują hierarchię drzewa Opcji; dane dostarcza extender (`DataContext="{New …}"`) z property
widoków list konfiguracyjnych — szczegóły i checklista:
[binding.md](binding.md#strony-okna-opcji-konfiguracja).

```xml
<?xml version="1.0" encoding="utf-8"?>
<DataForm xmlns="http://www.enova.pl/schema/form.xsd"
          xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema"
          xsi:schemaLocation="http://www.enova.pl/schema/ https://www.enova.pl/schema/form.xsd">
  <Page CaptionHtml="Systemowe/Mój obszar/Definicje" DataContext="{New MojConfigExtender}">
    <Group CaptionHtml="Definicje">
      <Grid Width="*" Height="*" EditValue="{Definicje}" IsToolbarVisible="true">
        <Field CaptionHtml="Nazwa" Width="40" EditValue="{Nazwa}" />
        <Field CaptionHtml="Blokada" Width="10" EditValue="{Blokada}" />
      </Grid>
    </Group>
  </Page>
</DataForm>
```

## viewform.xml — widok listy z panelem filtrów

Widok listy z panelem filtrów powyżej grida. `<Flow>` jako `FilterPanel` to standardowy wzorzec.

```xml
<?xml version="1.0" encoding="utf-8"?>
<DataForm xmlns="http://www.enova.pl/schema/form.xsd"
          xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema"
          xsi:schemaLocation="http://www.enova.pl/schema/ https://www.enova.pl/schema/form.xsd">
  <Flow Name="FilterPanel">
    <Field CaptionHtml="Status" Width="15" EditValue="{ViewInfo+Params.Status}" Important="true" />
    <Field CaptionHtml="Typ" Width="12" EditValue="{ViewInfo+Params.Typ}" Important="true" />
    <Field CaptionHtml="Data od" Width="14" EditValue="{ViewInfo+Params.DataOd}" />
  </Flow>
  <Grid Name="List" OrderBy="Nazwa" FilterPanelWidth="136"
        IsToolbarVisible="true" IsFilterRowVisible="false">
    <Appearance Condition="{?[Status] = 'nieaktywny'}" ForeColor="#808080" />
    <Field CaptionHtml="Kod" Width="20" EditValue="{Kod}" />
    <Field CaptionHtml="Nazwa" Width="30" EditValue="{Nazwa}" />
    <Field CaptionHtml="Status" Width="15" EditValue="{Status}" />
    <UserFilter Value="Status='Aktywny'" />
  </Grid>
</DataForm>
```

**Uwaga:** Pliki `viewform.xml` zawierają Grid bezpośrednio w `DataForm` (bez `Page`). Atrybuty
`ViewType` i `Mode` na `DataForm` są opcjonalne — dodaj je tylko gdy rejestrujesz widok przez
`FolderViewAttribute`.

> Panel filtrów **wewnątrz** listy (`Flow Class="DataBar"` w `Grid`) to inny, częstszy wzorzec —
> patrz [collections-grids.md](collections-grids.md).

## form.xml — współdzielony fragment

```xml
<?xml version="1.0" encoding="utf-8"?>
<DataForm xmlns="http://www.enova.pl/schema/form.xsd"
          xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema"
          xsi:schemaLocation="http://www.enova.pl/schema/ https://www.enova.pl/schema/form.xsd">
  <Stack>
    <Row>
      <Field CaptionHtml="Ulica" Width="40" EditValue="{Ulica}" />
      <Field CaptionHtml="Nr domu" Width="10" EditValue="{NrDomu}" />
    </Row>
    <Row>
      <Field CaptionHtml="Kod pocztowy" Width="12" EditValue="{KodPocztowy}" />
      <Field CaptionHtml="Miasto" Width="30" EditValue="{Miasto}" />
    </Row>
  </Stack>
</DataForm>
```

Dołączanie: `<Include Source="Adres.form.xml" DataContext="{Adres}" />`

## Gotowe pliki w skillu

- [../assets/MojObiekt.Ogolne.pageform.xml](../assets/MojObiekt.Ogolne.pageform.xml)
- [../assets/Kontrahent.WarunkiHandlowe.pageform.xml](../assets/Kontrahent.WarunkiHandlowe.pageform.xml) — warunki handlowe
- [../assets/Adres.form.xml](../assets/Adres.form.xml) — fragment współdzielony

## Powiązania

- [../SKILL.md](../SKILL.md) — składnia elementów i atrybutów.
- [binding.md](binding.md) — jak plik wiąże się z typem obiektu.
- [collections-grids.md](collections-grids.md) — listy, filtry, zaznaczanie.
- [ux-design.md](ux-design.md) — zasady projektowania okien i weryfikacja wizualna.

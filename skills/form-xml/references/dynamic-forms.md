# Formularze budowane dynamicznie

Jak zbudować formularz, w którym liczba pól nie jest znana z góry — bo wynika z konfiguracji,
ze słownika albo z listy pozycji. Dwie techniki: **bindowanie po indeksie** (najprostsza, wystarcza
w większości przypadków) i **generowanie elementów z kodu** przez `<Template>`.

Na końcu pułapka, która dotyczy obu: **układ formularza jest cache'owany**.

---

## 1. Bindowanie po indeksie — `{Kolekcja[i].Właściwość}`

W wyrażeniu `{...}` można zejść do elementu kolekcji po indeksie. Indeksować da się w każdym
atrybucie bindowanym, nie tylko w `EditValue`:

```xml
<Group CaptionHtml="Zgody marketingowe" LabelWidth="30">
  <Field CaptionHtml="{Zgody[0].Nazwa}" EditValue="{Zgody[0].Udzielona}"
         IsReadOnly="{Zgody[0].Zablokowana}" Visibility="{Zgody[0].Dostepna}" />
  <Field CaptionHtml="{Zgody[1].Nazwa}" EditValue="{Zgody[1].Udzielona}"
         IsReadOnly="{Zgody[1].Zablokowana}" Visibility="{Zgody[1].Dostepna}" />
  <Field CaptionHtml="{Zgody[2].Nazwa}" EditValue="{Zgody[2].Udzielona}"
         IsReadOnly="{Zgody[2].Zablokowana}" Visibility="{Zgody[2].Dostepna}" />
</Group>
```

Strona kodu to zwykła kolekcja prostych obiektów wystawiona jako property:

```csharp
public class Zgoda {
    public string Nazwa { get; init; }

    [Accessor(AutoChange = true)]
    public bool Udzielona { get; set; }

    public bool Zablokowana { get; init; }
    public bool Dostepna { get; init; }
}

private List<Zgoda> zgody;

public List<Zgoda> Zgody => zgody ??= WczytajZgody();
```

### Zasady, których trzeba pilnować

| Zasada | Dlaczego |
|--------|----------|
| Kolekcja musi być `IList` — `List<T>` albo `T[]` | `IEnumerable<T>` (np. wynik `.Select()`) nie da się indeksować |
| Property musi zwracać **stabilną instancję** | `ToArray()` przy każdym `get` tworzy nowe obiekty i zapis wartości przepada — buforuj w polu, jak wyżej |
| Ostatnie ogniwo ścieżki musi być property z setterem | Zapisywalne jest `{Kolekcja[0].Pole}`, ale nie samo `{Kolekcja[0]}` |
| Indeks poza zakresem daje pustą wartość | Nie wysypie formularza, więc nadmiarowe pola można ukryć przez `Visibility` |
| Elementy kolekcji to zwykłe obiekty | Nie muszą być obiektami biznesowymi |

Pola pomocnicze na takim obiekcie oznaczaj `[Accessor(AutoChange = true)]` — bez tego zmiana nie
przejdzie przez sesję i formularz nie odświeży pól zależnych.

### Stała liczba pól, zmienna zawartość

Gdy maksymalna liczba pozycji jest znana (np. „do pięciu rachunków bankowych"), wypisz wszystkie
w XML i steruj widocznością nadmiarowych. Nie musisz wtedy generować niczego z kodu:

```xml
<Field CaptionHtml="{Rachunki[3].Opis}" EditValue="{Rachunki[3].Numer}"
       Visibility="{Rachunki[3].Istnieje}" />
```

---

## 2. Generowanie elementów z kodu — `<Template RenderMethodName="...">`

Gdy liczba pozycji naprawdę nie jest znana z góry, `<Template>` z atrybutem `RenderMethodName`
działa jak generator: metoda wskazana w atrybucie dostaje szablon i klonuje go tyle razy, ile
potrzeba. Sam `<Template>` znika z gotowego formularza — zostają wyłącznie klony.

```xml
<Group Name="PanelOpcji" CaptionHtml="Wybierz zakres">
  <Template Name="OpcjaTemplate" DataContext="{new ZakresExtender}"
            RenderMethodName="RenderujOpcje">
    <Field />
  </Template>
</Group>
```

```csharp
public void RenderujOpcje(TemplateElement template) {
    for (int i = 0; i < Opcje.Count; i++) {
        var field = (FieldElement)template.CloneInPlace();

        field.Name = "Opcja" + i;                          // patrz uwaga niżej
        field.CaptionHtml = Opcje[i].Nazwa.HtmlEncode();
        field.EditValue = $"{{Opcje[{i}].Zaznaczona}}";    // checkbox
    }
}
```

Metoda jest szukana na obiekcie wskazanym przez `DataContext` szablonu (extender, worker, klasa
parametrów). Na klonie ustawia się to samo, co pisze się w XML: `CaptionHtml`, `EditValue`,
`CheckedValue`, `Class`, `Width`, `Visibility`.

Wariant radio — wszystkie klony wskazują **jedną** property, a różnią się `CheckedValue`:

```csharp
field.EditValue = "{WybranaOpcja}";
field.CheckedValue = Opcje[i].Kod;
```

> **⚠️ Nadawaj klonom jawne, unikalne `Name`.** Klony dziedziczą nazwę z szablonu, a duplikaty
> silnik rozróżnia, doklejając do nich kolejny numer z globalnego licznika. Nazwa kontrolki staje
> się wtedy nieprzewidywalna — nie odwołasz się do niej z kodu ani z testu.

---

## 3. ⚠️ Pułapka: układ formularza jest cache'owany

To najdroższy błąd w tym temacie.

Zbudowany układ formularza jest **zapamiętywany i współdzielony** — kod z `RenderMethodName`
wykonuje się przy budowie układu, a nie przy każdym otwarciu okna. Klucz, pod którym układ jest
zapamiętany, **nie obejmuje danych edytowanego rekordu**. Skutek: pierwszy otwarty rekord
„zabetonuje" wygenerowane pola dla wszystkich następnych.

**Reguła:** w układ wolno wypiekać tylko to, co wynika z **typu i konfiguracji** (a więc jest takie
samo dla wszystkich rekordów). Wszystko, co zależy od konkretnego rekordu, przekazuj
**bindowaniem** `{...}` — wtedy liczy się przy każdym przeliczeniu formularza.

```csharp
// ŹLE — treść konkretnego rekordu wpisana na sztywno w układ
field.CaptionHtml = dokument.Kontrahent.Nazwa.HtmlEncode();

// DOBRZE — układ zawiera binding, wartość liczy się przy każdym otwarciu
field.CaptionHtml = $"{{Pozycje[{i}].NazwaKontrahenta}}";
```

Ta sama zasada dotyczy `Renderable`, które również liczy się raz przy budowie układu — dlatego
nadaje się wyłącznie do warunków licencyjnych i środowiskowych. Do warunków zależnych od danych
używaj `Visibility`.

Jeśli liczba generowanych pól naprawdę musi zależeć od danych, potrzebujesz osobnego układu dla
każdego wariantu — a to znaczy, że o wyborze wariantu musi decydować coś, co wchodzi w klucz
układu (typ, tryb, konfiguracja). W praktyce prościej jest wygenerować pola dla maksymalnej liczby
pozycji i ukrywać nadmiarowe przez `Visibility`.

---

## 4. Nazwa pliku `*.form.xml` musi być globalnie unikalna

Zasoby formularzy są odnajdywane po **samej nazwie pliku** — bez ścieżki i bez przestrzeni nazw.
Plik `Adres.form.xml` w dodatku trafia więc do tej samej puli, co plik o tej nazwie w bibliotece
platformy, i może go przesłonić.

**Zalecenie:** nazwy formularzy współdzielonych (`*.form.xml` dołączanych przez `<Include>`)
prefiksuj nazwą dodatku, np. `MojDodatek.Adres.form.xml`. Plików `*.pageform.xml` i
`*.viewform.xml` problem dotyczy w mniejszym stopniu, bo ich nazwy zaczynają się od nazwy typu,
ale zasada jest ta sama.

// Snippet w wariancie BEZ licencji DevExpress — dziedziczy z generycznej klasy Snippet.
//
// Kiedy używać: gdy Twój dodatek NIE ma własnej licencji DevExpress. Kod NIE odwołuje się do
// typów DevExpress (XtraReport, XRLabel, XRTableCell...). Zamiast uchwytów do kontrolek i .Text
// deklarujesz GETTERY WARTOŚCI wiązane atrybutem [Bind] do generycznych elementów
// SnippetLabel (etykieta) / SnippetCollection (podlista). Wynik gettera staje się drukowaną
// wartością elementu (EditValue) w momencie druku.
//
// Layout (.repx) i same kontrolki XR* projektuje się w narzędziu z licencją DevExpress —
// ograniczenie licencyjne dotyczy tylko KODU dodatku, nie samego szablonu.
//
// Podpięcie w .repx identyczne jak dla ReportSnippet (komponent ReportSnippetComponent):
//   <Item Ref="N" ObjectType="Soneta.Business.UI.DxReports.ReportSnippetComponent,Soneta.Business.UI.DxReports"
//         Name="Snippet" SnippetTypeName="MojDodatek.Reports.DokumentGenerycznySnippet,MojDodatek.Reports" />
using System.Collections.Generic;
using Soneta.Business.UI.Snippets;   // generyczny mechanizm snippetów — bez zależności od DevExpress

namespace MojDodatek.Reports;

public class DokumentGenerycznySnippet : Snippet {

    // Parametry wydruku — klasa ContextBase, wstrzykiwana przez [Context]. To typy Soneta, nie DevExpress.
    public class Parametry(Context cx) : ContextBase(cx) {
        [Priority(1)] [Translate] public bool PokazUwagi { get; set; } = true;
    }

    [Context] public Parametry Params { get; set; }

    // Getter wartości → wiązany do elementu SnippetLabel o nazwie "lblKontrahent" w .repx.
    // Zwrócona wartość jest drukowana jako treść elementu. Brak odwołań do typów DevExpress.
    [Bind(Name = "lblKontrahent")]
    public object Kontrahent() =>
        (GetCurrentRow() as DokumentHandlowy)?.Kontrahent?.Nazwa;

    // Getter zależny od parametru — zwraca pustą wartość, gdy uwagi mają być ukryte.
    [Bind(Name = "lblUwaga")]
    public object Uwaga() {
        if (!Params.PokazUwagi) return null;
        return (GetCurrentRow() as DokumentHandlowy)?.Uwagi;
    }

    // Getter kolekcji → wiązany do elementu SnippetCollection (podlista/DetailReportBand).
    // Zwracasz policzoną listę; framework użyje jej jako źródła podlisty.
    [Bind(Name = "GridPozycje")]
    public object Pozycje() {
        if (GetCurrentRow() is not DokumentHandlowy dok) return null;
        List<object> pozycje = [.. dok.Pozycje];   // collection expression + spread
        return pozycje;
    }
}

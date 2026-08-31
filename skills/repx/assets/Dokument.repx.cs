// Kod-behind (snippet) dla wydruku Dokument.repx — master-detail (dokument + pozycje).
// Plik leży obok Dokument.repx w katalogu Repx/. Nazwa klasy = nazwa wydruku + "Snippet".
//
// ⚠️ Licencja DevExpress: ta wersja odwołuje się do typów DevExpress (XRLabel, XRTableCell),
//    więc w kodzie dodatku wymaga własnej licencji DevExpress. Wariant bez licencji:
//    DokumentGeneryczny.repx.cs (generyczny Snippet + [Bind]).
//
// Aby podpiąć: w Dokument.repx dodaj w <ComponentStorage> komponent:
//   <Item Ref="N" ObjectType="Soneta.Business.UI.DxReports.ReportSnippetComponent,Soneta.Business.UI.DxReports"
//         Name="Snippet" SnippetTypeName="MojDodatek.Reports.DokumentSnippet,MojDodatek.Reports" />
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Soneta.Business.UI.DxReports;

namespace MojDodatek.Reports;

public class DokumentSnippet : ReportSnippet {

    // Uchwyty do kontrolek z .repx (nazwa pola = atrybut Name kontrolki).
    [DxBind] private readonly XRLabel lblKontrahent;   // kontrolka Name="lblKontrahent"
    [DxBind] private readonly XRTableCell fSuma;        // komórka podsumowania

    // Parametry wydruku pytane przed generowaniem (klasa ContextBase, wstrzykiwana przez [Context]).
    // Primary constructor + inicjalizator właściwości ustala wartość domyślną.
    public class Parametry(Context cx) : ContextBase(cx) {
        [Priority(1)] [Translate] public bool PokazZerowe { get; set; } = true;
    }

    [Context] public Parametry Params { get; set; }

    // Handler zdarzenia raportu: nazwa metody "Report_..." lub jawnie [DxBind(Name="Report")].
    // DataSourceRowChanged odpala się raz na każdy dokument (rekord master).
    [DxBind(Name = "Report")]
    private void Dokument_DataSourceRowChanged(object sender, DataSourceRowEventArgs e) {
        // Bieżący rekord danych bandy — pattern matching zamiast rzutowania + null-check.
        if (GetCurrentRow() is not DokumentHandlowy dokument) return;

        // Logika niewyrażalna deklaratywnie: warunkowe formatowanie/treść.
        lblKontrahent.Text = dokument.Kontrahent?.Nazwa ?? "(brak kontrahenta)".Translate();
    }

    // Handler zdarzenia pojedynczej komórki (nazwa "fSuma_BeforePrint" → kontrolka fSuma, zdarzenie BeforePrint).
    // Uwaga: BeforePrint odpala się wielokrotnie.
    [DxBind]
    private void fSuma_BeforePrint(object sender, CancelEventArgs e) {
        var dokument = GetCurrentRow() as DokumentHandlowy;
        // e.Cancel = true ukryłoby kontrolkę; tu sterujemy widocznością wg parametru.
        fSuma.Visible = Params.PokazZerowe || (dokument?.Wartosc ?? 0) != 0;
    }
}

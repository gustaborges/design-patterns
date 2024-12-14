using DesignPatterns.Behavorial.Visitor.Documents;
using DesignPatterns.Behavorial.Visitor.Visitors;

var documents = new IDocument[] { new TextDocument(), new Presentation(), new Spreadsheet() };

// Pdf export is an auxiliary behavior and is therefore kept in as separate class, the visitor.
var pdfExportVisitor = new PdfExportVisitor();

foreach (var document in documents)
{
    // The visitor is welcome inside of the primary class to do their specialized job.
    document.Accept(pdfExportVisitor);
}
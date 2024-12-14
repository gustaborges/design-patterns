using DesignPatterns.Behavorial.Visitor.Documents;

namespace DesignPatterns.Behavorial.Visitor.Visitors
{
    internal class PdfExportVisitor : IPdfExportVisitor
    {
        // Visitor method could be called "DoForTextDocument" and so on...
        public void Visit(TextDocument textDocument)
        {
            // Export text document to PDF file
            // The visitor could delegate to some specialized exporter. Let's suppose, TextDocumentToPdfExporter.
        }

        public void Visit(Spreadsheet spreadsheet)
        {
            // Export spreadsheet to PDF file
        }

        public void Visit(Presentation presentation)
        {
            // Export presentation to PDF file
        }
    }
}

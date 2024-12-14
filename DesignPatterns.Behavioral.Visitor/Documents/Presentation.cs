using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor.Documents
{
    public class Presentation : IDocument
    {
        // Class accepts the visitor. The method could be called "ExportPdf".
        public void Accept(IPdfExportVisitor pdfExport)
        {
            pdfExport.Visit(this);
        }
    }
}

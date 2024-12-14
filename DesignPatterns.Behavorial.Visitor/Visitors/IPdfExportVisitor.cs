using DesignPatterns.Behavorial.Visitor.Documents;

namespace DesignPatterns.Behavorial.Visitor.Visitors
{
    public interface IPdfExportVisitor
    {
        void Visit(TextDocument textDocument);
        void Visit(Spreadsheet textDocument);
        void Visit(Presentation textDocument);
    }
}

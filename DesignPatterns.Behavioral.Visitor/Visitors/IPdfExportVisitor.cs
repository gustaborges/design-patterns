using DesignPatterns.Behavioral.Visitor.Documents;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    public interface IPdfExportVisitor
    {
        void Visit(TextDocument textDocument);
        void Visit(Spreadsheet textDocument);
        void Visit(Presentation textDocument);
    }
}

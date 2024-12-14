using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor.Documents
{
    public interface IDocument
    {
        void Accept(IPdfExportVisitor visitor);
    }
}

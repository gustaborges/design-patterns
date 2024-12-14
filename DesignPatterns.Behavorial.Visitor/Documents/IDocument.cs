using DesignPatterns.Behavorial.Visitor.Visitors;

namespace DesignPatterns.Behavorial.Visitor.Documents
{
    public interface IDocument
    {
        void Accept(IPdfExportVisitor visitor);
    }
}

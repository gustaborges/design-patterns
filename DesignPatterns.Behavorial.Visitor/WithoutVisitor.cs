using DesignPatterns.Behavorial.Visitor.Documents;

/**
 * By using the visitor pattern we avoid structures similar to what is seen below, with castings and conditionals in order to delegate to the correct method 
 */
internal class Program2
{
    private static void Main(string[] args)
    {
        var documents = new IDocument[] { new TextDocument(), new Presentation(), new Spreadsheet() };
        var pdfExporter = new PdfExporter();


        foreach (var document in documents)
        {
            if (document is TextDocument textDocument)
            {
                pdfExporter.DoForTextDocument(textDocument);
                continue;
            }

            if (document is Presentation presentation)
            {
                pdfExporter.DoForPresentation(presentation);
                continue;
            }

            if (document is Spreadsheet spreadsheet)
            {
                pdfExporter.DoForSpreadsheet(spreadsheet);
                continue;
            }
        }
    }
}

internal class PdfExporter
{
    internal void DoForPresentation(Presentation presentation)
    {
        throw new NotImplementedException();
    }

    internal void DoForSpreadsheet(Spreadsheet spreadsheet)
    {
        throw new NotImplementedException();
    }

    internal void DoForTextDocument(TextDocument doc)
    {
        throw new NotImplementedException();
    }
}


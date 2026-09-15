namespace PDFReader.Services.PDFReaders;

using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;

internal class PDFPig : IPDFReader
{
    public string Read(string path)
    {
        using PdfDocument document = PdfDocument.Open(path);
        string text = "";
        foreach (Page page in document.GetPages())
        {
            text = ContentOrderTextExtractor.GetText(page);
        }
        return text;
    }
}

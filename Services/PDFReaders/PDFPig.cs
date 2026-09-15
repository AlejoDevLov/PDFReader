namespace PDFReader.Services.PDFReaders;

using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;
using UglyToad.PdfPig.DocumentLayoutAnalysis.WordExtractor;

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

    public IEnumerable<Word> ReadWords(string path)
    {
        using PdfDocument document = PdfDocument.Open(path);
        IEnumerable<Word> words = [];
        foreach (Page page in document.GetPages())
        {
           words = page.GetWords(NearestNeighbourWordExtractor.Instance);
        }
        return words;
    }
}

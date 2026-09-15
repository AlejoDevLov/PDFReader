namespace PDFReader.Services.PDFReaders;

internal interface IPDFReader
{
    string Read(string path);
}
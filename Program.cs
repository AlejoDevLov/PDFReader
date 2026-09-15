using PDFReader.Services;
using PDFReader.Services.PDFReaders;


var pdfsPath = "C:\\Users\\alejo\\Programming\\C#\\Resources\\Tickets\\Tickets1.pdf";
IPDFReader pdfPig = new PDFPig();
var result = pdfPig.Read(pdfsPath);

Console.WriteLine(result);

Console.ReadKey();

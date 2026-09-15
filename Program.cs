using PDFReader.Services.PDFReaders;


var pdfsPath = "C:\\Users\\alejo\\Programming\\C#\\Resources\\Tickets\\Tickets1.pdf";
IPDFReader pdfPig = new PDFPig();
var result = pdfPig.Read(pdfsPath);

//Contains("www.ourCinema.com")

var tickets = result.Split(Environment.NewLine).Skip(2).SkipLast(1);

Console.WriteLine(tickets.ElementAt(0));

Console.ReadKey();

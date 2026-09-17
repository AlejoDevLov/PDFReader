using PDFReader.Services;
using PDFReader.Services.PDFReaders;


var pdfsPath = "C:\\Users\\alejo\\Programming\\C#\\Resources\\Tickets\\Tickets1.pdf";
IPDFReader pdfPig = new PDFPig();
var result = pdfPig.Read(pdfsPath);

var ticketService = new TicketService();
ticketService.Create(result);

//Console.WriteLine(tickets.ElementAt(0));

Console.ReadKey();

using PDFReader.Services;
using PDFReader.Services.PDFReaders;


var pdfsPath = "C:\\Users\\alejo\\Programming\\C#\\Resources\\Tickets\\";
var files = Directory.GetFiles(pdfsPath);

PDFPig pdfPig = new ();
var ticketService = new TicketService();

foreach(var file in files)
{
    var result = pdfPig.Read(file);

    ticketService.CreateTickets(result);
}

var tickets = ticketService.GetTickets();

ConsoleDataPrinter.PrintTickets(tickets);
//Console.WriteLine(files);

Console.ReadKey();

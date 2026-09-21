

using PDFReader.Repositories;
using PDFReader.Services;
using PDFReader.Services.PDFReaders;
using PDFReader.Utilities;

namespace PDFReader;

internal class PDFReaderProgram(IPDFReader pdfReader)
{
    private readonly IPDFReader _pdfReader = pdfReader;
    private readonly TicketService _ticketService = new();
    private readonly string _destinationFileName = "AggregatedTickets.txt";


    public void Start(string[] filePaths, string folderPath)
    {

        foreach (var file in filePaths)
        {
            var result = _pdfReader.Read(file);

            _ticketService.CreateTickets(result);
        }

        var tickets = _ticketService.GetTickets();

        var formatedString = TicketDataFormater.FormatData(tickets);

        var repository = new FileSystemRepository(folderPath, _destinationFileName);
        repository.Save(formatedString);
    }
}

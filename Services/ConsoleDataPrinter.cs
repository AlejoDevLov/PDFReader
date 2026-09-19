
using PDFReader.DTOs;

namespace PDFReader.Services;

internal class ConsoleDataPrinter
{
    private const int WidthOfTitle = -25;
    private const int WidthOfDate = 10;
    private const int WidthOfTime = 7;

    public static void PrintTickets(IEnumerable<Ticket> tickets)
    {
        foreach (var ticket in tickets)
        {
            Console.WriteLine($"{{0,{WidthOfTitle}}}| {{1,{WidthOfDate}}} | {{2,{WidthOfTime}}}", 
                ticket.Title, ticket.Date, ticket.Time);
        }
    }
}

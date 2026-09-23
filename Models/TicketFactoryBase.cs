using PDFReader.DTOs;
using System.Globalization;

namespace PDFReader.Models;

internal abstract class TicketFactoryBase
{
    protected abstract CultureInfo CultureInfoType { get; }

    public IEnumerable<Ticket> CreateTicket(IEnumerable<string> ticketsData)
    {
        var tickets = new List<Ticket>();

        // This loop is increase by 3 in each iteration to be sure of taking the three values 
        // each ticket has (title, date and time) in case there is more than one ticket in the string.
        // In each iteration we split each line of the ticketData and take only the value of each 'property'
        for (int i = 0; i < ticketsData.Count(); i += 3)
        {
            var title = ticketsData.ElementAt(i).Split("Title:").Last();

            var date = FormatDate(ticketsData.ElementAt(i + 1).Split("Date:").Last());

            var time = FormatTime(ticketsData.ElementAt(i + 2).Split("Time:").Last());

            tickets.Add( new Ticket( title, date, time ));
        }

        return tickets;
    }

    private DateOnly FormatDate(string unformatedDate)
    {
        return DateOnly.Parse(unformatedDate, CultureInfoType);
    }

    private TimeOnly FormatTime(string unformatedTime)
    {
        return TimeOnly.Parse(unformatedTime, CultureInfoType);
    }
}
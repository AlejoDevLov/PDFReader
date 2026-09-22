using PDFReader.DTOs;

namespace PDFReader.Models;

internal abstract class TicketFactoryBase
{
    protected abstract string CultureInfoType { get; init; }

    public IEnumerable<Ticket> CreateTicket(IEnumerable<string> ticketsData)
    {
        var tickets = new List<Ticket>();

        // This loop is increase by 3 in each iteration to be sure of taking the three values 
        // each ticket has (title, date and time) in case there is more than one ticket in the string.
        for (int i = 0; i < ticketsData.Count(); i += 3)
        {
            // Takes the first element in the current iteration(title: nameOfMovie...) and returns the position of semicolon (:) in the string
            // Gets rid of the string at the leftside of the semicolon, leaving only the title of the movie
            var title = ticketsData.ElementAt(i).Split("Title:").Last();

            var date = FormatDate(ticketsData.ElementAt(i + 1).Split("Date:").Last());

            var time = FormatTime(ticketsData.ElementAt(i + 2).Split("Time:").Last());

            tickets.Add( new Ticket( title, date, time ));
        }

        return tickets;
    }

    protected abstract TimeOnly FormatTime(string unformatedTime);
    protected abstract DateOnly FormatDate(string unformatedDate);
}
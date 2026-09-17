using PDFReader.DTOs;
using PDFReader.Utilities;

namespace PDFReader.Services;

internal class TicketService
{
    private readonly List<Ticket> Tickets = [];

    public void Create(string ticketsAsString)
    {
        // returns a IEnumerable<string> with only the necessary info like: title, date and time.
        var ticketsData = ticketsAsString.Split(Environment.NewLine).Skip(2).SkipLast(1);

        if ( ticketsAsString.Contains("www.ourCinema.com"))
        {
            Tickets.AddRange( USTicketFactory.CreateTicket(ticketsData) );
        }
        else if (ticketsAsString.Contains("www.ourCinema.fr"))
        {
            USTicketFactory usFactory = new();
        }
        else if (ticketsAsString.Contains("www.ourCinema.jp"))
        {
            USTicketFactory usFactory = new();
        }
        else
        {
            throw new FormatException("Ticket culture not supported. Domains valid are: '.com', '.jp' y '.fr'");
        }
    }

    public IEnumerable<Ticket> GetTickets() => Tickets;
}

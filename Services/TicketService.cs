using PDFReader.DTOs;
using PDFReader.Models;

namespace PDFReader.Services;

internal class TicketService
{
    private readonly List<Ticket> Tickets = [];

    public void CreateTickets(string ticketsAsString)
    {
        // returns a IEnumerable<string> with only the necessary info like: title, date and time.
        var ticketsData = ticketsAsString.Split(Environment.NewLine).Skip(2).SkipLast(1);

        if ( ticketsAsString.Contains("www.ourCinema.com"))
        {
            USTicketFactory tf = new();
            Tickets.AddRange( tf.CreateTicket(ticketsData) );
        }
        else if (ticketsAsString.Contains("www.ourCinema.fr"))
        {
            FRTicketFactory tf = new();
            Tickets.AddRange(tf.CreateTicket(ticketsData));
        }
        else if (ticketsAsString.Contains("www.ourCinema.jp"))
        {
            JPTicketFactory tf = new();
            Tickets.AddRange(tf.CreateTicket(ticketsData));
        }
        else
        {
            throw new FormatException("Ticket source not supported. Domains valid are: '.com', '.jp' y '.fr'");
        }
    }

    public IEnumerable<Ticket> GetTickets() => Tickets;
}

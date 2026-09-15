using PDFReader.DTOs;

namespace PDFReader.Utilities;

internal class TicketCreator
{
    public IEnumerable<Ticket> Tickets = [];

    public void Create(string ticketsAsString)
    {
        if( ticketsAsString.Contains("www.ourCinema.com"))
        {
            ITicketFactory usFactory = new USTicketFactory();
        }
        else if (ticketsAsString.Contains("www.ourCinema.fr"))
        {
            ITicketFactory frFactory = new FRTicketFactory();
        }
        else if (ticketsAsString.Contains("www.ourCinema.jp"))
        {
            ITicketFactory jpFactory = new JPTicketFactory();
        }
        else
        {
            throw new FormatException("Ticket culture not supported. Domains valid are: '.com', '.jp' y '.fr'");
        }
    }
}

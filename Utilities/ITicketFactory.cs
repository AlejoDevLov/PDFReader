using PDFReader.DTOs;

namespace PDFReader.Utilities
{
    internal interface ITicketFactory
    {
        public IEnumerable<Ticket> CreateTicket(string ticketData);
    }
}

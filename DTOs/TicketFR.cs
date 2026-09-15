namespace PDFReader.DTOs;

internal class TicketFR : Ticket
{
    public override string Culture { get; } = "fr-FR";

    public TicketFR(string title, DateTime date, DateTime time) : base(title, date, time)
    {
    }
}

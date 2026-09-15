namespace PDFReader.DTOs;

internal class TicketUS : Ticket
{
    public override string Culture { get; } = "en-US";

    public TicketUS(string title, DateTime date, DateTime time) : base(title, date, time)
    {
    }
}

namespace PDFReader.DTOs;

internal class TicketJP : Ticket
{
    public override string Culture { get; } = "ja-JP";

    public TicketJP(string title, DateTime date, DateTime time) : base(title, date, time)
    {
    }
}

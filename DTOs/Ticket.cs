
namespace PDFReader.DTOs;

internal class Ticket
{
    public string Title { get; init; }
    public DateTime Date { get; init; }
    public DateTime Time { get; init; }
    public virtual string Culture { get; } = "es-CO";

    public Ticket(string title, DateTime date, DateTime time)
    {
        Title = title;
        Date = date;
        Time = time;
    }
}
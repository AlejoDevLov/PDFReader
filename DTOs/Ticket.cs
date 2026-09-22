
namespace PDFReader.DTOs;

internal class Ticket(string title, DateOnly date, TimeOnly time)
{
    public string Title { get; init; } = title;
    public DateOnly Date { get; init; } = date;
    public TimeOnly Time { get; init; } = time;
}
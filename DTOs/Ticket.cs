
namespace PDFReader.DTOs;

internal class Ticket(string title, DateOnly date, TimeSpan time)
{
    public string Title { get; init; } = title;
    public DateOnly Date { get; init; } = date;
    public TimeSpan Time { get; init; } = time;
}
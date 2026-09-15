
namespace PDFReader.DTOs;

internal readonly record struct Ticket
{
    public string Title { get; init; }
    public DateTime Date { get; init; }
    public DateTime Time { get; init; }
}

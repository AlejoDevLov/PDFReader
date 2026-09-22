using PDFReader.DTOs;
using System.Globalization;
using System.Text;

namespace PDFReader.Utilities;

internal class TicketDataFormater
{
    private const int WidthOfTitle = -25;
    private const int WidthOfDate = 10;
    private const int WidthOfTime = 5;

    public static string FormatData(IEnumerable<Ticket> tickets)
    {
        var sb = new StringBuilder();
        foreach (var ticket in tickets)
        {
            sb.AppendLine(string.Format($"{{0,{WidthOfTitle}}}| {{1,{WidthOfDate}}} | {{2,{WidthOfTime}}}", 
                ticket.Title, 
                ticket.Date.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture), 
                ticket.Time.ToString("HH:mm", CultureInfo.InvariantCulture))
                );
        }
        return sb.ToString();
    }
}

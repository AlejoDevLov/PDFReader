using System.Globalization;

namespace PDFReader.Models;


internal class USTicketFactory : TicketFactoryBase
{
    protected override string CultureInfoType { get; init; } = "en-US";

    protected override DateOnly FormatDate(string unformatedDate)
    {
        var culture = new CultureInfo(CultureInfoType);
        return DateOnly.Parse(unformatedDate, culture);
    }

    protected override TimeOnly FormatTime(string unformatedTime)
    {
        var culture = new CultureInfo(CultureInfoType);
        return TimeOnly.Parse(unformatedTime, culture);
    }
}


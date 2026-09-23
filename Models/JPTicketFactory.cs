using System.Globalization;

namespace PDFReader.Models;


internal class JPTicketFactory : TicketFactoryBase
{
    private static readonly CultureInfo _cultureInfoType = new("ja-JP");

    protected override CultureInfo CultureInfoType => _cultureInfoType;
}
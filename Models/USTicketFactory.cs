using System.Globalization;

namespace PDFReader.Models;


internal class USTicketFactory : TicketFactoryBase
{
    private static readonly CultureInfo _cultureInfoType = new("en-US");

    protected override CultureInfo CultureInfoType => _cultureInfoType;
}


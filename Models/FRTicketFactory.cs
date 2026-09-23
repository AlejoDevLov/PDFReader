using System.Globalization;

namespace PDFReader.Models;


internal class FRTicketFactory : TicketFactoryBase
{
    private static readonly CultureInfo _cultureInfoType = new("fr-FR");

    protected override CultureInfo CultureInfoType => _cultureInfoType;
}
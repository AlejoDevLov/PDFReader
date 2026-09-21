namespace PDFReader.Models;


internal class JPTicketFactory : TicketFactoryBase
{
    protected override DateOnly CreateDate(int[] dateAsArray)
    {
        return new DateOnly(dateAsArray[0], dateAsArray[1], dateAsArray[2]);
    }
}
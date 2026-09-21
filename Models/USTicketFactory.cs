namespace PDFReader.Models;


internal class USTicketFactory : TicketFactoryBase
{
    protected override DateOnly CreateDate(int[] dateAsArray)
    {
        return new DateOnly(dateAsArray[2], dateAsArray[0], dateAsArray[1]);
    }
}
